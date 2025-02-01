namespace ClassroomScreenToolBox
{
    partial class frmTimer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimer = new System.Windows.Forms.Label();
            this.ucExt13 = new Sunny.UI.UIButton();
            this.ucExt11 = new Sunny.UI.UIButton();
            this.ucExt12 = new Sunny.UI.UIButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucProcessExt1 = new Sunny.UI.UIProcessBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ucExt10 = new Sunny.UI.UIButton();
            this.ucExt9 = new Sunny.UI.UIButton();
            this.ucExt5 = new Sunny.UI.UIButton();
            this.ucExt6 = new Sunny.UI.UIButton();
            this.ucExt7 = new Sunny.UI.UIButton();
            this.ucExt8 = new Sunny.UI.UIButton();
            this.ucExt4 = new Sunny.UI.UIButton();
            this.ucExt3 = new Sunny.UI.UIButton();
            this.ucExt2 = new Sunny.UI.UIButton();
            this.ucExt1 = new Sunny.UI.UIButton();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.lblTimer);
            this.tabPage2.Controls.Add(this.ucExt13);
            this.tabPage2.Controls.Add(this.ucExt11);
            this.tabPage2.Controls.Add(this.ucExt12);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "秒表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(35, 209);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectedIndex = -1;
            this.dataGridView1.Size = new System.Drawing.Size(508, 189);
            this.dataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "次数";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "时间";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 450;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimer.Location = new System.Drawing.Point(76, 31);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(430, 104);
            this.lblTimer.TabIndex = 31;
            this.lblTimer.Text = "00:00:00.0";
            // 
            // ucExt13
            // 
            this.ucExt13.BackColor = System.Drawing.Color.White;
            this.ucExt13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt13.FillColor = System.Drawing.Color.Red;
            this.ucExt13.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt13.Location = new System.Drawing.Point(394, 138);
            this.ucExt13.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt13.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt13.Name = "ucExt13";
            this.ucExt13.RectColor = System.Drawing.Color.Red;
            this.ucExt13.Size = new System.Drawing.Size(135, 44);
            this.ucExt13.TabIndex = 30;
            this.ucExt13.TabStop = false;
            this.ucExt13.Text = "计次";
            this.ucExt13.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt13.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt13.Click += new System.EventHandler(this.ucExt13_Click);
            // 
            // ucExt11
            // 
            this.ucExt11.BackColor = System.Drawing.Color.White;
            this.ucExt11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ucExt11.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt11.Location = new System.Drawing.Point(219, 138);
            this.ucExt11.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt11.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt11.Name = "ucExt11";
            this.ucExt11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ucExt11.Size = new System.Drawing.Size(135, 44);
            this.ucExt11.TabIndex = 29;
            this.ucExt11.TabStop = false;
            this.ucExt11.Text = "结束";
            this.ucExt11.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt11.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt11.Click += new System.EventHandler(this.ucExt11_Click);
            // 
            // ucExt12
            // 
            this.ucExt12.BackColor = System.Drawing.Color.White;
            this.ucExt12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt12.FillColor = System.Drawing.Color.Gold;
            this.ucExt12.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt12.Location = new System.Drawing.Point(44, 138);
            this.ucExt12.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt12.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt12.Name = "ucExt12";
            this.ucExt12.RectColor = System.Drawing.Color.Gold;
            this.ucExt12.Size = new System.Drawing.Size(135, 44);
            this.ucExt12.TabIndex = 28;
            this.ucExt12.TabStop = false;
            this.ucExt12.Text = "开始";
            this.ucExt12.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt12.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt12.Click += new System.EventHandler(this.ucExt12_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucProcessExt1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ucExt10);
            this.tabPage1.Controls.Add(this.ucExt9);
            this.tabPage1.Controls.Add(this.ucExt5);
            this.tabPage1.Controls.Add(this.ucExt6);
            this.tabPage1.Controls.Add(this.ucExt7);
            this.tabPage1.Controls.Add(this.ucExt8);
            this.tabPage1.Controls.Add(this.ucExt4);
            this.tabPage1.Controls.Add(this.ucExt3);
            this.tabPage1.Controls.Add(this.ucExt2);
            this.tabPage1.Controls.Add(this.ucExt1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(567, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "倒计时";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucProcessExt1
            // 
            this.ucProcessExt1.BackColor = System.Drawing.Color.White;
            this.ucProcessExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucProcessExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucProcessExt1.Location = new System.Drawing.Point(29, 364);
            this.ucProcessExt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucProcessExt1.MinimumSize = new System.Drawing.Size(3, 3);
            this.ucProcessExt1.Name = "ucProcessExt1";
            this.ucProcessExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucProcessExt1.Size = new System.Drawing.Size(515, 27);
            this.ucProcessExt1.TabIndex = 34;
            this.ucProcessExt1.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(248, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 104);
            this.label1.TabIndex = 33;
            this.label1.Text = ":";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(409, 97);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 113);
            this.textBox4.TabIndex = 32;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            this.textBox4.Leave += new System.EventHandler(this.LimitInputNumber);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(318, 97);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 113);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.LimitInputNumber);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(177, 97);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 113);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.LimitInputNumber);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(86, 97);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(68, 113);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.LimitInputNumber);
            // 
            // ucExt10
            // 
            this.ucExt10.BackColor = System.Drawing.Color.White;
            this.ucExt10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt10.FillColor = System.Drawing.Color.Blue;
            this.ucExt10.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt10.Location = new System.Drawing.Point(318, 305);
            this.ucExt10.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt10.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt10.Name = "ucExt10";
            this.ucExt10.RectColor = System.Drawing.Color.MediumBlue;
            this.ucExt10.Size = new System.Drawing.Size(135, 44);
            this.ucExt10.TabIndex = 27;
            this.ucExt10.TabStop = false;
            this.ucExt10.Text = "结束";
            this.ucExt10.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt10.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt10.Click += new System.EventHandler(this.ucExt10_Click);
            // 
            // ucExt9
            // 
            this.ucExt9.BackColor = System.Drawing.Color.White;
            this.ucExt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt9.FillColor = System.Drawing.Color.Gold;
            this.ucExt9.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt9.Location = new System.Drawing.Point(110, 305);
            this.ucExt9.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt9.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt9.Name = "ucExt9";
            this.ucExt9.RectColor = System.Drawing.Color.Gold;
            this.ucExt9.Size = new System.Drawing.Size(135, 44);
            this.ucExt9.TabIndex = 26;
            this.ucExt9.TabStop = false;
            this.ucExt9.Text = "开始";
            this.ucExt9.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt9.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt9.Click += new System.EventHandler(this.ucExt9_Click);
            // 
            // ucExt5
            // 
            this.ucExt5.BackColor = System.Drawing.Color.White;
            this.ucExt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt5.FillColor = System.Drawing.Color.LimeGreen;
            this.ucExt5.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt5.Location = new System.Drawing.Point(409, 225);
            this.ucExt5.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt5.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt5.Name = "ucExt5";
            this.ucExt5.RectColor = System.Drawing.Color.LimeGreen;
            this.ucExt5.Size = new System.Drawing.Size(68, 65);
            this.ucExt5.TabIndex = 23;
            this.ucExt5.TabStop = false;
            this.ucExt5.Text = "-";
            this.ucExt5.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt5.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt5.Click += new System.EventHandler(this.ucExt5_Click);
            // 
            // ucExt6
            // 
            this.ucExt6.BackColor = System.Drawing.Color.White;
            this.ucExt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt6.FillColor = System.Drawing.Color.LimeGreen;
            this.ucExt6.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt6.Location = new System.Drawing.Point(318, 225);
            this.ucExt6.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt6.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt6.Name = "ucExt6";
            this.ucExt6.RectColor = System.Drawing.Color.LimeGreen;
            this.ucExt6.Size = new System.Drawing.Size(68, 65);
            this.ucExt6.TabIndex = 24;
            this.ucExt6.TabStop = false;
            this.ucExt6.Text = "-";
            this.ucExt6.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt6.Click += new System.EventHandler(this.ucExt6_Click);
            // 
            // ucExt7
            // 
            this.ucExt7.BackColor = System.Drawing.Color.White;
            this.ucExt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt7.FillColor = System.Drawing.Color.LimeGreen;
            this.ucExt7.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt7.Location = new System.Drawing.Point(177, 225);
            this.ucExt7.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt7.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt7.Name = "ucExt7";
            this.ucExt7.RectColor = System.Drawing.Color.LimeGreen;
            this.ucExt7.Size = new System.Drawing.Size(68, 65);
            this.ucExt7.TabIndex = 25;
            this.ucExt7.TabStop = false;
            this.ucExt7.Text = "-";
            this.ucExt7.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt7.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt7.Click += new System.EventHandler(this.ucExt7_Click);
            // 
            // ucExt8
            // 
            this.ucExt8.BackColor = System.Drawing.Color.White;
            this.ucExt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt8.FillColor = System.Drawing.Color.LimeGreen;
            this.ucExt8.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt8.Location = new System.Drawing.Point(86, 225);
            this.ucExt8.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt8.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt8.Name = "ucExt8";
            this.ucExt8.RectColor = System.Drawing.Color.LimeGreen;
            this.ucExt8.Size = new System.Drawing.Size(68, 65);
            this.ucExt8.TabIndex = 22;
            this.ucExt8.TabStop = false;
            this.ucExt8.Text = "-";
            this.ucExt8.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt8.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt8.Click += new System.EventHandler(this.ucExt8_Click);
            // 
            // ucExt4
            // 
            this.ucExt4.BackColor = System.Drawing.Color.White;
            this.ucExt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucExt4.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt4.Location = new System.Drawing.Point(409, 17);
            this.ucExt4.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt4.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt4.Name = "ucExt4";
            this.ucExt4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucExt4.Size = new System.Drawing.Size(68, 65);
            this.ucExt4.TabIndex = 19;
            this.ucExt4.TabStop = false;
            this.ucExt4.Text = "+";
            this.ucExt4.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt4.Click += new System.EventHandler(this.ucExt4_Click);
            // 
            // ucExt3
            // 
            this.ucExt3.BackColor = System.Drawing.Color.White;
            this.ucExt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucExt3.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt3.Location = new System.Drawing.Point(318, 17);
            this.ucExt3.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt3.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt3.Name = "ucExt3";
            this.ucExt3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucExt3.Size = new System.Drawing.Size(68, 65);
            this.ucExt3.TabIndex = 20;
            this.ucExt3.TabStop = false;
            this.ucExt3.Text = "+";
            this.ucExt3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt3.Click += new System.EventHandler(this.ucExt3_Click);
            // 
            // ucExt2
            // 
            this.ucExt2.BackColor = System.Drawing.Color.White;
            this.ucExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucExt2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt2.Location = new System.Drawing.Point(177, 17);
            this.ucExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt2.Name = "ucExt2";
            this.ucExt2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucExt2.Size = new System.Drawing.Size(68, 65);
            this.ucExt2.TabIndex = 21;
            this.ucExt2.TabStop = false;
            this.ucExt2.Text = "+";
            this.ucExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt2.Click += new System.EventHandler(this.ucExt2_Click);
            // 
            // ucExt1
            // 
            this.ucExt1.BackColor = System.Drawing.Color.White;
            this.ucExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucExt1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt1.Location = new System.Drawing.Point(86, 17);
            this.ucExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt1.Name = "ucExt1";
            this.ucExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucExt1.Size = new System.Drawing.Size(68, 65);
            this.ucExt1.TabIndex = 18;
            this.ucExt1.TabStop = false;
            this.ucExt1.Text = "+";
            this.ucExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt1.Click += new System.EventHandler(this.ucExt1_Click);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(3, 38);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(567, 442);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 14;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(331, 343);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(0, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(200, 60);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmTimer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(575, 484);
            this.Controls.Add(this.uiTabControl1);
            this.Name = "frmTimer";
            this.Text = "计时器";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 612, 494);
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.Shown += new System.EventHandler(this.Timer_Shown);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.uiTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTimer;
        private Sunny.UI.UIButton ucExt13;
        private Sunny.UI.UIButton ucExt11;
        private Sunny.UI.UIButton ucExt12;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UIProcessBar ucProcessExt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Sunny.UI.UIButton ucExt10;
        private Sunny.UI.UIButton ucExt9;
        private Sunny.UI.UIButton ucExt5;
        private Sunny.UI.UIButton ucExt6;
        private Sunny.UI.UIButton ucExt7;
        private Sunny.UI.UIButton ucExt8;
        private Sunny.UI.UIButton ucExt4;
        private Sunny.UI.UIButton ucExt3;
        private Sunny.UI.UIButton ucExt2;
        private Sunny.UI.UIButton ucExt1;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Sunny.UI.UIDataGridView dataGridView1;
    }
}