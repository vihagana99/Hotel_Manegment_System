namespace Hotel_Manegment_Syatem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();

            if (username.Text == "sayuru" && password.Text == "1234")
            {
                lebelwrong.Visible = false;
                
            }
            else
            {
                lebelwrong.Visible = true;
            }
            

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
