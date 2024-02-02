using Lab04.Resources;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            Combee combee = new();
            labelName.Text = combee.Name();
            pictureBox1.Image = Lab04.Properties.Resources.combee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plusle plusle = new();
            labelName.Text = plusle.Name();

            pictureBox1.Image = Lab04.Properties.Resources.Chansey;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ditto ditto = new();
            labelName.Text = ditto.Name();

            pictureBox1.Image = Lab04.Properties.Resources.Ditto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            otodile totodile = new();
            labelName.Text = totodile.Name();

            pictureBox1.Image = Lab04.Properties.Resources.otodile;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Togepi togepi = new();
            labelName.Text = togepi.Name();

            pictureBox1.Image = Lab04.Properties.Resources.Togepi;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Jumpluff jumpluff = new();
            labelName.Text = jumpluff.Name();
            pictureBox1.Image = jumpluff.Picture();
        }
    }
}
