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
        private Color backgroundColor = Color.White;
        public MainForm()
        {
            InitializeComponent();
            foreach (var item in Constants.Fractals.fractalsNames)
                this.cbType.Items.Add(item);
            cbType.SelectedIndex = 0;
        }
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
                            FractalTree tree = new FractalTree(0, this.pbFractal.Width / 2, 100, depth, leftAngle, rightAngle);
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
                            FractalTree tree = new FractalTree(0, this.pbFractal.Width / 2, 100, depth, leftAngle, rightAngle);
                            tree.Fill(this.pbFractal, this.backgroundColor);
                            tree.Draw(this.pbFractal, depth, this.pbFractal.Width / 2, 0, 100, 0, 60, 30);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool IsTreeChecked()
        {
            return (String)this.cbType.SelectedItem == Constants.Fractals.pyphagorTree || (String)this.cbType.SelectedItem == Constants.Fractals.windTree;
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Draw();
            lblAngleLeft.Visible = IsTreeChecked();
            lblAngleRight.Visible = IsTreeChecked();
            txbAngleLeft.Visible = IsTreeChecked();
            txbAngleRight.Visible = IsTreeChecked();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

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
    }
}
