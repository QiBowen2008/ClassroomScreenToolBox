using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{
    public partial class FormMain : Sunny.UI.UIForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
        private void ucBtnImg1_BtnClick(object sender, EventArgs e)
        {
            TimeShutdown timeShutdown = new TimeShutdown();
            timeShutdown.Show();
        }
        private void ucBtnImg2_BtnClick(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Show();
        }
        private void ucBtnExt1_BtnClick_1(object sender, EventArgs e)
        {
            Set set = new Set();
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
        private void ucBtnImg3_BtnClick(object sender, EventArgs e)
        {
            Hurryup hurryup = new Hurryup();
            hurryup.Show();
        }
    }
}
