﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prawo_jazdy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kategoria_A programa = new Kategoria_A();
            programa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategoria_B programa = new Kategoria_B();
            programa.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RezultatyForm rezultatyForm = new RezultatyForm();
            rezultatyForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
