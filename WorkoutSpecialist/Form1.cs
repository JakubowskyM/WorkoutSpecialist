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
            this.Hide();

            Main main = new Main();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
