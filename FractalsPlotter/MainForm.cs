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
    public partial class MainForm : Form
    {
        #region Fields
        Color backgroundColor = Color.White;
        Color lineColor = Color.Blue;
        int size = 100;
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            foreach (var item in Constants.Fractals.fractalsNames)
                this.cbType.Items.Add(item);
            cbType.SelectedIndex = 0;
        }
        #endregion

        #region Methods
        void Draw()
        {
            try
            {
                if (this.tbDepth.Text != String.Empty)
                {
                    int depth = Convert.ToInt32(this.tbDepth.Text);
                    if (cbType.SelectedItem.ToString() == Constants.Fractals.pyphagorTree)
                    {
                        if (txbAngleRight.Text != String.Empty && txbAngleLeft.Text != String.Empty)
                        {
                            int leftAngle = Convert.ToInt32(this.txbAngleLeft.Text);
                            int rightAngle = Convert.ToInt32(this.txbAngleRight.Text);
                            FractalTree tree = new FractalTree(this.pbFractal.Width / 2, 0, this.size, depth, leftAngle, rightAngle, this.lineColor);
                            tree.Fill(this.pbFractal, this.backgroundColor);
                            tree.Draw(this.pbFractal);
                        }
                    }
                    if (cbType.SelectedItem.ToString() == Constants.Fractals.windTree)
                    {
                        if (txbAngleRight.Text != String.Empty && txbAngleLeft.Text != String.Empty)
                        {
                            int leftAngle = Convert.ToInt32(this.txbAngleLeft.Text);
                            int rightAngle = Convert.ToInt32(this.txbAngleRight.Text);
                            FractalTree tree = new FractalTree(this.pbFractal.Width / 2, 0, this.size, depth, leftAngle, rightAngle, this.lineColor);
                            tree.Fill(this.pbFractal, this.backgroundColor);
                            tree.Draw(this.pbFractal);
                        }
                    }
                    if (cbType.SelectedItem.ToString() == Constants.Fractals.triangle)
                    {
                        FractalTriangle fractalTriangle = new FractalTriangle(this.pbFractal.Width / 2, 0, this.size, depth, this.lineColor);
                        fractalTriangle.Fill(this.pbFractal, this.backgroundColor);
                        fractalTriangle.Draw(this.pbFractal);
                    }

                }
                lblAngleLeft.Visible = IsTreeChecked();
                lblAngleRight.Visible = IsTreeChecked();
                txbAngleLeft.Visible = IsTreeChecked();
                txbAngleRight.Visible = IsTreeChecked();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Events
        private bool IsTreeChecked()
        {
            return (String)this.cbType.SelectedItem == Constants.Fractals.pyphagorTree || (String)this.cbType.SelectedItem == Constants.Fractals.windTree;
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Draw();
            if (cbType.SelectedItem.ToString() == Constants.Fractals.windTree)
            {
                this.txbAngleLeft.Text = "30";
                this.txbAngleRight.Text = "60";
            }
            if (cbType.SelectedItem.ToString() == Constants.Fractals.pyphagorTree)
            {
                this.txbAngleLeft.Text = "45";
                this.txbAngleRight.Text = "45";
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Draw();
        }
        private void tbDepth_TextChanged(object sender, EventArgs e)
        {
            this.Draw();
        }
        private void txbAngleLeft_TextChanged(object sender, EventArgs e)
        {
            this.Draw();
        }
        private void txbAngleRight_TextChanged(object sender, EventArgs e)
        {
            this.Draw();
        }
        #endregion

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (cdSelectColor.ShowDialog() == DialogResult.OK)
            {
                this.lineColor = cdSelectColor.Color;
                this.Draw();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.size = this.tbSize.Value;
            this.Draw();
        }
        int x;
        int y;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            x = (sender as HScrollBar).Value;
            this.pbFractal.Refresh();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            y = (sender as VScrollBar).Value;
            this.pbFractal.Refresh();
        }

        private void pbFractal_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pBox = sender as PictureBox;
            if (pBox.Image != null)
            {
                e.Graphics.DrawImage(pBox.Image, e.ClipRectangle, x, y, e.ClipRectangle.Width,
                  e.ClipRectangle.Height, GraphicsUnit.Pixel);
                this.Draw();
            }


        }
    }
}
