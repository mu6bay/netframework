using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фффффффффффффффф
{
    public partial class Form1 : Form
    {
        int x1 = 0;
        int x2 = 0;
        int flag1 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            flag1 = 1;
            timer1.Start();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            x1 = 1; x2 = 1;
            pictureBox1.Left = x1;
            pictureBox2.Left = x2;
            flag1 = 0;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = "Левый таракан";
            textBox2.Text = "Правый таракан";
            label1.Text = "0";
            label2.Text = "0";
            pictureBox1.Left = 1;
            pictureBox2.Left = 1;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random a = new Random();

            int count = a.Next(8);
            x1 += count;
            label1.Text = Convert.ToString(x1);
            pictureBox1.Left = x1;


            count = a.Next(8);
            x2 += count;
            label2.Text = Convert.ToString(x2);
            pictureBox2.Left = x2;


            if (x1 >= 578 || x2 >= 578)
            {
                flag1 = 0;
                timer1.Stop();
            }
        }
    }
}

