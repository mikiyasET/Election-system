﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Presidential_Election_system
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Point point = pictureBox1.PointToClient(Cursor.Position);

            int x = point.X;
            int y = point.Y;
            Console.WriteLine("X: " + point.X +"         Y:" + point.Y +"\n");
            if(x >= 128 && x <= 244 && (y >= 216 && y <= 255))
            { 
                MessageBox.Show("Tigray");
            }
            // X: 113 - 208 | Y: 12 - 53, > 184 23 - 85
            // X: 130 - 250 | Y: 130 - 170
            
        }
        private void pictureBox1_Hover(object sender, EventArgs e)
        {
            Point point = pictureBox1.PointToClient(Cursor.Position);

            int x = point.X;
            int y = point.Y;
            if (x >= 128 && x <= 244 && (y >= 216 && y <= 255))
            {
                Console.WriteLine("Tigray");
            }else
            {
                Console.WriteLine("X: " + x + "         Y:" + y + "\n");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
