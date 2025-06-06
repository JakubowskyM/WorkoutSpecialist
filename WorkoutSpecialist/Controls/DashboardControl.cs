using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutSpecialist.Data;

namespace WorkoutSpecialist.Controls
{
    public partial class DashboardControl : UserControl
    {
        private int userId;

        public DashboardControl(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            using var context = new AppDbContext(Program.DbOptions);

            // Najwcześniejsza data treningu użytkownika (lub null, jeśli brak)
            var firstWorkoutDate = context.workouts
                .Where(w => w.UserId == userId)
                .OrderBy(w => w.Date)
                .Select(w => (DateTime?)w.Date)
                .FirstOrDefault();

            if (firstWorkoutDate != null)
            {
                firstWorkoutDateLabel.Text = $"Ćwiczysz od: {firstWorkoutDate.Value.ToShortDateString()}";
            }
            else
            {
                firstWorkoutDateLabel.Text = "Brak treningów";
            }

            
            var totalKg = (from w in context.workouts
                           join we in context.workoutExercises on w.WorkoutId equals we.WorkoutId
                           where w.UserId == userId
                           select (we.Sets * we.Reps * (decimal)we.Weight))
                           .Sum();

            totalKgLabel.Text = $"Łącznie wyciśnięto: {Math.Round(totalKg, 2)} kg";

        }
    }

}
