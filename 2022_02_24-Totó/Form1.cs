﻿using System;
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

            string hibásak = "";
            foreach (var ch in textBox1.Text)
            {
                if (ch !='1' && ch!='2' && ch!='X')
                {
                    hibásak += ch + ";";
                }
            }
            checkBox2.Text = $"Helytelen karaktere az eredményekben ({hibásak})";

            if (hibásak.Length==0)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }


        }
    }
}
