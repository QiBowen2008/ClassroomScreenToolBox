namespace ClassroomScreenToolBox
{
    partial class frmTimeShutdown
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ucExt1 = new Sunny.UI.UIButton();
            this.ucExt2 = new Sunny.UI.UIButton();
            this.checkBox1 = new Sunny.UI.UICheckBox();
            this.nud_hour = new Sunny.UI.UIIntegerUpDown();
            this.nud_min = new Sunny.UI.UIIntegerUpDown();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(384, 59);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 20);
            this.Label5.TabIndex = 17;
            this.Label5.Text = "分";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(246, 59);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 20);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "时";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 58);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(99, 20);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "指定时间:";
            // 
            // ucExt1
            // 
            this.ucExt1.BackColor = System.Drawing.Color.White;
            this.ucExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt1.FillColor = System.Drawing.Color.LimeGreen;
            this.ucExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt1.Location = new System.Drawing.Point(35, 110);
            this.ucExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt1.Name = "ucExt1";
            this.ucExt1.RectColor = System.Drawing.Color.LimeGreen;
            this.ucExt1.Size = new System.Drawing.Size(101, 33);
            this.ucExt1.TabIndex = 20;
            this.ucExt1.TabStop = false;
            this.ucExt1.Text = "确定";
            this.ucExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt1.Click += new System.EventHandler(this.TimeClose_Click);
            // 
            // ucExt2
            // 
            this.ucExt2.BackColor = System.Drawing.Color.White;
            this.ucExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt2.Location = new System.Drawing.Point(300, 110);
            this.ucExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt2.Name = "ucExt2";
            this.ucExt2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucExt2.Size = new System.Drawing.Size(101, 33);
            this.ucExt2.TabIndex = 21;
            this.ucExt2.TabStop = false;
            this.ucExt2.Text = "取消";
            this.ucExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt2.Click += new System.EventHandler(this.CancelClose_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = global::ClassroomScreenToolBox.Properties.Settings.Default.AutoShutdown;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ClassroomScreenToolBox.Properties.Settings.Default, "AutoShutdown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.checkBox1.Location = new System.Drawing.Point(35, 146);
            this.checkBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox1.Size = new System.Drawing.Size(136, 30);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "每天生效";
            // 
            // nud_hour
            // 
            this.nud_hour.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_hour.Location = new System.Drawing.Point(138, 51);
            this.nud_hour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_hour.Maximum = 23;
            this.nud_hour.Minimum = 0;
            this.nud_hour.MinimumSize = new System.Drawing.Size(100, 0);
            this.nud_hour.Name = "nud_hour";
            this.nud_hour.ShowText = false;
            this.nud_hour.Size = new System.Drawing.Size(100, 36);
            this.nud_hour.TabIndex = 22;
            this.nud_hour.Text = "uiIntegerUpDown1";
            this.nud_hour.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.nud_hour.Value = 18;
            // 
            // nud_min
            // 
            this.nud_min.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nud_min.Location = new System.Drawing.Point(276, 51);
            this.nud_min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_min.Maximum = 59;
            this.nud_min.Minimum = 0;
            this.nud_min.MinimumSize = new System.Drawing.Size(100, 0);
            this.nud_min.Name = "nud_min";
            this.nud_min.ShowText = false;
            this.nud_min.Size = new System.Drawing.Size(100, 37);
            this.nud_min.TabIndex = 23;
            this.nud_min.Text = "uiIntegerUpDown1";
            this.nud_min.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTimeShutdown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(432, 202);
            this.Controls.Add(this.nud_min);
            this.Controls.Add(this.nud_hour);
            this.Controls.Add(this.ucExt2);
            this.Controls.Add(this.ucExt1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTimeShutdown";
            this.Text = "定时关机";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 321, 166);
            this.Load += new System.EventHandler(this.TimeShutdown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label  Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private Sunny.UI.UICheckBox checkBox1;
        private Sunny.UI.UIButton ucExt1;
        private Sunny.UI.UIButton ucExt2;
        private Sunny.UI.UIIntegerUpDown nud_hour;
        private Sunny.UI.UIIntegerUpDown nud_min;
    }
}