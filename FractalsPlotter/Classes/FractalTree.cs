using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsPlotter.Classes
{
    class FractalTree : Fractal
    {
        int angleLeft;
        int angleRight;
        public FractalTree(int x, int y, int size, int depth, int angleLeft, int angleRight) : base(x, y, size, depth)
        {
            this.angleLeft = angleLeft;
            this.angleRight = angleRight;
        }
        public void Draw(PictureBox pictureBox, int depth, int startX, int startY, int length, double angle, double deltaAngleLeft, double deltaAngleRight)
        {
            if (length > 0 && depth > 0)
            {
                Graphics graphics = pictureBox.CreateGraphics();
                int endX = (int)(Math.Sin(GetRadians(angle)) * length);
                int endY = (int)(Math.Cos(GetRadians(angle)) * length);
                graphics.DrawLine(new Pen(Color.Blue), new Point(startX, startY), new Point(startX - endX, startY + endY));
                int newLength = (int)((double)length / 1.5);
                this.Draw(pictureBox, depth - 1, startX - endX, startY + endY, newLength, angle + deltaAngleLeft, deltaAngleLeft, deltaAngleRight);
                this.Draw(pictureBox, depth - 1, startX - endX, startY + endY, newLength, angle - deltaAngleRight, deltaAngleLeft, deltaAngleRight);
            }
        }
        public void Draw(PictureBox pictureBox)
        {
            this.Draw(pictureBox, this.Depth, this.X, this.Y, this.Size, 0, this.angleLeft, this.angleRight);
        }
    }
}
