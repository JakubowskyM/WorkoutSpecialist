using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Workoutspecialist.Models;
using WorkoutSpecialist.Data;

namespace WorkoutSpecialist.Controls
{
    public partial class AddWorkoutControl : UserControl
    {
        private const int MaxExercises = 5;
        private List<ExerciseRow> exerciseRows = new List<ExerciseRow>();
        private int userId;
        private Panel headerPanel;

        public AddWorkoutControl(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            exercisesQuantity.Minimum = 1;
            exercisesQuantity.Maximum = MaxExercises;
            exercisesQuantity.Value = 1;
        }

        private void AddWorkoutControl_Load(object sender, EventArgs e)
        {
            exercisesQuantity.ValueChanged += exercisesQuantity_ValueChanged;
            button1.Click += button1_Click;
            CreateHeaderLabels();
            GenerateRows((int)exercisesQuantity.Value);
        }

        private void CreateHeaderLabels()
        {
            if (headerPanel == null || !this.Controls.Contains(headerPanel))
            {
                headerPanel = new Panel
                {
                    Height = 25,
                    Dock = DockStyle.Top
                };

                var exerciseLabel = new Label { Text = "Ćwiczenie", Location = new Point(0, 5), Width = 120 };
                var setsLabel = new Label { Text = "Serie", Location = new Point(130, 5), Width = 40 };
                var repsLabel = new Label { Text = "Powtórzenia", Location = new Point(180, 5), Width = 50 };
                var weightLabel = new Label { Text = "Ciężar", Location = new Point(260, 5), Width = 50 };

                headerPanel.Controls.AddRange(new Control[] { exerciseLabel, setsLabel, repsLabel, weightLabel });

                var parentPanel = exercisesPanel.Parent;
                if (parentPanel != null)
                {
                    var exercisesPanelIndex = parentPanel.Controls.GetChildIndex(exercisesPanel);
                    parentPanel.Controls.Add(headerPanel);
                    parentPanel.Controls.SetChildIndex(headerPanel, exercisesPanelIndex);
                }
                else
                {
                    this.Controls.Add(headerPanel);
                    this.Controls.SetChildIndex(headerPanel, 0);
                }
            }
        }

        private void exercisesQuantity_ValueChanged(object sender, EventArgs e)
        {
            int count = (int)exercisesQuantity.Value;
            GenerateRows(count);
        }

        private void GenerateRows(int count)
        {
            exercisesPanel.Controls.Clear();
            foreach (var row in exerciseRows)
            {
                row.Dispose();
            }
            exerciseRows.Clear();

            if (count < 1) count = 1;
            if (count > MaxExercises) count = MaxExercises;

            using var context = new AppDbContext(Program.DbOptions);
            var exercises = context.exercises.ToList();

            for (int i = 0; i < count; i++)
            {
                var row = new ExerciseRow();
                row.Location = new Point(0, i * 35);
                row.ExerciseComboBox.DataSource = new BindingSource(exercises, null);
                row.ExerciseComboBox.DisplayMember = "Name";
                row.ExerciseComboBox.ValueMember = "ExerciseId";
                row.ExerciseComboBox.SelectedIndex = -1;
                exercisesPanel.Controls.Add(row);
                exerciseRows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (exerciseRows.All(row => row.ExerciseComboBox.SelectedItem == null ||
                                         (string.IsNullOrWhiteSpace(row.SetsTextBox.Text) &&
                                          string.IsNullOrWhiteSpace(row.RepsTextBox.Text) &&
                                          string.IsNullOrWhiteSpace(row.WeightTextBox.Text))))
            {
                MessageBox.Show("Dodaj przynajmniej jedno ćwiczenie z uzupełnionymi danymi.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var context = new AppDbContext(Program.DbOptions);
            var workout = new Workouts
            {
                UserId = userId,
                Note = string.IsNullOrWhiteSpace(noteBox.Text) ? null : noteBox.Text.Trim()
            };

            bool hasValidExerciseEntry = false;

            foreach (var row in exerciseRows)
            {
                if (row.ExerciseComboBox.SelectedItem is not Exercises selectedExercise)
                {
                    if (string.IsNullOrWhiteSpace(row.SetsTextBox.Text) &&
                        string.IsNullOrWhiteSpace(row.RepsTextBox.Text) &&
                        string.IsNullOrWhiteSpace(row.WeightTextBox.Text))
                    {
                        continue;
                    }
                    else
                    {
                        MessageBox.Show("Uzupełnij wszystkie dane dla wybranych ćwiczeń (serie, powtórzenia, ciężar) lub upewnij się, że są to poprawne liczby nieujemne.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (!int.TryParse(row.SetsTextBox.Text, out int sets) || sets < 0 ||
                    !int.TryParse(row.RepsTextBox.Text, out int reps) || reps < 0 ||
                    !float.TryParse(row.WeightTextBox.Text, out float weight) || weight < 0)
                {
                    MessageBox.Show($"Podano nieprawidłowe dane dla ćwiczenia '{selectedExercise.Name}'. Upewnij się, że wartości są nieujemne i liczbowe.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                workout.WorkoutExercises.Add(new Workoutexercises
                {
                    ExerciseId = selectedExercise.ExerciseId,
                    Sets = sets,
                    Reps = reps,
                    Weight = weight
                });

                hasValidExerciseEntry = true;
            }

            if (!hasValidExerciseEntry)
            {
                MessageBox.Show("Żadne ćwiczenie nie zostało poprawnie uzupełnione. Trening nie został zapisany.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                context.workouts.Add(workout);
                context.SaveChanges();
                MessageBox.Show("Trening zapisany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zapisu treningu: {ex.Message}", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            noteBox.Clear();
            exercisesQuantity.Value = 1;
        }
    }

    public class ExerciseRow : UserControl
    {
        public ComboBox ExerciseComboBox { get; private set; }
        public TextBox SetsTextBox { get; private set; }
        public TextBox RepsTextBox { get; private set; }
        public TextBox WeightTextBox { get; private set; }

        public ExerciseRow()
        {
            ExerciseComboBox = new ComboBox { Width = 120, DropDownStyle = ComboBoxStyle.DropDownList };
            SetsTextBox = new TextBox { Width = 40 };
            RepsTextBox = new TextBox { Width = 50 };
            WeightTextBox = new TextBox { Width = 50 };

            Controls.AddRange(new Control[] { ExerciseComboBox, SetsTextBox, RepsTextBox, WeightTextBox });

            ExerciseComboBox.Location = new Point(0, 0);
            SetsTextBox.Location = new Point(130, 0);
            RepsTextBox.Location = new Point(185, 0);
            WeightTextBox.Location = new Point(240, 0);

            Size = new Size(300, 30);

            SetsTextBox.KeyPress += NumberTextBox_KeyPress;
            RepsTextBox.KeyPress += NumberTextBox_KeyPress;
            WeightTextBox.KeyPress += NumberTextBox_KeyPressFloat;
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void NumberTextBox_KeyPressFloat(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == ',' && tb.Text.Contains(','))
            {
                e.Handled = true;
            }
        }
    }
}