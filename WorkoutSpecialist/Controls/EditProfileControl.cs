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
    public partial class EditProfileControl : UserControl
    {
        private int userId;

        public EditProfileControl(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            this.Load += EditProfileControl_Load;

        }

        private void EditProfileControl_Load(object sender, EventArgs e)
        {
            using var context = new AppDbContext(Program.DbOptions);
            var user = context.users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                loginTextBox.Text = user.Username;
                mailTextBox.Text = user.Email;

                pswdTextBox.Text = "";
                confirmPswdTextBox.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeLoginBtn_Click(object sender, EventArgs e)
        {
            string newLogin = loginTextBox.Text.Trim();

            if (string.IsNullOrEmpty(newLogin))
            {
                MessageBox.Show("Login nie może być pusty.");
                return;
            }

            if (!Validator.IsValidUsername(newLogin))
            {
                MessageBox.Show("Podany login jest niepoprawny.");
                return;
            }

            using var context = new AppDbContext(Program.DbOptions);
            var user = context.users.FirstOrDefault(u => u.UserId == userId);


            if (user.Username == newLogin)
            {
                MessageBox.Show("Login jest taki sam jak obecny.");
                return;
            }

            bool loginExists = context.users.Any(u => u.Username == newLogin && u.UserId != userId);
            if (loginExists)
            {
                MessageBox.Show("Podany login jest już zajęty.");
                return;
            }

            user.Username = newLogin;
            context.SaveChanges();

            MessageBox.Show("Login został zmieniony pomyślnie.");
        }

        private void changeMailBtn_Click(object sender, EventArgs e)
        {
            string newEmail = mailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Email nie może być pusty.");
                return;
            }

            if (!Validator.IsValidEmail(newEmail))
            {
                MessageBox.Show("Podany email jest niepoprawny.");
                return;
            }

            using var context = new AppDbContext(Program.DbOptions);

            var user = context.users.FirstOrDefault(u => u.UserId == userId);
            if (user == null)
            {
                MessageBox.Show("Użytkownik nie znaleziony.");
                return;
            }

            if (user.Email == newEmail)
            {
                MessageBox.Show("Email jest taki sam jak obecny.");
                return;
            }


            bool emailExists = context.users.Any(u => u.Email == newEmail && u.UserId != userId);
            if (emailExists)
            {
                MessageBox.Show("Podany email jest już używany przez innego użytkownika.");
                return;
            }

            user.Email = newEmail;
            context.SaveChanges();

            MessageBox.Show("Email został zmieniony pomyślnie.");
        }

        private void changePswdBtn_Click(object sender, EventArgs e)
        {
            string newPassword = pswdTextBox.Text;
            string confirmPassword = confirmPswdTextBox.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Proszę wprowadzić i potwierdzić nowe hasło.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Hasła nie są takie same.");
                return;
            }

            if (!Validator.IsValidPassword(newPassword))
            {
                MessageBox.Show("Hasło nie spełnia wymagań.");
                return;
            }

            using var context = new AppDbContext(Program.DbOptions);
            var user = context.users.FirstOrDefault(u => u.UserId == userId);

            if (user == null)
            {
                MessageBox.Show("Użytkownik nie znaleziony.");
                return;
            }
            context.SaveChanges();

            MessageBox.Show("Hasło zostało zmienione pomyślnie.");

            pswdTextBox.Text = "";
            confirmPswdTextBox.Text = "";
        }

        private void pswdTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void confirmPswdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
