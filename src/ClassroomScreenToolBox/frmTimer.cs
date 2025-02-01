using System;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{

    public partial class frmTimer : Sunny.UI.UIForm2
    {
        private TaskbarManager windowsTaskbar = TaskbarManager.Instance;
        private JumpList childWindowJumpList;
        private string childWindowAppId;
        public static int item = 0;
        public static int t = 0;
        public static bool timerstate = false;
        public static double allt = 0;
        public frmTimer()
        {
            InitializeComponent();
        }

        private void ucExt1_Click(object sender, EventArgs e)
        {
            if (timerstate == false)
            {
                int t1 = textBox1.Text.ToInt();
                if (t1 < 9)
                {
                    int t1new = t1 + 1;
                    textBox1.Text = t1new.ToString();
                }
            }
        }

        private void ucExt2_Click(object sender, EventArgs e)
        {
            if (timerstate == false)
            {
                int t2 = textBox2.Text.ToInt();
                if (t2 < 9)
                {
                    int t2new = t2 + 1;
                    textBox2.Text = t2new.ToString();
                }
            }
        }

        private void ucExt3_Click(object sender, EventArgs e)
        {
            if (timerstate == false)
            {
                int t3 = textBox3.Text.ToInt();
                if (t3 < 5)
                {
                    int t3new = t3 + 1;
                    textBox3.Text = t3new.ToString();
                }
            }
        }

        private void ucExt4_Click(object sender, EventArgs e)
        {
            if (timerstate == false)
            {
                int t4 = textBox4.Text.ToInt();
                if (t4 < 9)
                {
                    int t4new = t4 + 1;
                    textBox4.Text = t4new.ToString();
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void LimitInputNumber(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = sender as System.Windows.Forms.TextBox;
            if (tb.Text == "")
            {
                tb.Text = "0";
            }
            else
            {
                if(tb.ReadOnly ==false)
                    allt = textBox1.Text.ToInt() * 6000 + textBox2.Text.ToInt() * 600 + textBox3.Text.ToInt() * 100 + textBox4.Text.ToInt() * 10;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= '0' && e.KeyChar <= '5') || (e.KeyChar == 8))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void ucExt8_Click(object sender, EventArgs e)
        {
            if (timerstate == false)
            {
                int t1 = textBox1.Text.ToInt();
                if (t1 > 0)
                {
                    int t1new = t1 - 1;
                    textBox1.Text = t1new.ToString();
                }
            }
        }

        private void ucExt7_Click(object sender, EventArgs e)
        {
            if (timerstate == false)
            {
                int t2 = textBox2.Text.ToInt();
                if (t2 > 0)
                {
                    int t2new = t2 - 1;
                    textBox2.Text = t2new.ToString();
                }
            }
        }

        private void ucExt6_Click(object sender, EventArgs e)
        {
            if (timerstate == false)
            {
                int t3 = textBox3.Text.ToInt();
                if (t3 > 0)
                {
                    int t3new = t3 - 1;
                    textBox3.Text = t3new.ToString();
                }
            }
        }

        private void ucExt5_Click(object sender, EventArgs e)
        {
            if (timerstate == false)
            {
                int t4 = textBox4.Text.ToInt();
                if (t4 > 0)
                {
                    int t4new = t4 - 1;
                    textBox4.Text = t4new.ToString();
                }
            }
        }

        private void ucExt12_Click(object sender, EventArgs e)
        {
            if (ucExt12.Text == "开始")
            {
                startTime = DateTime.Now - elapsedTime; // 设置开始时间
                timer2.Start(); // 启动计时器
                isRunning = true;
            }
            else
            {
                timer2.Stop(); // 停止计时器
                isRunning = false;
            }
        }
        private DateTime startTime; // 记录开始时间
        private TimeSpan elapsedTime; // 记录经过的时间
        private bool isRunning = false; // 记录秒表是否正在运行
        private void Tick(object sender, EventArgs e)
        {

            elapsedTime = DateTime.Now - startTime;
            // 更新 Label 显示
            lblTimer.Text = elapsedTime.ToString(@"hh\:mm\:ss\.ff");
        }
        private void ucExt11_Click(object sender, EventArgs e)
        {
            timer2.Stop(); // 停止计时器
            elapsedTime = TimeSpan.Zero; // 重置经过的时间
            lblTimer.Text = "00:00:00.00"; // 重置 Label 显示
            isRunning = false;
        }

        private void ucExt13_Click(object sender, EventArgs e)
        {
            item++;
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = item;
            dataGridView1.Rows[index].Cells[1].Value = lblTimer.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int m = textBox1.Text.ToInt() * 6000 + textBox2.Text.ToInt() * 600 + textBox3.Text.ToInt() * 100 + textBox4.Text.ToInt() * 10;
            m--;
            int ms = m % 10;
            int s = (m % 600 - ms) / 10;
            int sg = s % 10;
            int ss = s / 10;
            int ming = (m / 600) % 10;
            int mins = (m / 600) / 10;
            textBox1.Text = mins.ToString();
            textBox2.Text = ming.ToString();
            textBox3.Text = ss.ToString();
            textBox4.Text = sg.ToString();
            double mj = Convert.ToDouble(m);
            ucProcessExt1.Value = Convert.ToInt32((mj / allt) * 100);
            windowsTaskbar.SetProgressValue(ucProcessExt1.Value, 100, this.Handle);
        }
        private void ucExt9_Click(object sender, EventArgs e)
        {
            allt = textBox1.Text.ToInt() * 6000 + textBox2.Text.ToInt() * 600 + textBox3.Text.ToInt() * 100 + textBox4.Text.ToInt() * 10;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            if (ucExt9.Text == "开始")
            {
                timer1.Start();
                ucExt9.Text = "暂停";
            }
            else
            {
                timer1.Stop();
                ucExt9.Text = "开始";
            }
        }

        private void ucExt10_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            ucExt9.Text = "开始";
        }

        private void Timer_Shown(object sender, EventArgs e) => windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, this.Handle);

        private void frmTimer_Load(object sender, EventArgs e)
        {

        }
    }
    public static class Extensions
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}
