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
                lgnErrLabel.Text = "Proszê wprowadziæ nazwê u¿ytkownika i has³o.";
                return;
            }

            // Tutaj wa¿ne: Has³o w bazie jest przechowywane jako hash.
            // Tu dla uproszczenia porównujemy bezpoœrednio (NIE ZALECANE W PRAKTYCE).
            // W praktyce has³o nale¿y zahashowaæ i porównaæ z PasswordHash.

            using (var context = new AppDbContext(Program.DbOptions))
            {
                var user = context.users
                    .FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

                if (user != null)
                {
                    lgnErrLabel.Text = "Zalogowano pomyœlnie.";
                    // Tu mo¿esz otworzyæ nowe okno, zapisaæ dane u¿ytkownika itp.
                }
                else
                {
                    lgnErrLabel.Text = "Nieprawid³owa nazwa u¿ytkownika lub has³o.";
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
