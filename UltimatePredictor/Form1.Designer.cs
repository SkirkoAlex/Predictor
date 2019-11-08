namespace UltimatePredictor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bPredict = new System.Windows.Forms.Button();
            this.bMessageInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bPredict);
            this.splitContainer1.Size = new System.Drawing.Size(175, 87);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 29);
            this.progressBar1.TabIndex = 0;
            // 
            // bPredict
            // 
            this.bPredict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bPredict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPredict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPredict.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPredict.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bPredict.Location = new System.Drawing.Point(0, 0);
            this.bPredict.Margin = new System.Windows.Forms.Padding(5);
            this.bPredict.Name = "bPredict";
            this.bPredict.Size = new System.Drawing.Size(171, 46);
            this.bPredict.TabIndex = 0;
            this.bPredict.Text = "PREDICT";
            this.bPredict.UseVisualStyleBackColor = false;
            this.bPredict.Click += new System.EventHandler(this.bPredict_Click);
            // 
            // bMessageInfo
            // 
            this.bMessageInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.bMessageInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.bMessageInfo.Image = ((System.Drawing.Image)(resources.GetObject("bMessageInfo.Image")));
            this.bMessageInfo.Location = new System.Drawing.Point(179, 0);
            this.bMessageInfo.Name = "bMessageInfo";
            this.bMessageInfo.Size = new System.Drawing.Size(33, 87);
            this.bMessageInfo.TabIndex = 1;
            this.bMessageInfo.UseVisualStyleBackColor = true;
            this.bMessageInfo.Click += new System.EventHandler(this.bMessageInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 87);
            this.Controls.Add(this.bMessageInfo);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bPredict;
        private System.Windows.Forms.Button bMessageInfo;
    }
}

