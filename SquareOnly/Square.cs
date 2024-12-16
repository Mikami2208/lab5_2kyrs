using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Square : Figure
    {
     
        protected int _size;
        public Square(int centerX, int centerY, int size) : base(centerX,centerY)
        {
            this._size = size;
        }

        
        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(X - _size,  Y - _size),
                new Point(X - _size,  Y + _size),
                new Point(X + _size,  Y + _size),
                new Point(X + _size,  Y - _size),
            };
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, GetCurrPoints());
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetCurrPoints());
        }

        
    }
}
