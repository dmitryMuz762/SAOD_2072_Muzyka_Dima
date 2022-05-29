using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_
{
    public partial class Form1 : Form
    {
        Queue <int> Queue;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_push_Click(object sender, EventArgs e)
        {
            label_stack.Text = "";
            bool Num = Int32.TryParse(textBox_input.Text, out int num); // - проверка на цифры
            if (!Num)
            {
                label_stack.Text = "Не верно введены данные";
            }
            else
            {
                Queue.Push(num);
            }
        }

        private void button_pop_Click(object sender, EventArgs e)
        {
            label_stack.Text = "";
            bool Num = Int32.TryParse(textBox_input.Text, out int num); // - проверка на цифры
            if (!Num)
            {
                label_stack.Text = "Не верно введены данные";
            }
            else
            {
                label_stack.Text = Queue.Pop().ToString();
            }
            
        }

        private void button_top_Click(object sender, EventArgs e)
        {
            label_stack.Text = "";
            bool Num = Int32.TryParse(textBox_input.Text, out int num); // - проверка на цифры
            if (!Num)
            {
                label_stack.Text = "Не верно введены данные";
            }
            else
            {
                label_stack.Text = Queue.Top().ToString();
            }
            
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            label_stack.Text = "";
            bool Num = Int32.TryParse(textBox_input.Text, out int num); // - проверка на цифры
            if (!Num)
            {
                label_stack.Text = "Не верно введены данные";
            }
            else
            {
                Queue.Clean();
            }
            
        }

        private void button_toarray_Click(object sender, EventArgs e)
        {
            label_stack.Text = "";
            bool Num = Int32.TryParse(textBox_input.Text, out int num); // - проверка на цифры
            if (!Num)
            {
                label_stack.Text = "Не верно введены данные";
            }
            else
            {
                label_stack.Text = String.Join(" ", Queue.ToArray());
            }
            
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            try
            {
                Queue = new Queue<int>(int.Parse(size.Text));
                textBox_input.Enabled = true;
                button_push.Enabled = true;
                button_pop.Enabled = true;
                button_top.Enabled = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBox_input.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
