﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp52
{
    public partial class Form1 : Form
    {
        private List<float> x, y;
        private float a, b;
        private float sxy, sx2, sx, sy, sc;

        private void Form1_Load(object sender, EventArgs e)
        {
            x = new List<float>();
            y = new List<float>();
            dataGridView1.ColumnCount = 2;
            label1.Text = null;
            textBox1.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                x.Add((float)Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                y.Add((float)Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            for (int i = 0; i < x.Count; i++)
            {
                sx += x[i]; sy += y[i];
                sxy += x[i] * y[i];
                sx2 += x[i] * y[i];
            }
                a = ((x.Count*sxy-sx*sy) / (x.Count*sx2-sx*sx));
                b = ((sy - a * sx) / (x.Count));
            for (int i = 0; i < x.Count; i++)
            {
                sc += ((y[i] - (a * x[i] + b)) * (y[i] - (a * x[i] + b)));
            }
                textBox1.Text = Convert.ToString(sc);
                label1.Text = "y=" + a + "x+" + b;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            x.Clear();
            y.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 2;
            label1.Text = null;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         public Form1()
        {
            InitializeComponent();
        }
    }
}
