using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadachi
{
    public partial class Form1 : Form
    {
        Random R;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            int[] arr = new int[10];

            for (int i = 0; i<10;i++)
            {
                arr[i] = R.Next(-100, 101);
                richTextBox1.Text += arr[i] + " ";
            }
            for (int i =0; i<10;i++)
            {
                if (arr[i] < -50 )
                {
                    arr[i] = 0;
                }
                if (arr[i] > 50)
                {
                    arr[i] = 0;
                }
               richTextBox2.Text += arr[i] + " ";
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            R = new Random();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            richTextBox1.Text = "";
            int[,] arr = new int[5,6]; // двумерный массив
            int a = 10; // создали начальный элемент - 10

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = a;
                    a++; // начальное число будет 10 и по порядку будет возрастать
                    richTextBox1.Text += arr[i, j] + " "; //вывод в виде таблицы
                }
                richTextBox1.Text += "\n";  // вывод в виде таблицы
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int summa = arr[i, j] / 10 + arr[i, j] % 10; // сумма цифр
                    if (summa > 5)
                    {
                       arr[i, j] -= 10; // будет уменьшаться на 10
                    }
                    richTextBox2.Text += arr[i, j] + " ";
                }
                richTextBox2.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>(); // пустой лист

            for ( int i = 0; i < 15; i++) // создали лист 15 элементов
            {
                list.Add(R.Next(1, 11));
                richTextBox1.Text += list[i] + " ";
            }
            list = new List<int>();
            for ( int i = 0; i < 15; i++)
            {
                //if (i % 2 == 1)
            }
        }
    }
}
