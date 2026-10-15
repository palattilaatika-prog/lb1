using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "fel";
            this.Top -= 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "le";
            this.Top += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "bal";
            this.Left -= 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "jobb";
            this.Left += 10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int interval;

            if (int.TryParse(textBox2.Text, out interval))
            {
                if (interval > 0)
                {
                    timer1.Interval = interval;
                }
            }
        }
    }
}
