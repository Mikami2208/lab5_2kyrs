using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square sq = new Square(120, 150, 100);
            sq.MoveRight();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Circle circle = new Circle(150, 120, 150);
            circle.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rhomb rhomp = new Rhomb(150, 120, 50, 100);
            rhomp.MoveRight();
        }
    }
}
