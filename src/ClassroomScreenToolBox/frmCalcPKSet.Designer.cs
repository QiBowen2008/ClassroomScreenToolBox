/*
 * 由SharpDevelop创建。
 * 用户： a
 * 日期: 2025/1/28
 * 时间: 11:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace ClassroomScreenToolBox
{
	partial class frmCalcPKSet
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Sunny.UI.UIButton button1;
		private Sunny.UI.UIGroupBox gbox;
		private Sunny.UI.UIIntegerUpDown  numericUpDown2;
		private Sunny.UI.UIIntegerUpDown numericUpDown1;
		private Sunny.UI.UIRadioButton radioButton2;
		private Sunny.UI.UIRadioButton radioButton1;
		private Sunny.UI.UILabel label6;
		private Sunny.UI.UIIntegerUpDown numericUpDown3;
		private Sunny.UI.UIGroupBox groupBox1;
		private Sunny.UI.UIRadioButton radioButton5;
		private Sunny.UI.UIRadioButton radioButton4;
		private Sunny.UI.UIRadioButton radioButton3;
		private Sunny.UI.UIGroupBox gb2;
		private Sunny.UI.UIRadioButton radioButton8;
		private Sunny.UI.UIRadioButton radioButton7;
		private Sunny.UI.UIRadioButton radioButton6;
		private Sunny.UI.UIRadioButton radioButton9;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new Sunny.UI.UIButton();
            this.gbox = new Sunny.UI.UIGroupBox();
            this.radioButton9 = new Sunny.UI.UIRadioButton();
            this.label6 = new Sunny.UI.UILabel();
            this.numericUpDown3 = new Sunny.UI.UIIntegerUpDown();
            this.label5 = new Sunny.UI.UILabel();
            this.lable6 = new Sunny.UI.UILabel();
            this.numericUpDown2 = new Sunny.UI.UIIntegerUpDown();
            this.numericUpDown1 = new Sunny.UI.UIIntegerUpDown();
            this.radioButton2 = new Sunny.UI.UIRadioButton();
            this.radioButton1 = new Sunny.UI.UIRadioButton();
            this.groupBox1 = new Sunny.UI.UIGroupBox();
            this.radioButton5 = new Sunny.UI.UIRadioButton();
            this.radioButton4 = new Sunny.UI.UIRadioButton();
            this.radioButton3 = new Sunny.UI.UIRadioButton();
            this.gb2 = new Sunny.UI.UIGroupBox();
            this.radioButton8 = new Sunny.UI.UIRadioButton();
            this.radioButton7 = new Sunny.UI.UIRadioButton();
            this.radioButton6 = new Sunny.UI.UIRadioButton();
            this.gbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("宋体", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(392, 392);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始挑战";
            this.button1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.radioButton9);
            this.gbox.Controls.Add(this.label6);
            this.gbox.Controls.Add(this.numericUpDown3);
            this.gbox.Controls.Add(this.label5);
            this.gbox.Controls.Add(this.lable6);
            this.gbox.Controls.Add(this.numericUpDown2);
            this.gbox.Controls.Add(this.numericUpDown1);
            this.gbox.Controls.Add(this.radioButton2);
            this.gbox.Controls.Add(this.radioButton1);
            this.gbox.Font = new System.Drawing.Font("宋体", 25F);
            this.gbox.Location = new System.Drawing.Point(34, 54);
            this.gbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbox.Name = "gbox";
            this.gbox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbox.Size = new System.Drawing.Size(1033, 218);
            this.gbox.TabIndex = 7;
            this.gbox.TabStop = false;
            this.gbox.Text = "模式";
            this.gbox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton9
            // 
            this.radioButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton9.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton9.Location = new System.Drawing.Point(31, 171);
            this.radioButton9.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(339, 44);
            this.radioButton9.TabIndex = 12;
            this.radioButton9.Text = "错误就结束";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(522, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 43);
            this.label6.TabIndex = 11;
            this.label6.Text = "秒";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("宋体", 25F);
            this.numericUpDown3.Location = new System.Drawing.Point(418, 38);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown3.MinimumSize = new System.Drawing.Size(100, 0);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ShowText = false;
            this.numericUpDown3.Size = new System.Drawing.Size(100, 55);
            this.numericUpDown3.TabIndex = 10;
            this.numericUpDown3.Text = null;
            this.numericUpDown3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(297, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "分钟";
            // 
            // lable6
            // 
            this.lable6.Font = new System.Drawing.Font("宋体", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lable6.Location = new System.Drawing.Point(297, 116);
            this.lable6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(160, 43);
            this.lable6.TabIndex = 9;
            this.lable6.Text = "题目数";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("宋体", 25F);
            this.numericUpDown2.Location = new System.Drawing.Point(182, 104);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.MinimumSize = new System.Drawing.Size(100, 0);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ShowText = false;
            this.numericUpDown2.Size = new System.Drawing.Size(100, 55);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Text = null;
            this.numericUpDown2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 25F);
            this.numericUpDown1.Location = new System.Drawing.Point(182, 38);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.MinimumSize = new System.Drawing.Size(100, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ShowText = false;
            this.numericUpDown1.Size = new System.Drawing.Size(100, 55);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Text = null;
            this.numericUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton2.Location = new System.Drawing.Point(31, 104);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(172, 44);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "计时";
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton1.Location = new System.Drawing.Point(31, 44);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(147, 51);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "限时";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 25F);
            this.groupBox1.Location = new System.Drawing.Point(30, 279);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 32, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(541, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "位数";
            this.groupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton5
            // 
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton5.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton5.Location = new System.Drawing.Point(362, 39);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(161, 51);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "三位数";
            // 
            // radioButton4
            // 
            this.radioButton4.Checked = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton4.Location = new System.Drawing.Point(191, 39);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(215, 51);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "两位数";
            // 
            // radioButton3
            // 
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton3.Location = new System.Drawing.Point(16, 48);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(222, 42);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "一位数";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.radioButton8);
            this.gb2.Controls.Add(this.radioButton7);
            this.gb2.Controls.Add(this.radioButton6);
            this.gb2.Font = new System.Drawing.Font("宋体", 25F);
            this.gb2.Location = new System.Drawing.Point(575, 279);
            this.gb2.Margin = new System.Windows.Forms.Padding(2);
            this.gb2.MinimumSize = new System.Drawing.Size(1, 1);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(2, 32, 2, 2);
            this.gb2.Size = new System.Drawing.Size(496, 108);
            this.gb2.TabIndex = 9;
            this.gb2.TabStop = false;
            this.gb2.Text = "算法";
            this.gb2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton8
            // 
            this.radioButton8.Checked = true;
            this.radioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton8.Location = new System.Drawing.Point(291, 46);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton8.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(201, 42);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.Text = "加减乘除";
            // 
            // radioButton7
            // 
            this.radioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton7.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton7.Location = new System.Drawing.Point(163, 46);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(157, 42);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.Text = "乘除";
            // 
            // radioButton6
            // 
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6.Font = new System.Drawing.Font("宋体", 25F);
            this.radioButton6.Location = new System.Drawing.Point(41, 46);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(222, 42);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.Text = "加减";
            // 
            // frmCalcPKSet
            // 
            this.ClientSize = new System.Drawing.Size(1078, 504);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCalcPKSet";
            this.Text = "计算PK";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 657, 623);
            this.Load += new System.EventHandler(this.frmCalcPKSet_Load);
            this.gbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gb2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private Sunny.UI.UILabel label5;
        private Sunny.UI.UILabel lable6;
    }
}
