using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutSpecialist.Controls;
namespace WorkoutSpecialist
{
    public partial class MainForm : Form
    {
        private int userId;
        private string username;

        public MainForm(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;

            welcomeLabel.Text = $"Witaj, {username}";

            LoadControl(new DashboardControl(userId));
        }

        private void LoadControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl(userId));
        }

        private void workoutsBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new WorkoutsControl(userId));
        }

        private void addWoutBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddWorkoutControl(userId));
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new EditProfileControl(userId));
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wylogowanie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }
    }
}
