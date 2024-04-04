using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;


namespace Multi_Threading_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> list = new List<double>();

        private async void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int count) && count > 0)
            {
                listBox1.Items.Clear();
                await Task.Run(() =>
                {
                    CalculateFibonacci(count);

                });
                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }


            }
        }

        private void CalculateFibonacci(int n)
        {
            Thread.Sleep(1000);
            double a = 0;
            double b = 1;
            double c = 0;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                list.Add(c);
            }


        }

    }
}
