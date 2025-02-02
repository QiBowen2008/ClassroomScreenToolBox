using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{
    public partial class frmMain : Sunny.UI.UIForm2
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }
        private void ucImg1_Click(object sender, EventArgs e)
        {
            frmTimeShutdown timeShutdown = new frmTimeShutdown();
            timeShutdown.Show();
        }
        private void ucImg2_Click(object sender, EventArgs e)
        {
            frmTimer timer = new frmTimer();
            timer.Show();
        }
        private void ucExt1_Click_1(object sender, EventArgs e)
        {
            frmSet set = new frmSet();
            set.Show();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string icon = "true";
            if (icon == "True")
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) => Process.GetCurrentProcess().Kill();
        private void ucImg3_Click(object sender, EventArgs e)
        {
            frmEncourageWall hurryup = new frmEncourageWall();
            hurryup.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            float dpiX, dpiY;
            using (Graphics g = CreateGraphics())
            {
                dpiX = g.DpiX;
                dpiY = g.DpiY;
            }
            // 根据DPI比例调整控件尺寸
            float scaleFactor = dpiX / 96f; // 96 DPI 是标准DPI
            foreach (Control control in Controls)
            {
                control.Width = (int)(control.Width * scaleFactor);
                control.Height = (int)(control.Height * scaleFactor);
                control.Left = (int)(control.Left * scaleFactor);
                control.Top = (int)(control.Top * scaleFactor);
                control.Font = new Font(control.Font.FontFamily, control.Font.SizeInPoints  * scaleFactor, control.Font.Style);
            }
            Height = (int)(Height * scaleFactor);
            Width = (int)(Width * scaleFactor);
            titleHeight = Convert.ToInt32(titleHeight * scaleFactor);
            titleFont = new Font(titleFont.FontFamily, titleFont.Size * scaleFactor, titleFont.Style);
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            frmCalcPKSet frmCalcPKset = new frmCalcPKSet();
            frmCalcPKset.Show();
        }
    }
}
