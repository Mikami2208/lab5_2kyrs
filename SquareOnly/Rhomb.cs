using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class Rhomb : Figure
    {
        private int _horDiagLen, _vertDiagLen;

        public Rhomb(int x, int y, int horDiagLen, int vertDiagLen) : base(x, y)
        {
            _horDiagLen = horDiagLen;
            _vertDiagLen = vertDiagLen;
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {

                new Point(X, Y - _vertDiagLen / 2), 
                new Point(X + _horDiagLen / 2, Y), 
                new Point(X, Y + _vertDiagLen / 2), 
                new Point(X - _horDiagLen / 2, Y)  
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
