using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutSpecialist
{
    public partial class RegisterForm : Form
    {
        private Form1 form1;

        public RegisterForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void rgrBtn_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text.Trim();
            string email = emailBox.Text.Trim();
            string password = pswdBox.Text;
            string confirmPassword = repPswdBox.Text;

            if (!Validator.IsValidUsername(login))
            {
                rgrErrLabel.Text = "Przepraszamy, ta nazwa użytkownika jest nieodpowiednia (min. 3 litery).";
                return;
            }

            if (!Validator.IsValidEmail(email))
            {
                rgrErrLabel.Text = "Podany adres e-mail jest niepoprawny.";
                return;
            }

            if (!Validator.IsValidPassword(password))
            {
                rgrErrLabel.Text = "Hasło musi mieć min. 8 znaków, jedną dużą literę i cyfrę.";
                return;
            }

            if (password != confirmPassword)
            {
                rgrErrLabel.Text = "Hasła nie są takie same.";
                return;
            }

            MessageBox.Show("Rejestracja zakończona sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rgrErrLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
