namespace skills_international
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Username = "Admin";
            String Password = "Skills@123";

            if (textBox1.Text == Username & textBox2.Text == Password)
            {
                MessageBox.Show("Succesfullyb login");
                Student_Registration___Skills_International sturegform = new Student_Registration___Skills_International();
                sturegform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid login credentials,please check username and password and try again");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("exit successfully");

            Application.Exit();
            this.Hide();
        }
    }
}
