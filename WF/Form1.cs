using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder a = new StringBuilder(textBox1.Text);
            char x = '(';
            char y = ')';
            int Markx = 0;
            int Marky = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == x) Markx = i;
                if (a[i] == y) Marky = i;
            }
            int j = 0;
            string[] a2 = new string[a.Length - (Marky - Markx + 1)];
            for (int i = 0; i < a.Length; i++)
            {
                if ((i < Markx) || (i > Marky))
                {
                    while (j < a2.Length)
                    {
                        a2[j] = a[i].ToString();
                        j++;
                        break;
                    }
                }
            }
            string a3 = "";
            for (int i = 0; i < a2.Length; i++)
            {
                a3 += a2[i];
            }
            textBox2.Text = a3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox4.Text;
            input = input.ToLower();
            string[] str = input.Split(' ');
            int marker = 0;
            int n = int.Parse(textBox5.Text);
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && (str[j] != ""))
                    {
                        marker++;
                    }
                }
                if (marker >= n)
                {
                    textBox3.Text += "Слово " + str[i] + " Встречалось " + marker + " раза" + Environment.NewLine; 
                }
                marker = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && (i != j))
                    {
                        str[j] = "";
                    }
                }
                str[i] = "";
            }


        }
    }
}
