using System;
using System.ServiceProcess;
using System.Timers;

namespace ClassroomScreenToolbox.AutoShutdown
{
    public partial class Service1: ServiceBase
    {
        private Timer _timer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // 设置定时器，每隔1分钟检查一次时间
            _timer = new Timer(60000); // 60000毫秒 = 1分钟
            _timer.Elapsed += OnTimerElapsed;
            _timer.AutoReset = true;
            if(IniManager .getString("AutoShutdown", "Enable", "False", "config.ini") == "True")
            {
                _timer.Enabled = true;
            }
        }
 
        protected override void OnStop()
        {
        }
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            // 获取当前时间
            DateTime now = DateTime.Now;

            if (now.Hour.ToString () == IniManager .getString ("AutoShutdown", "Hour", "False", "config.ini") && now.Minute.ToString () == IniManager .getString ("AutoShutdown", "Enable", "False", "config.ini"))
            {
                // 执行关机命令
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            }
        }

    }
}
