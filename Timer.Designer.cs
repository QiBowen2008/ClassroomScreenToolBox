namespace ClassroomScreenToolBox
{
    partial class Timer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ucBtnExt13 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt11 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt12 = new HZH_Controls.Controls.UCBtnExt();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucProcessExt1 = new HZH_Controls.Controls.UCProcessExt();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ucBtnExt10 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt9 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt5 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt6 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt7 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt8 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt4 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt3 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.tabControlExt1 = new HZH_Controls.Controls.TabControlExt();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControlExt1.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ucBtnExt13);
            this.tabPage2.Controls.Add(this.ucBtnExt11);
            this.tabPage2.Controls.Add(this.ucBtnExt12);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "秒表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(35, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(508, 189);
            this.dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "次数";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "时间";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 450;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(79, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 104);
            this.label2.TabIndex = 31;
            this.label2.Text = "00:00:00.0";
            // 
            // ucBtnExt13
            // 
            this.ucBtnExt13.BackColor = System.Drawing.Color.White;
            this.ucBtnExt13.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt13.BtnFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt13.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt13.BtnText = "计次";
            this.ucBtnExt13.ConerRadius = 5;
            this.ucBtnExt13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt13.EnabledMouseEffect = false;
            this.ucBtnExt13.FillColor = System.Drawing.Color.Red;
            this.ucBtnExt13.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt13.IsRadius = true;
            this.ucBtnExt13.IsShowRect = true;
            this.ucBtnExt13.IsShowTips = false;
            this.ucBtnExt13.Location = new System.Drawing.Point(394, 138);
            this.ucBtnExt13.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt13.Name = "ucBtnExt13";
            this.ucBtnExt13.RectColor = System.Drawing.Color.Red;
            this.ucBtnExt13.RectWidth = 1;
            this.ucBtnExt13.Size = new System.Drawing.Size(135, 44);
            this.ucBtnExt13.TabIndex = 30;
            this.ucBtnExt13.TabStop = false;
            this.ucBtnExt13.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt13.TipsText = "";
            this.ucBtnExt13.BtnClick += new System.EventHandler(this.ucBtnExt13_BtnClick);
            // 
            // ucBtnExt11
            // 
            this.ucBtnExt11.BackColor = System.Drawing.Color.White;
            this.ucBtnExt11.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt11.BtnFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt11.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt11.BtnText = "结束";
            this.ucBtnExt11.ConerRadius = 5;
            this.ucBtnExt11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt11.EnabledMouseEffect = false;
            this.ucBtnExt11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ucBtnExt11.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt11.IsRadius = true;
            this.ucBtnExt11.IsShowRect = true;
            this.ucBtnExt11.IsShowTips = false;
            this.ucBtnExt11.Location = new System.Drawing.Point(219, 138);
            this.ucBtnExt11.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt11.Name = "ucBtnExt11";
            this.ucBtnExt11.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ucBtnExt11.RectWidth = 1;
            this.ucBtnExt11.Size = new System.Drawing.Size(135, 44);
            this.ucBtnExt11.TabIndex = 29;
            this.ucBtnExt11.TabStop = false;
            this.ucBtnExt11.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt11.TipsText = "";
            this.ucBtnExt11.BtnClick += new System.EventHandler(this.ucBtnExt11_BtnClick);
            // 
            // ucBtnExt12
            // 
            this.ucBtnExt12.BackColor = System.Drawing.Color.White;
            this.ucBtnExt12.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt12.BtnFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt12.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt12.BtnText = "开始";
            this.ucBtnExt12.ConerRadius = 5;
            this.ucBtnExt12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt12.EnabledMouseEffect = false;
            this.ucBtnExt12.FillColor = System.Drawing.Color.Gold;
            this.ucBtnExt12.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt12.IsRadius = true;
            this.ucBtnExt12.IsShowRect = true;
            this.ucBtnExt12.IsShowTips = false;
            this.ucBtnExt12.Location = new System.Drawing.Point(44, 138);
            this.ucBtnExt12.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt12.Name = "ucBtnExt12";
            this.ucBtnExt12.RectColor = System.Drawing.Color.Gold;
            this.ucBtnExt12.RectWidth = 1;
            this.ucBtnExt12.Size = new System.Drawing.Size(135, 44);
            this.ucBtnExt12.TabIndex = 28;
            this.ucBtnExt12.TabStop = false;
            this.ucBtnExt12.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt12.TipsText = "";
            this.ucBtnExt12.BtnClick += new System.EventHandler(this.ucBtnExt12_BtnClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucProcessExt1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ucBtnExt10);
            this.tabPage1.Controls.Add(this.ucBtnExt9);
            this.tabPage1.Controls.Add(this.ucBtnExt5);
            this.tabPage1.Controls.Add(this.ucBtnExt6);
            this.tabPage1.Controls.Add(this.ucBtnExt7);
            this.tabPage1.Controls.Add(this.ucBtnExt8);
            this.tabPage1.Controls.Add(this.ucBtnExt4);
            this.tabPage1.Controls.Add(this.ucBtnExt3);
            this.tabPage1.Controls.Add(this.ucBtnExt2);
            this.tabPage1.Controls.Add(this.ucBtnExt1);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "倒计时";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucProcessExt1
            // 
            this.ucProcessExt1.BackColor = System.Drawing.Color.White;
            this.ucProcessExt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucProcessExt1.ConerRadius = 5;
            this.ucProcessExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucProcessExt1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucProcessExt1.IsRadius = true;
            this.ucProcessExt1.IsShowRect = false;
            this.ucProcessExt1.Location = new System.Drawing.Point(29, 364);
            this.ucProcessExt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucProcessExt1.MaxValue = 100;
            this.ucProcessExt1.Name = "ucProcessExt1";
            this.ucProcessExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucProcessExt1.RectWidth = 1;
            this.ucProcessExt1.Size = new System.Drawing.Size(515, 27);
            this.ucProcessExt1.TabIndex = 34;
            this.ucProcessExt1.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(251, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 104);
            this.label1.TabIndex = 33;
            this.label1.Text = ":";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(409, 97);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 113);
            this.textBox4.TabIndex = 32;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.TextChange);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            this.textBox4.Leave += new System.EventHandler(this.LimitInputNumber);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(318, 97);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 113);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.TextChange);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.LimitInputNumber);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(177, 97);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 113);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.TextChange);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.LimitInputNumber);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(86, 97);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(68, 113);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.TextChange);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.LimitInputNumber);
            // 
            // ucBtnExt10
            // 
            this.ucBtnExt10.BackColor = System.Drawing.Color.White;
            this.ucBtnExt10.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt10.BtnFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt10.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt10.BtnText = "结束";
            this.ucBtnExt10.ConerRadius = 5;
            this.ucBtnExt10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt10.EnabledMouseEffect = false;
            this.ucBtnExt10.FillColor = System.Drawing.Color.Blue;
            this.ucBtnExt10.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt10.IsRadius = true;
            this.ucBtnExt10.IsShowRect = true;
            this.ucBtnExt10.IsShowTips = false;
            this.ucBtnExt10.Location = new System.Drawing.Point(318, 305);
            this.ucBtnExt10.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt10.Name = "ucBtnExt10";
            this.ucBtnExt10.RectColor = System.Drawing.SystemColors.MenuHighlight;
            this.ucBtnExt10.RectWidth = 1;
            this.ucBtnExt10.Size = new System.Drawing.Size(135, 44);
            this.ucBtnExt10.TabIndex = 27;
            this.ucBtnExt10.TabStop = false;
            this.ucBtnExt10.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt10.TipsText = "";
            this.ucBtnExt10.BtnClick += new System.EventHandler(this.ucBtnExt10_BtnClick);
            // 
            // ucBtnExt9
            // 
            this.ucBtnExt9.BackColor = System.Drawing.Color.White;
            this.ucBtnExt9.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt9.BtnFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt9.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt9.BtnText = "开始";
            this.ucBtnExt9.ConerRadius = 5;
            this.ucBtnExt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt9.EnabledMouseEffect = false;
            this.ucBtnExt9.FillColor = System.Drawing.Color.Gold;
            this.ucBtnExt9.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt9.IsRadius = true;
            this.ucBtnExt9.IsShowRect = true;
            this.ucBtnExt9.IsShowTips = false;
            this.ucBtnExt9.Location = new System.Drawing.Point(110, 305);
            this.ucBtnExt9.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt9.Name = "ucBtnExt9";
            this.ucBtnExt9.RectColor = System.Drawing.Color.Gold;
            this.ucBtnExt9.RectWidth = 1;
            this.ucBtnExt9.Size = new System.Drawing.Size(135, 44);
            this.ucBtnExt9.TabIndex = 26;
            this.ucBtnExt9.TabStop = false;
            this.ucBtnExt9.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt9.TipsText = "";
            this.ucBtnExt9.BtnClick += new System.EventHandler(this.ucBtnExt9_BtnClick);
            // 
            // ucBtnExt5
            // 
            this.ucBtnExt5.BackColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnFont = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt5.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt5.BtnText = "-";
            this.ucBtnExt5.ConerRadius = 5;
            this.ucBtnExt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt5.EnabledMouseEffect = false;
            this.ucBtnExt5.FillColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt5.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt5.IsRadius = true;
            this.ucBtnExt5.IsShowRect = true;
            this.ucBtnExt5.IsShowTips = false;
            this.ucBtnExt5.Location = new System.Drawing.Point(409, 225);
            this.ucBtnExt5.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt5.Name = "ucBtnExt5";
            this.ucBtnExt5.RectColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt5.RectWidth = 1;
            this.ucBtnExt5.Size = new System.Drawing.Size(68, 65);
            this.ucBtnExt5.TabIndex = 23;
            this.ucBtnExt5.TabStop = false;
            this.ucBtnExt5.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt5.TipsText = "";
            this.ucBtnExt5.BtnClick += new System.EventHandler(this.ucBtnExt5_BtnClick);
            // 
            // ucBtnExt6
            // 
            this.ucBtnExt6.BackColor = System.Drawing.Color.White;
            this.ucBtnExt6.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt6.BtnFont = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt6.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt6.BtnText = "-";
            this.ucBtnExt6.ConerRadius = 5;
            this.ucBtnExt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt6.EnabledMouseEffect = false;
            this.ucBtnExt6.FillColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt6.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt6.IsRadius = true;
            this.ucBtnExt6.IsShowRect = true;
            this.ucBtnExt6.IsShowTips = false;
            this.ucBtnExt6.Location = new System.Drawing.Point(318, 225);
            this.ucBtnExt6.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt6.Name = "ucBtnExt6";
            this.ucBtnExt6.RectColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt6.RectWidth = 1;
            this.ucBtnExt6.Size = new System.Drawing.Size(68, 65);
            this.ucBtnExt6.TabIndex = 24;
            this.ucBtnExt6.TabStop = false;
            this.ucBtnExt6.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt6.TipsText = "";
            this.ucBtnExt6.BtnClick += new System.EventHandler(this.ucBtnExt6_BtnClick);
            // 
            // ucBtnExt7
            // 
            this.ucBtnExt7.BackColor = System.Drawing.Color.White;
            this.ucBtnExt7.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt7.BtnFont = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt7.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt7.BtnText = "-";
            this.ucBtnExt7.ConerRadius = 5;
            this.ucBtnExt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt7.EnabledMouseEffect = false;
            this.ucBtnExt7.FillColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt7.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt7.IsRadius = true;
            this.ucBtnExt7.IsShowRect = true;
            this.ucBtnExt7.IsShowTips = false;
            this.ucBtnExt7.Location = new System.Drawing.Point(177, 225);
            this.ucBtnExt7.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt7.Name = "ucBtnExt7";
            this.ucBtnExt7.RectColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt7.RectWidth = 1;
            this.ucBtnExt7.Size = new System.Drawing.Size(68, 65);
            this.ucBtnExt7.TabIndex = 25;
            this.ucBtnExt7.TabStop = false;
            this.ucBtnExt7.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt7.TipsText = "";
            this.ucBtnExt7.BtnClick += new System.EventHandler(this.ucBtnExt7_BtnClick);
            // 
            // ucBtnExt8
            // 
            this.ucBtnExt8.BackColor = System.Drawing.Color.White;
            this.ucBtnExt8.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt8.BtnFont = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt8.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt8.BtnText = "-";
            this.ucBtnExt8.ConerRadius = 5;
            this.ucBtnExt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt8.EnabledMouseEffect = false;
            this.ucBtnExt8.FillColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt8.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt8.IsRadius = true;
            this.ucBtnExt8.IsShowRect = true;
            this.ucBtnExt8.IsShowTips = false;
            this.ucBtnExt8.Location = new System.Drawing.Point(86, 225);
            this.ucBtnExt8.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt8.Name = "ucBtnExt8";
            this.ucBtnExt8.RectColor = System.Drawing.Color.LimeGreen;
            this.ucBtnExt8.RectWidth = 1;
            this.ucBtnExt8.Size = new System.Drawing.Size(68, 65);
            this.ucBtnExt8.TabIndex = 22;
            this.ucBtnExt8.TabStop = false;
            this.ucBtnExt8.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt8.TipsText = "";
            this.ucBtnExt8.BtnClick += new System.EventHandler(this.ucBtnExt8_BtnClick);
            // 
            // ucBtnExt4
            // 
            this.ucBtnExt4.BackColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnFont = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt4.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt4.BtnText = "+";
            this.ucBtnExt4.ConerRadius = 5;
            this.ucBtnExt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt4.EnabledMouseEffect = false;
            this.ucBtnExt4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt4.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt4.IsRadius = true;
            this.ucBtnExt4.IsShowRect = true;
            this.ucBtnExt4.IsShowTips = false;
            this.ucBtnExt4.Location = new System.Drawing.Point(409, 17);
            this.ucBtnExt4.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt4.Name = "ucBtnExt4";
            this.ucBtnExt4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt4.RectWidth = 1;
            this.ucBtnExt4.Size = new System.Drawing.Size(68, 65);
            this.ucBtnExt4.TabIndex = 19;
            this.ucBtnExt4.TabStop = false;
            this.ucBtnExt4.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt4.TipsText = "";
            this.ucBtnExt4.BtnClick += new System.EventHandler(this.ucBtnExt4_BtnClick);
            // 
            // ucBtnExt3
            // 
            this.ucBtnExt3.BackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnFont = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt3.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnText = "+";
            this.ucBtnExt3.ConerRadius = 5;
            this.ucBtnExt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt3.EnabledMouseEffect = false;
            this.ucBtnExt3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt3.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt3.IsRadius = true;
            this.ucBtnExt3.IsShowRect = true;
            this.ucBtnExt3.IsShowTips = false;
            this.ucBtnExt3.Location = new System.Drawing.Point(318, 17);
            this.ucBtnExt3.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt3.Name = "ucBtnExt3";
            this.ucBtnExt3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt3.RectWidth = 1;
            this.ucBtnExt3.Size = new System.Drawing.Size(68, 65);
            this.ucBtnExt3.TabIndex = 20;
            this.ucBtnExt3.TabStop = false;
            this.ucBtnExt3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt3.TipsText = "";
            this.ucBtnExt3.BtnClick += new System.EventHandler(this.ucBtnExt3_BtnClick);
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = "+";
            this.ucBtnExt2.ConerRadius = 5;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt2.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(177, 17);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(68, 65);
            this.ucBtnExt2.TabIndex = 21;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            this.ucBtnExt2.BtnClick += new System.EventHandler(this.ucBtnExt2_BtnClick);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "+";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(86, 17);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(68, 65);
            this.ucBtnExt1.TabIndex = 18;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // tabControlExt1
            // 
            this.tabControlExt1.BackColor = System.Drawing.SystemColors.Control;
            this.tabControlExt1.CloseBtnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.tabControlExt1.Controls.Add(this.tabPage1);
            this.tabControlExt1.Controls.Add(this.tabPage2);
            this.tabControlExt1.IsShowCloseBtn = false;
            this.tabControlExt1.ItemSize = new System.Drawing.Size(0, 50);
            this.tabControlExt1.Location = new System.Drawing.Point(12, 38);
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.Size = new System.Drawing.Size(582, 459);
            this.tabControlExt1.TabIndex = 13;
            this.tabControlExt1.UncloseTabIndexs = null;
            // 
            // Timer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(612, 500);
            this.Controls.Add(this.tabControlExt1);
            this.Name = "Timer";
            this.Text = "计时器";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 612, 494);
            this.Shown += new System.EventHandler(this.Timer_Shown);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControlExt1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt13;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt11;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt12;
        private System.Windows.Forms.TabPage tabPage1;
        private HZH_Controls.Controls.UCProcessExt ucProcessExt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt10;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt9;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt5;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt6;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt7;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt8;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt4;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.TabControlExt tabControlExt1;
    }
}