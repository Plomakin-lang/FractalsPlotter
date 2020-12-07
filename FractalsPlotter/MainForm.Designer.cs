
namespace FractalsPlotter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbFractal = new System.Windows.Forms.PictureBox();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.lblDepth = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.lblAngleRight = new System.Windows.Forms.Label();
            this.txbAngleRight = new System.Windows.Forms.TextBox();
            this.lblAngleLeft = new System.Windows.Forms.Label();
            this.txbAngleLeft = new System.Windows.Forms.TextBox();
            this.cdSelectColor = new System.Windows.Forms.ColorDialog();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TrackBar();
            this.lblScale = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbFractal)).BeginInit();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFractal
            // 
            this.pbFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFractal.Location = new System.Drawing.Point(0, 0);
            this.pbFractal.Margin = new System.Windows.Forms.Padding(2);
            this.pbFractal.Name = "pbFractal";
            this.pbFractal.Size = new System.Drawing.Size(729, 611);
            this.pbFractal.TabIndex = 5;
            this.pbFractal.TabStop = false;
            this.pbFractal.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFractal_Paint);
            // 
            // tbDepth
            // 
            this.tbDepth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDepth.Location = new System.Drawing.Point(9, 92);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(263, 20);
            this.tbDepth.TabIndex = 0;
            this.tbDepth.Text = "10";
            this.tbDepth.TextChanged += new System.EventHandler(this.tbDepth_TextChanged);
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(6, 70);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(98, 13);
            this.lblDepth.TabIndex = 1;
            this.lblDepth.Text = "Глубина рекурсии";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(9, 46);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(263, 21);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Фрактал";
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.lblScale);
            this.gbSettings.Controls.Add(this.tbSize);
            this.gbSettings.Controls.Add(this.btnChangeColor);
            this.gbSettings.Controls.Add(this.lblAngleRight);
            this.gbSettings.Controls.Add(this.txbAngleRight);
            this.gbSettings.Controls.Add(this.lblAngleLeft);
            this.gbSettings.Controls.Add(this.txbAngleLeft);
            this.gbSettings.Controls.Add(this.lblType);
            this.gbSettings.Controls.Add(this.cbType);
            this.gbSettings.Controls.Add(this.lblDepth);
            this.gbSettings.Controls.Add(this.tbDepth);
            this.gbSettings.Location = new System.Drawing.Point(734, 0);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(283, 611);
            this.gbSettings.TabIndex = 4;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Настройки";
            // 
            // lblAngleRight
            // 
            this.lblAngleRight.AutoSize = true;
            this.lblAngleRight.Location = new System.Drawing.Point(6, 154);
            this.lblAngleRight.Name = "lblAngleRight";
            this.lblAngleRight.Size = new System.Drawing.Size(77, 13);
            this.lblAngleRight.TabIndex = 8;
            this.lblAngleRight.Text = "Угол наклона";
            // 
            // txbAngleRight
            // 
            this.txbAngleRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAngleRight.Location = new System.Drawing.Point(9, 170);
            this.txbAngleRight.Name = "txbAngleRight";
            this.txbAngleRight.Size = new System.Drawing.Size(262, 20);
            this.txbAngleRight.TabIndex = 7;
            this.txbAngleRight.Text = "45";
            this.txbAngleRight.TextChanged += new System.EventHandler(this.txbAngleRight_TextChanged);
            // 
            // lblAngleLeft
            // 
            this.lblAngleLeft.AutoSize = true;
            this.lblAngleLeft.Location = new System.Drawing.Point(6, 115);
            this.lblAngleLeft.Name = "lblAngleLeft";
            this.lblAngleLeft.Size = new System.Drawing.Size(77, 13);
            this.lblAngleLeft.TabIndex = 6;
            this.lblAngleLeft.Text = "Угол наклона";
            // 
            // txbAngleLeft
            // 
            this.txbAngleLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAngleLeft.Location = new System.Drawing.Point(9, 131);
            this.txbAngleLeft.Name = "txbAngleLeft";
            this.txbAngleLeft.Size = new System.Drawing.Size(262, 20);
            this.txbAngleLeft.TabIndex = 5;
            this.txbAngleLeft.Text = "45";
            this.txbAngleLeft.TextChanged += new System.EventHandler(this.txbAngleLeft_TextChanged);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(9, 559);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(262, 40);
            this.btnChangeColor.TabIndex = 9;
            this.btnChangeColor.Text = "Выбрать цвет";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(8, 508);
            this.tbSize.Maximum = 1000;
            this.tbSize.Minimum = 100;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(263, 45);
            this.tbSize.TabIndex = 10;
            this.tbSize.Value = 100;
            this.tbSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(6, 492);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(53, 13);
            this.lblScale.TabIndex = 11;
            this.lblScale.Text = "Масштаб";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 591);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(729, 20);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(711, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 592);
            this.vScrollBar1.TabIndex = 7;
            this.vScrollBar1.Visible = false;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 611);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.pbFractal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Фракталы";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFractal)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFractal;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label lblAngleLeft;
        private System.Windows.Forms.TextBox txbAngleLeft;
        private System.Windows.Forms.Label lblAngleRight;
        private System.Windows.Forms.TextBox txbAngleRight;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.ColorDialog cdSelectColor;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.TrackBar tbSize;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

