namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToInt32(textBox1.Text);
            result = Math.Round((number - 32) * 5 / 9, 2);
            label12.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToInt32(textBox2.Text);
            result = Math.Round((number * 1.8) + 32, 2);
            label13.Text = result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToInt32(textBox3.Text);
            result = Math.Round(number * 1000);
            label10.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToInt32(textBox4.Text);
            result = Math.Round(number / 1000);
            label11.Text = result.ToString();

        }
    }
}