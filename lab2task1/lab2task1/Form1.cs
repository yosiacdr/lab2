using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2task1
{
    public partial class Form1 : Form
    {
        string[] list = new string[0];
        
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox2.KeyPress += TextBox2_KeyPress;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {

                    for (int i = 0; i < list.Length; i++)
                    {
                        i = Convert.ToInt32(textBox2.Text);
                        string firstElement = Convert.ToString(listBox1.Items[i]);
                        textBox3.Text += firstElement.ToString();
                        textBox2.Clear();

                    }

                }
                catch
                {
                    MessageBox.Show("Enter correct value!!");
                }
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyChar == (char)Keys.Enter && tb.Text.Length != 0)
            {//Если нажата кнопка Enter
                Array.Resize<string>(ref list, list.Length + 1);//Увеличение размера массива на 1
                list[list.Length - 1] = tb.Text;//Запись нового значения в массив
                listBox1.Items.Clear();//очистка ListBox
                listBox1.Items.AddRange(list);//Добавление в ListBox данных из массива
                tb.Text = string.Empty;//Очистка текстового поля

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = listBox1.Items.Count;
                textBox4.Text = n.ToString();

            }
            catch
            {
                MessageBox.Show("Enter correct value");

            }
        }
    }
}
