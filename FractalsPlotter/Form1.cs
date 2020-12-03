using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsPlotter
{
    public partial class mainForm : Form
    {
        Bitmap treeImage;
        public mainForm()
        {
            InitializeComponent();
        }
        void InitImage()
        {
            this.treeImage = new Bitmap(this.pbTree.Width, this.pbTree.Height);

        }

        double GetRadians(double angle)
        {
            return Math.PI * angle / 180;
        }
        void DrawTree(Graphics graphics, int startX, int startY, int length, double angle)
        {
            if (length > 0)
            {
                
                graphics.Clear(Color.White);
                angle = this.GetRadians(angle);
                int endX = (int)(Math.Sin(angle) * length);
                int endY = (int)(Math.Cos(angle) * length);
                graphics.DrawLine(new Pen(Color.Blue), new Point(startX, startY), new Point(startX-endX,startY+endY));              
                this.DrawTree(graphics,startX - endX, startY + endY, length - 50, angle + 45);
            }
           
        }

        private void pbTree_Paint(object sender, PaintEventArgs e)
        {
            //this.DrawTree(e, this.pbTree.Width / 2, this.pbTree.Height/2, 100,0);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            Graphics graphics = pbTree.CreateGraphics();
            this.DrawTree(graphics, this.pbTree.Width / 2, this.pbTree.Height / 2, 100, 0);
            pbTree.Refresh();
        }
    }
}
