using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb1EXER
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

        private void button3_Click(object sender, EventArgs e)
        {
            //up
            label1.Top -= 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //left
            label1.Left -= 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //down
            label1.Top += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //right
            label1.Left += 10;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Location= new Point(200,200);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Text= "Hurraaay!";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Green;
            button11.Text= "START!";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;
            button11.Text="STOP!";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label3.Location = new Point(10, 10);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Location= new Point(10,ClientSize.Height-label3.Height-10);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button16.Font=new Font("Arial", 10, FontStyle.Regular);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button16.Font = new Font("Arial", 12, FontStyle.Bold);
            button16.ForeColor = Color.Red;
            button16.Text = "Red";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(Pens.Black, 50, 40, 250, 150);
            g.DrawLine(Pens.Red, 50, 40, 300, 190);
            g.DrawLine(Pens.Blue, 300, 40, 50, 190);
        }
    }
}
