using Microsoft.Win32;
using WorkoutSpecialist.Data;

namespace WorkoutSpecialist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = loginBox.Text.Trim();
            string password = pswdBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lgnErrLabel.Text = "Prosz� wprowadzi� nazw� u�ytkownika i has�o.";
                return;
            }

            // Tutaj wa�ne: Has�o w bazie jest przechowywane jako hash.
            // Tu dla uproszczenia por�wnujemy bezpo�rednio (NIE ZALECANE W PRAKTYCE).
            // W praktyce has�o nale�y zahashowa� i por�wna� z PasswordHash.

            using (var context = new AppDbContext(Program.DbOptions))
            {
                var user = context.users
                    .FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

                if (user != null)
                {
                    lgnErrLabel.Text = "Zalogowano pomy�lnie.";
                    // Tu mo�esz otworzy� nowe okno, zapisa� dane u�ytkownika itp.
                }
                else
                {
                    lgnErrLabel.Text = "Nieprawid�owa nazwa u�ytkownika lub has�o.";
                }
            }

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this);
            this.Hide();
            registerForm.Show();
        }
    }
}
