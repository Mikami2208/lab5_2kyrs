using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Circle : Figure
    {
        protected int _radius;
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this._radius = radius;
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, X, Y, _radius,_radius);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), X, Y, _radius, _radius);
        }

      
    }
}
