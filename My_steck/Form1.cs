using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_steck
{
    public partial class Form1 : Form
    {
        My_steck<int> stack;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonPush_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Push(int.Parse(Value.Text));
                UpdateListBox();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                Value.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void buttonTop_Click(object sender, EventArgs e)
        {
            try
            {
                show.Text = stack.Top().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonPop_Click(object sender, EventArgs e)
        {
            try
            {
                show.Text = stack.Pop().ToString();
                UpdateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateListBox()
        {
            int[] array = stack.ToArray();
            res.Items.Clear();
            foreach (int value in array)
            {
                if (value != default)
                {
                    res.Items.Add(value);
                }
            }
        }

        

        private void Restart_Click(object sender, EventArgs e)
        {
            try
            {
                stack = new My_steck<int>(int.Parse(Shape.Text));
                Value.Enabled = true;
                buttonPop.Enabled = true;
                buttonPush.Enabled = true;
                buttonTop.Enabled = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                Value.Clear();
            }
        }

       
    }
}
