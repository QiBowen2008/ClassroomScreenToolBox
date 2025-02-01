using System;
using System.Diagnostics;
using System.Windows;

namespace ClassroomScreenToolBox
{
    public partial class frmTimeShutdown : Sunny.UI.UIForm2
    {
        public frmTimeShutdown()
        {
            InitializeComponent();
            //设置默认时间为当前时间
            nud_hour.Value = Convert.ToInt32(DateTime.Now.Hour);
            nud_min.Value = Convert.ToInt32(DateTime.Now.Minute);
        }
        /// <summary>
        /// 启动定时关机程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseComputer_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 取消关机命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelClose_Click(object sender, EventArgs e) => OperateComputer("shutdown -a");


        /// <summary>
        /// 操作电脑命令
        /// </summary>
        /// <param name="command"></param>
        private void OperateComputer(string command)
        {
            var startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            var myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo = startInfo;
            myProcess.Start();
            myProcess.StandardInput.WriteLine(command);
        }


        /// <summary>
        /// 指定时间关机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeClose_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                int hour = Convert.ToInt32(nud_hour.Value);
                int min = Convert.ToInt32(nud_min.Value);

                DateTime closedt = DateTime.Now;

                if (hour < DateTime.Now.Hour)
                {
                    string strdt = DateTime.Now.AddDays(1D).ToString("yyyy-MM-dd") + " " + hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0');
                    closedt = Convert.ToDateTime(strdt);

                }
                else
                {
                    string strdt = DateTime.Now.ToString("yyyy-MM-dd") + " " + hour.ToString().PadLeft(2, '0') + ":" + min.ToString().PadLeft(2, '0');
                    closedt = Convert.ToDateTime(strdt);
                }

                int total = Convert.ToInt32((closedt - DateTime.Now).TotalSeconds);
                OperateComputer("shutdown -s -t " + total);

                //一下命令没有效果
                //string command = "at " + hour + ":" + min + " shutdown -s";
                //OperateComputer(command); 

            }
            else
            {
                IniManager.writeString("AutoShutdown", "Enable", "True", "config.ini");
                IniManager.writeString("AutoShutdown", "Enable", nud_hour.Value.ToString(), "config.ini");
                IniManager.writeString("AutoShutdown", "Enable", nud_min.Value.ToString(), "config.ini");
                try
                {
                    Process.Start("sc", "start ClassroomScreenToolbox.AutoShutdown");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TimeShutdown_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
