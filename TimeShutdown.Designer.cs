namespace ClassroomScreenToolBox
{
    partial class TimeShutdown
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
            this.nud_min = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.nud_hour = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.checkBox1 = new HZH_Controls.Controls.UCCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).BeginInit();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(289, 59);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(32, 27);
            this.Label5.TabIndex = 17;
            this.Label5.Text = "分";
            // 
            // nud_min
            // 
            this.nud_min.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ClassroomScreenToolBox.Properties.Settings.Default, "AutoShutdownTimeMinute", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nud_min.Location = new System.Drawing.Point(216, 57);
            this.nud_min.Margin = new System.Windows.Forms.Padding(4);
            this.nud_min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_min.Name = "nud_min";
            this.nud_min.Size = new System.Drawing.Size(69, 34);
            this.nud_min.TabIndex = 16;
            this.nud_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_min.Value = global::ClassroomScreenToolBox.Properties.Settings.Default.AutoShutdownTimeMinute;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(191, 58);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 27);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "时";
            // 
            // nud_hour
            // 
            this.nud_hour.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ClassroomScreenToolBox.Properties.Settings.Default, "AutoShutdownTimeHour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nud_hour.Location = new System.Drawing.Point(117, 57);
            this.nud_hour.Margin = new System.Windows.Forms.Padding(4);
            this.nud_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_hour.Name = "nud_hour";
            this.nud_hour.Size = new System.Drawing.Size(69, 34);
            this.nud_hour.TabIndex = 14;
            this.nud_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_hour.Value = global::ClassroomScreenToolBox.Properties.Settings.Default.AutoShutdownTimeHour;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 58);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(97, 27);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "指定时间:";
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "确定";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(52, 110);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(101, 33);
            this.ucBtnExt1.TabIndex = 20;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.btnTimeClose_Click);
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = "取消";
            this.ucBtnExt2.ConerRadius = 5;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(184, 110);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(101, 33);
            this.ucBtnExt2.TabIndex = 21;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            this.ucBtnExt2.BtnClick += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = global::ClassroomScreenToolBox.Properties.Settings.Default.AutoShutdown;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ClassroomScreenToolBox.Properties.Settings.Default, "AutoShutdown", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(52, 146);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(1);
            this.checkBox1.Size = new System.Drawing.Size(233, 30);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.TextValue = "每天生效";
            // 
            // TimeShutdown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 202);
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.nud_min);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.nud_hour);
            this.Controls.Add(this.Label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TimeShutdown";
            this.Text = "定时关机";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 321, 166);
            this.Load += new System.EventHandler(this.TimeShutdown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label  Label5;
        private System.Windows.Forms.NumericUpDown nud_min;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.NumericUpDown nud_hour;
        private System.Windows.Forms.Label Label3;
        private HZH_Controls.Controls.UCCheckBox checkBox1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
    }
}