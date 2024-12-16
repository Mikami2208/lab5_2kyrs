using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    abstract class Figure
    {
        protected int X, Y;

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void DrawBlack();

        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i < 150; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                X++;
            }
        }
    }
}
