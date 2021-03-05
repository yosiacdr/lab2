using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb2
{
    public partial class Form1 : Form
    {
        string[,] mass = new string[1, 1];
        public Form1()
        {
            InitializeComponent();
            EnterYourValueTextBox.KeyPress += EnterYourValueTextBox_KeyPress;
            EnterYourIndexTextBox.KeyPress += EnterYourIndexTextBox_KeyPress;
        }

        private void EnterYourIndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    for (int i = 0; i < mass.Length; i++)
                    {
                        i = Convert.ToInt32(EnterYourIndexTextBox.Text);
                        string firstElement = Convert.ToString(OutputValueListBox.Items[i]);
                        OutputIndexTextBox.Text += firstElement.ToString();
                        EnterYourIndexTextBox.Clear();

                    }
                }
                catch
                {
                    MessageBox.Show("Enter correct value");
                }
               
            }
        }

        private void EnterYourValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s;
            TextBox tb = sender as TextBox;
            if (e.KeyChar == (char)Keys.Enter && tb.Text.Length != 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    s = "";
                    for (int j = 0; j < 1; j++)
                    {
                        mass[i, j] = EnterYourValueTextBox.Text;
                        s += (mass[i, j]).ToString() + "  ";
                        OutputValueListBox.Items.Add(s);
                        EnterYourValueTextBox.Clear();
                    }

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Point lastPoint1;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint1.X;
                this.Top += e.Y - lastPoint1.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = new Point(e.X, e.Y);
        }

        private void OutputIndexTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountTheAmountButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = OutputValueListBox.Items.Count;
                OutputCountTextBox.Text = n.ToString();

            }
            catch
            {
                MessageBox.Show("Enter correct value");

            }
        }
    }
    }

