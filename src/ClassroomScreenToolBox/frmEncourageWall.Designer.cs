namespace ClassroomScreenToolBox
{
    partial class frmEncourageWall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ucExt1 = new Sunny.UI.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "今天是";
            // 
            // ucExt1
            // 
            this.ucExt1.BackColor = System.Drawing.Color.White;
            this.ucExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucExt1.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt1.Location = new System.Drawing.Point(898, 550);
            this.ucExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt1.Name = "ucExt1";
            this.ucExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucExt1.Size = new System.Drawing.Size(184, 60);
            this.ucExt1.TabIndex = 1;
            this.ucExt1.TabStop = false;
            this.ucExt1.Text = "开启美好一天";
            this.ucExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt1.Click += new System.EventHandler(this.ucExt1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 32F);
            this.label2.Location = new System.Drawing.Point(18, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(950, 277);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 32F);
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 70);
            this.label3.TabIndex = 3;
            this.label3.Text = "每日一句";
            // 
            // frmEncourageWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucExt1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEncourageWall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hurryup";
            this.Load += new System.EventHandler(this.Hurryup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton ucExt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}