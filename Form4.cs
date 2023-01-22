using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab003
{
    public partial class Form4 : Form
    {
        int m = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label9.Text = "Correct";
                m = m + 1;
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                label9.Text = "Incorrect";
                label9.ForeColor = Color.Red;
            }
            else
            {
                label9.Text = "Unchecked";
                label9.ForeColor = Color.Blue;
            }

            if (radioButton8.Checked)
            {
                label11.Text = "Correct";
                m = m + 1;
            }
            else if (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked)
            {
                label11.Text = "Incorrect";
                label11.ForeColor = Color.Red;
            }
            else
            {
                label11.Text = "Unchecked";
                label11.ForeColor = Color.Blue;
            }

            if (radioButton11.Checked)
            {
                label12.Text = "Correct";
                m = m + 1;
            }
            else if (radioButton12.Checked || radioButton9.Checked || radioButton10.Checked)
            {
                label12.Text = "Incorrect";
                label12.ForeColor = Color.Red;
            }
            else
            {
                label12.Text = "Unchecked";
                label12.ForeColor = Color.Blue;
            }

            if (radioButton14.Checked)
            {
                label13.Text = "Correct";
                m = m + 1;
            }
            else if (radioButton13.Checked || radioButton15.Checked || radioButton16.Checked)
            {
                label13.Text = "Incorrect";
                label13.ForeColor = Color.Red;
            }
            else
            {
                label13.Text = "Unchecked";
                label13.ForeColor = Color.Blue;
            }
            if (radioButton19.Checked)
            {
                label14.Text = "Correct";
                m = m + 1;
            }
            else if (radioButton17.Checked || radioButton18.Checked || radioButton20.Checked)
            {
                label14.Text = "Incorrect";
                label14.ForeColor = Color.Red;
            }
            else
            {
                label14.Text = "Unchecked";
                label14.ForeColor = Color.Blue;
            }

            label15.Text = m.ToString() + "/5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
            Refresh();
        }
    }
}
