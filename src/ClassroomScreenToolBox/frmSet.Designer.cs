namespace ClassroomScreenToolBox
{
    partial class frmSet
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton4 = new Sunny.UI.UIRadioButton();
            this.ucRadioButton3 = new Sunny.UI.UIRadioButton();
            this.ucCheckBox2 = new Sunny.UI.UICheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ucCheckBox8 = new Sunny.UI.UICheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ucExt2 = new Sunny.UI.UIButton();
            this.ucExt1 = new Sunny.UI.UIButton();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.ucCheckBox2);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(608, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ucRadioButton4);
            this.groupBox3.Controls.Add(this.ucRadioButton3);
            this.groupBox3.Location = new System.Drawing.Point(28, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 106);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "自启设置";
            // 
            // ucRadioButton4
            // 
            this.ucRadioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucRadioButton4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucRadioButton4.Location = new System.Drawing.Point(34, 61);
            this.ucRadioButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucRadioButton4.Name = "ucRadioButton4";
            this.ucRadioButton4.Size = new System.Drawing.Size(233, 30);
            this.ucRadioButton4.TabIndex = 1;
            this.ucRadioButton4.Text = "后台自启";
            // 
            // ucRadioButton3
            // 
            this.ucRadioButton3.Checked = true;
            this.ucRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucRadioButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucRadioButton3.Location = new System.Drawing.Point(34, 25);
            this.ucRadioButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucRadioButton3.Name = "ucRadioButton3";
            this.ucRadioButton3.Size = new System.Drawing.Size(233, 30);
            this.ucRadioButton3.TabIndex = 0;
            this.ucRadioButton3.Text = "不自启";
            // 
            // ucCheckBox2
            // 
            this.ucCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.ucCheckBox2.Checked = global::ClassroomScreenToolBox.Properties.Settings.Default.AutoIcon;
            this.ucCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucCheckBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ClassroomScreenToolBox.Properties.Settings.Default, "AutoIcon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ucCheckBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucCheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ucCheckBox2.Location = new System.Drawing.Point(62, 144);
            this.ucCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucCheckBox2.Name = "ucCheckBox2";
            this.ucCheckBox2.Padding = new System.Windows.Forms.Padding(1);
            this.ucCheckBox2.Size = new System.Drawing.Size(304, 30);
            this.ucCheckBox2.TabIndex = 7;
            this.ucCheckBox2.Text = "关闭时最小化到任务栏";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(0, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(608, 223);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "激励页面";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox6);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.ucCheckBox8);
            this.groupBox5.Location = new System.Drawing.Point(6, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(422, 144);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "倒数日";
            // 
            // comboBox6
            // 
            this.comboBox6.AutoCompleteCustomSource.AddRange(new string[] {
            "11",
            "222",
            "33"});
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClassroomScreenToolBox.Properties.Settings.Default, "DayMatterEvent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.ItemHeight = 20;
            this.comboBox6.Items.AddRange(new object[] {
            "yxgydgy",
            "dbwehdb",
            "hbwevcw",
            "edjwekcfb"});
            this.comboBox6.Location = new System.Drawing.Point(107, 93);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(295, 28);
            this.comboBox6.TabIndex = 7;
            this.comboBox6.Text = global::ClassroomScreenToolBox.Properties.Settings.Default.DayMatterEvent;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ClassroomScreenToolBox.Properties.Settings.Default, "DayMatterTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 30);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = global::ClassroomScreenToolBox.Properties.Settings.Default.DayMatterTime;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(14, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "事件名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(14, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "事件时间：";
            // 
            // ucCheckBox8
            // 
            this.ucCheckBox8.BackColor = System.Drawing.Color.Transparent;
            this.ucCheckBox8.Checked = global::ClassroomScreenToolBox.Properties.Settings.Default.DayMatterOpen;
            this.ucCheckBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucCheckBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ClassroomScreenToolBox.Properties.Settings.Default, "DayMatterOpen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ucCheckBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucCheckBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ucCheckBox8.Location = new System.Drawing.Point(18, 25);
            this.ucCheckBox8.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucCheckBox8.Name = "ucCheckBox8";
            this.ucCheckBox8.Padding = new System.Windows.Forms.Padding(1);
            this.ucCheckBox8.Size = new System.Drawing.Size(363, 30);
            this.ucCheckBox8.TabIndex = 0;
            this.ucCheckBox8.Text = "开启     不开启时将显示今天日期";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 130);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "名言";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(107, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 60);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "失败乃成功之母";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "固定名言：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "波形声音|*.Wav";
            // 
            // ucExt2
            // 
            this.ucExt2.BackColor = System.Drawing.Color.White;
            this.ucExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt2.FillColor = System.Drawing.Color.LimeGreen;
            this.ucExt2.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt2.Location = new System.Drawing.Point(166, 313);
            this.ucExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt2.Name = "ucExt2";
            this.ucExt2.RectColor = System.Drawing.Color.LimeGreen;
            this.ucExt2.Size = new System.Drawing.Size(112, 40);
            this.ucExt2.TabIndex = 11;
            this.ucExt2.TabStop = false;
            this.ucExt2.Text = "确定";
            this.ucExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt2.Click += new System.EventHandler(this.ucExt2_Click);
            // 
            // ucExt1
            // 
            this.ucExt1.BackColor = System.Drawing.Color.White;
            this.ucExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucExt1.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt1.Location = new System.Drawing.Point(317, 313);
            this.ucExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt1.Name = "ucExt1";
            this.ucExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucExt1.Size = new System.Drawing.Size(112, 40);
            this.ucExt1.TabIndex = 10;
            this.ucExt1.TabStop = false;
            this.ucExt1.Text = "取消";
            this.ucExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt1.Click += new System.EventHandler(this.ucExt1_Click);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage4);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(3, 38);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(608, 263);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.Black;
            this.uiTabControl1.TabIndex = 12;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.Black;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(0, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(344, 223);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(0, 40);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(344, 223);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = global::ClassroomScreenToolBox.Properties.Settings.Default.TimerColorRGB;
            // 
            // frmSet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(614, 364);
            this.Controls.Add(this.uiTabControl1);
            this.Controls.Add(this.ucExt2);
            this.Controls.Add(this.ucExt1);
            this.MaximizeBox = false;
            this.Name = "frmSet";
            this.Text = "设置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 487, 380);
            this.Load += new System.EventHandler(this.Set_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UICheckBox ucCheckBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIButton ucExt2;
        private Sunny.UI.UIButton ucExt1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sunny.UI.UIRadioButton ucRadioButton3;
        private Sunny.UI.UIRadioButton ucRadioButton4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UICheckBox ucCheckBox8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}