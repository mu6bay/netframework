using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\user\Desktop\21ИС\WindowsFormsApp2\bin\Debug";
            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening folder: " + ex.Message);
            }
        }

        private void рисунок1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Ris 1.jpg");
        }

        private void рисунок2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Ris 2.jpg");
        }

        private void рисунок3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Ris 3.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
