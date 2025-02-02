namespace ClassroomScreenToolBox
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Label1 = new System.Windows.Forms.Label();
            this.ucImg2 = new Sunny.UI.UIImageButton();
            this.ucImg1 = new Sunny.UI.UIImageButton();
            this.ucExt1 = new Sunny.UI.UIButton();
            this.ucExt2 = new Sunny.UI.UIButton();
            this.ucImg3 = new Sunny.UI.UIImageButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.定时关机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计时器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随写板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ucImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucImg3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(77, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(310, 70);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "欢迎使用";
            // 
            // ucImg2
            // 
            this.ucImg2.BackColor = System.Drawing.Color.DodgerBlue;
            this.ucImg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucImg2.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucImg2.ForeColor = System.Drawing.Color.Black;
            this.ucImg2.Image = global::ClassroomScreenToolBox.Properties.Resources.time_line;
            this.ucImg2.Location = new System.Drawing.Point(244, 153);
            this.ucImg2.Margin = new System.Windows.Forms.Padding(0);
            this.ucImg2.Name = "ucImg2";
            this.ucImg2.Size = new System.Drawing.Size(129, 155);
            this.ucImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucImg2.TabIndex = 2;
            this.ucImg2.TabStop = false;
            this.ucImg2.Text = "计时器";
            this.ucImg2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ucImg2.Click += new System.EventHandler(this.ucImg2_Click);
            // 
            // ucImg1
            // 
            this.ucImg1.BackColor = System.Drawing.Color.Red;
            this.ucImg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucImg1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucImg1.ForeColor = System.Drawing.Color.Black;
            this.ucImg1.Image = global::ClassroomScreenToolBox.Properties.Resources.shut_down_line;
            this.ucImg1.Location = new System.Drawing.Point(89, 153);
            this.ucImg1.Margin = new System.Windows.Forms.Padding(0);
            this.ucImg1.Name = "ucImg1";
            this.ucImg1.Size = new System.Drawing.Size(131, 155);
            this.ucImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucImg1.TabIndex = 0;
            this.ucImg1.TabStop = false;
            this.ucImg1.Text = "定时关机";
            this.ucImg1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ucImg1.Click += new System.EventHandler(this.ucImg1_Click);
            // 
            // ucExt1
            // 
            this.ucExt1.BackColor = System.Drawing.Color.White;
            this.ucExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt1.FillColor = System.Drawing.Color.Gold;
            this.ucExt1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt1.Location = new System.Drawing.Point(202, 345);
            this.ucExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt1.Name = "ucExt1";
            this.ucExt1.RectColor = System.Drawing.Color.Gold;
            this.ucExt1.Size = new System.Drawing.Size(113, 37);
            this.ucExt1.TabIndex = 3;
            this.ucExt1.TabStop = false;
            this.ucExt1.Text = "设置";
            this.ucExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt1.Click += new System.EventHandler(this.ucExt1_Click_1);
            // 
            // ucExt2
            // 
            this.ucExt2.BackColor = System.Drawing.Color.White;
            this.ucExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt2.FillColor = System.Drawing.Color.Gold;
            this.ucExt2.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucExt2.Location = new System.Drawing.Point(446, 345);
            this.ucExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt2.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucExt2.Name = "ucExt2";
            this.ucExt2.RectColor = System.Drawing.Color.Gold;
            this.ucExt2.Size = new System.Drawing.Size(113, 37);
            this.ucExt2.TabIndex = 4;
            this.ucExt2.TabStop = false;
            this.ucExt2.Text = "关于";
            this.ucExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt2.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // ucImg3
            // 
            this.ucImg3.BackColor = System.Drawing.Color.Green;
            this.ucImg3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucImg3.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucImg3.ForeColor = System.Drawing.Color.Black;
            this.ucImg3.Image = global::ClassroomScreenToolBox.Properties.Resources.award_fill;
            this.ucImg3.Location = new System.Drawing.Point(400, 153);
            this.ucImg3.Margin = new System.Windows.Forms.Padding(0);
            this.ucImg3.Name = "ucImg3";
            this.ucImg3.Size = new System.Drawing.Size(124, 155);
            this.ucImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucImg3.TabIndex = 2;
            this.ucImg3.TabStop = false;
            this.ucImg3.Text = "激励墙";
            this.ucImg3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ucImg3.Click += new System.EventHandler(this.ucImg3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "教室多媒体工具箱";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.定时关机ToolStripMenuItem,
            this.计时器ToolStripMenuItem,
            this.随写板ToolStripMenuItem,
            this.计算器ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 124);
            this.contextMenuStrip1.Text = "退出";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.toolStripMenuItem1.Text = "关闭";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 定时关机ToolStripMenuItem
            // 
            this.定时关机ToolStripMenuItem.Name = "定时关机ToolStripMenuItem";
            this.定时关机ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.定时关机ToolStripMenuItem.Text = "定时关机";
            // 
            // 计时器ToolStripMenuItem
            // 
            this.计时器ToolStripMenuItem.Name = "计时器ToolStripMenuItem";
            this.计时器ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.计时器ToolStripMenuItem.Text = "计时器";
            // 
            // 随写板ToolStripMenuItem
            // 
            this.随写板ToolStripMenuItem.Name = "随写板ToolStripMenuItem";
            this.随写板ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.随写板ToolStripMenuItem.Text = "随写板";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.计算器ToolStripMenuItem.Text = "计算器";
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.uiImageButton1.ForeColor = System.Drawing.Color.Black;
            this.uiImageButton1.Image = global::ClassroomScreenToolBox.Properties.Resources.numbers_line;
            this.uiImageButton1.Location = new System.Drawing.Point(554, 153);
            this.uiImageButton1.Margin = new System.Windows.Forms.Padding(0);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(124, 155);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 5;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = "口算PK";
            this.uiImageButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uiImageButton1.Click += new System.EventHandler(this.uiImageButton1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(767, 421);
            this.Controls.Add(this.uiImageButton1);
            this.Controls.Add(this.ucImg3);
            this.Controls.Add(this.ucExt2);
            this.Controls.Add(this.ucExt1);
            this.Controls.Add(this.ucImg2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ucImg1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "主页";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 767, 447);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucImg3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIImageButton ucImg1;
        private System.Windows.Forms.Label  Label1;
        private Sunny.UI.UIImageButton ucImg2;
        private Sunny.UI.UIButton ucExt1;
        private Sunny.UI.UIButton ucExt2;
        private Sunny.UI.UIImageButton ucImg3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 定时关机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计时器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 随写板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private Sunny.UI.UIImageButton uiImageButton1;
    }
}

