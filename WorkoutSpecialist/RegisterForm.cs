using Workoutspecialist.Models;
using WorkoutSpecialist.Data;

namespace WorkoutSpecialist
{
    public partial class RegisterForm : Form
    {
        private Form1 form1;

        public RegisterForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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

            using (var context = new AppDbContext(Program.DbOptions))
            {
                if (context.users.Any(u => u.Username == login))
                {
                    rgrErrLabel.Text = "Użytkownik o tej nazwie już istnieje.";
                    return;
                }

                var newUser = new Users
                {
                    Username = login,
                    Email = email,
                    PasswordHash = password,
                    RegistrationDate = DateTime.Now
                };

                context.users.Add(newUser);
                context.SaveChanges();
            }

            MessageBox.Show("Rejestracja zakończona sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            form1.Show();
        }


        private void rgrErrLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void repPswdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
