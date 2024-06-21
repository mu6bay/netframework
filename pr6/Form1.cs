using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab6
{
    public partial class Form1 : Form
    {
        int n, m, i, j;

        private void button1_Click(object sender, EventArgs e)
        {
            //Добавляем строку с номером rowNumber
            int rowNumber = dataGridView1.Rows.Add();
            //Заполняем ячейки
            dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber;
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowNumber].Cells[2].Value = textBox2.Text;
            // можно по номеру столбца а можно по идентефикатору
            dataGridView1.Rows[rowNumber].Cells["Tel"].Value = textBox3.Text;
            //Стираем поля ввода для новой информации
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = dataGridView1.RowCount; // определяем число строк
            m = dataGridView1.ColumnCount; // определяем число столбцов
                                           //Создаём или перезаписываем существующий файл
            StreamWriter sw = File.CreateText("data.txt");
            //Записываем текст в поток файла
            sw.WriteLine(Convert.ToString(n));
            sw.WriteLine(Convert.ToString(m));
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    sw.WriteLine(Convert.ToString(dataGridView1[j, i].Value));
                }
            }
            //Закрываем файл
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Создаем файловую переменную для чтения данных
            StreamReader f = new StreamReader("data.txt");
            //читаем первые две строки из файла
            n = Convert.ToInt32(f.ReadLine());
            m = Convert.ToInt32(f.ReadLine());
            //перебираем строки
            for (i = 0; i < n - 1; i++)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["ID"].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[1].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[2].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells["Tel"].Value = f.ReadLine();
            }
            //Закрываем файл
            f.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("Fa", "Фамилия");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Tel", "Телефон");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
