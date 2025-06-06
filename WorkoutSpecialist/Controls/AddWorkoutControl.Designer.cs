namespace WorkoutSpecialist.Controls
{
    partial class AddWorkoutControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            exercisesPanel = new FlowLayoutPanel();
            addExerciseBtn = new Button();
            workoutSaveBtn = new Button();
            label1 = new Label();
            remExerciseBtn = new Button();
            label2 = new Label();
            noteTextBox = new TextBox();
            label3 = new Label();
            dateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // exercisesPanel
            // 
            exercisesPanel.Location = new Point(231, 44);
            exercisesPanel.Name = "exercisesPanel";
            exercisesPanel.Size = new Size(266, 243);
            exercisesPanel.TabIndex = 0;
            exercisesPanel.Paint += exercisesPanel_Paint;
            // 
            // addExerciseBtn
            // 
            addExerciseBtn.Location = new Point(281, 18);
            addExerciseBtn.Name = "addExerciseBtn";
            addExerciseBtn.Size = new Size(105, 23);
            addExerciseBtn.TabIndex = 0;
            addExerciseBtn.Text = "Dodaj ćwiczenie";
            addExerciseBtn.UseVisualStyleBackColor = true;
            addExerciseBtn.Click += addExerciseBtn_Click;
            // 
            // workoutSaveBtn
            // 
            workoutSaveBtn.Location = new Point(392, 293);
            workoutSaveBtn.Name = "workoutSaveBtn";
            workoutSaveBtn.Size = new Size(105, 23);
            workoutSaveBtn.TabIndex = 1;
            workoutSaveBtn.Text = "Zapisz trening";
            workoutSaveBtn.UseVisualStyleBackColor = true;
            workoutSaveBtn.Click += workoutSaveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 2;
            label1.Text = "Dodawanie treningu";
            // 
            // remExerciseBtn
            // 
            remExerciseBtn.Location = new Point(392, 19);
            remExerciseBtn.Name = "remExerciseBtn";
            remExerciseBtn.Size = new Size(105, 23);
            remExerciseBtn.TabIndex = 3;
            remExerciseBtn.Text = "Usuń ćwiczenie";
            remExerciseBtn.UseVisualStyleBackColor = true;
            remExerciseBtn.Click += remExerciseBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 4;
            label2.Text = "Notatka do treningu:";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(14, 62);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(202, 62);
            noteTextBox.TabIndex = 5;
            noteTextBox.TextChanged += noteTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "Podaj date:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(14, 155);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(202, 23);
            dateTimePicker.TabIndex = 7;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // AddWorkoutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker);
            Controls.Add(label3);
            Controls.Add(noteTextBox);
            Controls.Add(label2);
            Controls.Add(remExerciseBtn);
            Controls.Add(label1);
            Controls.Add(workoutSaveBtn);
            Controls.Add(addExerciseBtn);
            Controls.Add(exercisesPanel);
            Name = "AddWorkoutControl";
            Size = new Size(500, 322);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel exercisesPanel;
        private Button addExerciseBtn;
        private Button workoutSaveBtn;
        private Label label1;
        private Button remExerciseBtn;
        private Label label2;
        private TextBox noteTextBox;
        private Label label3;
        private DateTimePicker dateTimePicker;
    }
}
