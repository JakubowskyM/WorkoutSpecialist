using System;
using System.Linq;
using System.Windows.Forms;
using WorkoutSpecialist.Data;

namespace WorkoutSpecialist.Controls
{
    public partial class WorkoutsControl : UserControl
    {
        private int userId;

        public WorkoutsControl(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            btnFilter.Click += btnFilter_Click;
            this.Load += WorkoutsControl_Load;
            workoutsDataGridView.CellClick += WorkoutsDataGridView_CellClick;
        }

        private void WorkoutsControl_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);
            dateTimePickerTo.Value = DateTime.Today;

            LoadWorkouts();
        }

        private void LoadWorkouts()
        {
            using var context = new AppDbContext(Program.DbOptions);

            var fromDate = dateTimePickerFrom.Value.Date;
            var toDate = dateTimePickerTo.Value.Date.AddDays(1).AddTicks(-1);

            var workouts = context.workouts
                .Where(w => w.UserId == userId && w.Date >= fromDate && w.Date <= toDate)
                .OrderByDescending(w => w.Date)
                .Select(w => new
                {
                    w.WorkoutId,
                    Date = w.Date.ToString("yyyy-MM-dd"),
                    Note = w.Note
                })
                .ToList();

            workoutsDataGridView.DataSource = workouts;

            workoutDetailsDataGridView.DataSource = null; // Czyścimy szczegóły
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadWorkouts();
        }

        private void WorkoutsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = workoutsDataGridView.Rows[e.RowIndex];
            if (selectedRow == null) return;

            int workoutId = Convert.ToInt32(selectedRow.Cells["WorkoutId"].Value);

            ShowWorkoutDetails(workoutId);
        }

        private void ShowWorkoutDetails(int workoutId)
        {
            using var context = new AppDbContext(Program.DbOptions);

            var workoutDetails = context.workoutExercises
                .Where(we => we.WorkoutId == workoutId)
                .Select(we => new
                {
                    Exercise = we.Exercise.Name,
                    we.Sets,
                    we.Reps,
                    we.Weight
                })
                .ToList();

            workoutDetailsDataGridView.DataSource = workoutDetails;
        }
    }
}
