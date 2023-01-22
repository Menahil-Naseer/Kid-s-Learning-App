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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 check = new Form2();
            check.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 check = new Form3();
            check.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 check = new Form4();
            check.Show();
            Hide();
        }
    }
}
