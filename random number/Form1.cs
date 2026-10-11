using System;
using System.Windows.Forms;

namespace random_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int reqem;
        int cehdSayi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox2.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            reqem = random.Next(0, 101);

            cehdSayi = 0;
            richTextBox1.Clear();
            richTextBox2.Clear();
            errorProvider1.Clear();

            button1.Enabled = true;
            richTextBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (richTextBox2.Text == "")
            {
                errorProvider1.SetError(richTextBox2, "Axtarılan ədəd xanası boş ola bilməz!");
            }
            else
            {
                int daxilEdilen = int.Parse(richTextBox2.Text);
                cehdSayi++;

                if (daxilEdilen == reqem)
                {
                    richTextBox1.Text = "Oyunu qazandınız!\nCəhd sayı: " + cehdSayi;
                    richTextBox2.Enabled = false;
                    button1.Enabled = false;
                }
                else if (daxilEdilen > reqem)
                {
                    richTextBox1.Text = "Siz yanlış tapdınız!\nCəhd sayı: " + cehdSayi + "\nDaxil etdiyiniz ədəd gizli ədəddən böyükdür.";
                }
                else
                {
                    richTextBox1.Text = "Siz yanlış tapdınız!\nCəhd sayı: " + cehdSayi + "\nDaxil etdiyiniz ədəd gizli ədəddən kiçikdir.";
                }
            }
        }
    }
}