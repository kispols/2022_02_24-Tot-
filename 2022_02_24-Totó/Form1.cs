using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_02_24_Totó
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 14)
            {
                checkBox1.Checked = false  ;
            }
            else
            {
                checkBox1.Checked = true;
            }
            checkBox1.Text = $"Nem megfelelő a karakterek száma ({textBox1.Text.Length})";
        }
    }
}
