
namespace FractalsPlotter
{
    partial class mainForm
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
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.pbTree = new System.Windows.Forms.PictureBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.cbType);
            this.gbSettings.Controls.Add(this.btnPlot);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.tbDepth);
            this.gbSettings.Location = new System.Drawing.Point(766, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(286, 711);
            this.gbSettings.TabIndex = 4;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Настройки";
            // 
            // btnPlot
            // 
            this.btnPlot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlot.Location = new System.Drawing.Point(6, 656);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(274, 49);
            this.btnPlot.TabIndex = 2;
            this.btnPlot.Text = "Построить график";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.TextChanged += new System.EventHandler(this.btnPlot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Глубина рекурсии";
            // 
            // tbDepth
            // 
            this.tbDepth.Location = new System.Drawing.Point(6, 86);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(263, 20);
            this.tbDepth.TabIndex = 0;
            this.tbDepth.TextChanged += new System.EventHandler(this.tbDepth_TextChanged);
            // 
            // pbTree
            // 
            this.pbTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTree.Location = new System.Drawing.Point(11, 11);
            this.pbTree.Margin = new System.Windows.Forms.Padding(2);
            this.pbTree.Name = "pbTree";
            this.pbTree.Size = new System.Drawing.Size(750, 713);
            this.pbTree.TabIndex = 5;
            this.pbTree.TabStop = false;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(9, 46);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(260, 21);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фрактал";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 735);
            this.Controls.Add(this.pbTree);
            this.Controls.Add(this.gbSettings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "Фракталы";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.PictureBox pbTree;
    }
}

