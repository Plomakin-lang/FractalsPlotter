
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
            this.pbTree = new System.Windows.Forms.PictureBox();
            this.tabsFractals = new System.Windows.Forms.TabControl();
            this.pageTree = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPlot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).BeginInit();
            this.tabsFractals.SuspendLayout();
            this.pageTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTree
            // 
            this.pbTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTree.Location = new System.Drawing.Point(3, 3);
            this.pbTree.Name = "pbTree";
            this.pbTree.Size = new System.Drawing.Size(1422, 772);
            this.pbTree.TabIndex = 0;
            this.pbTree.TabStop = false;
            this.pbTree.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTree_Paint);
            // 
            // tabsFractals
            // 
            this.tabsFractals.Controls.Add(this.pageTree);
            this.tabsFractals.Controls.Add(this.tabPage2);
            this.tabsFractals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsFractals.Location = new System.Drawing.Point(0, 0);
            this.tabsFractals.Name = "tabsFractals";
            this.tabsFractals.SelectedIndex = 0;
            this.tabsFractals.Size = new System.Drawing.Size(1444, 825);
            this.tabsFractals.TabIndex = 1;
            // 
            // pageTree
            // 
            this.pageTree.Controls.Add(this.btnPlot);
            this.pageTree.Controls.Add(this.pbTree);
            this.pageTree.Location = new System.Drawing.Point(8, 39);
            this.pageTree.Name = "pageTree";
            this.pageTree.Padding = new System.Windows.Forms.Padding(3);
            this.pageTree.Size = new System.Drawing.Size(1428, 778);
            this.pageTree.TabIndex = 0;
            this.pageTree.Text = "Дерево";
            this.pageTree.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1428, 778);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPlot
            // 
            this.btnPlot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlot.Location = new System.Drawing.Point(3, 735);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(1422, 40);
            this.btnPlot.TabIndex = 1;
            this.btnPlot.Text = "button1";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 825);
            this.Controls.Add(this.tabsFractals);
            this.Name = "mainForm";
            this.Text = "Фракталы";
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).EndInit();
            this.tabsFractals.ResumeLayout(false);
            this.pageTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTree;
        private System.Windows.Forms.TabControl tabsFractals;
        private System.Windows.Forms.TabPage pageTree;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPlot;
    }
}

