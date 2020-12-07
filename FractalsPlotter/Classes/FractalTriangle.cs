using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalsPlotter.Classes
{
    /// <summary>
    /// Треугольник Серпинского
    /// </summary>
    class FractalTriangle : Fractal
    {
        /// <summary>
        /// Создает фрактал треугольника с заданными параметарми
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="size"></param>
        /// <param name="depth"></param>
        public FractalTriangle(int x, int y, int size, int depth,Color color) : base(x, y, size, depth,color)
        {

        }
        Point[] DrawTriangle(PictureBox pictureBox, int x, int y, int length, int depth)
        {
            if (length > 0 && depth > 0)
            {
                Graphics graphics = pictureBox.CreateGraphics();
                Point[] points = new Point[3];
                points[0] = new Point(x, y);
                points[1] = new Point(x - (int)(Math.Sin(GetRadians(30)) * length), y + (int)(Math.Cos(GetRadians(30)) * length));
                points[2] = new Point(x - (int)(Math.Sin(GetRadians(-30)) * length), y + (int)(Math.Cos(GetRadians(-30)) * length));
                graphics.DrawLine(new Pen(this.Color), points[0], points[1]);
                graphics.DrawLine(new Pen(this.Color), points[0], points[2]);
                graphics.DrawLine(new Pen(this.Color), points[1], points[2]);
                Point[] topTiranglePoints = DrawTriangle(pictureBox, points[0].X, points[0].Y, length / 2, depth - 1);
                if (topTiranglePoints.Length > 0)
                {
                    DrawTriangle(pictureBox, topTiranglePoints[1].X, topTiranglePoints[1].Y, length / 2, depth - 1);
                    DrawTriangle(pictureBox, topTiranglePoints[2].X, topTiranglePoints[2].Y, length / 2, depth - 1);
                }
                return points;
            }
            return new Point[0];

        }
        public void Draw(PictureBox pictureBox)
        {
            DrawTriangle(pictureBox, this.X, this.Y, this.Size, this.Depth);
        }
    }
}
