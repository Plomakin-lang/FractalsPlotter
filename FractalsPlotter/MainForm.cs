using FractalsPlotter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            foreach (var item in Constants.Fractals.fractalsNames)
                this.cbType.Items.Add(item);
            cbType.SelectedIndex = 0;           
        }

        double GetRadians(double angle)
        {
            return Math.PI * angle / 180;
        }
        void DrawTree(int depth, int startX, int startY, int length, double angle)
        {
            if (length > 0 && depth > 0)
            {
                Graphics graphics = pbTree.CreateGraphics();
                angle = this.GetRadians(angle);
                int endX = (int)(Math.Sin(angle) * length);
                int endY = (int)(Math.Cos(angle) * length);
                graphics.DrawLine(new Pen(Color.Blue), new Point(startX, startY), new Point(startX - endX, startY + endY));
                int newLength = (int)((double)length * 0.8);
                this.DrawTree(depth - 1, startX - endX, startY + endY, newLength, angle + 45);
                this.DrawTree(depth - 1, startX - endX, startY + endY, newLength, angle - 45);
            }

        }
        void Clear()
        {
            Graphics graphics = pbTree.CreateGraphics();
            graphics.Clear(Color.White);
        }

        private void pbTree_Paint(object sender, PaintEventArgs e)
        {
            //this.DrawTree(e, this.pbTree.Width / 2, this.pbTree.Height/2, 100,0);
        }
        void Draw()
        {
            try
            {
                if (this.tbDepth.Text != String.Empty)
                {
                    this.Clear();
                    this.DrawTree(Convert.ToInt32(this.tbDepth.Text), this.pbTree.Width / 2, 0, 100, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            this.Draw();
        }

        private void tbDepth_TextChanged(object sender, EventArgs e)
        {
            this.Draw();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Draw();
        }
    }
}
