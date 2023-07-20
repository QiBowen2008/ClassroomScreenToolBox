using HZH_Controls;
using System;
using System.Media;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{

    public partial class Timer : Sunny.UI.UIForm
    {
        private TaskbarManager windowsTaskbar = TaskbarManager.Instance;
        private JumpList childWindowJumpList;
        private string childWindowAppId;
        public static int item = 0;
        public static int t = 0;
        public static bool timerstate = false;
        public static double allt = 0;
        public Timer()
        {
            InitializeComponent();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
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

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
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

        private void ucBtnExt3_BtnClick(object sender, EventArgs e)
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

        private void ucBtnExt4_BtnClick(object sender, EventArgs e)
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

        private void TextChange(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void ucBtnExt8_BtnClick(object sender, EventArgs e)
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

        private void ucBtnExt7_BtnClick(object sender, EventArgs e)
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

        private void ucBtnExt6_BtnClick(object sender, EventArgs e)
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

        private void ucBtnExt5_BtnClick(object sender, EventArgs e)
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

        private void ucBtnExt12_BtnClick(object sender, EventArgs e)
        {
            if (ucBtnExt12.BtnText == "开始")
            {
                ucBtnExt12.BtnText = "暂停";
                timer2.Enabled = true;
                timer2.Start();
            }
            else
            {
                ucBtnExt12.BtnText = "开始";
                timer2.Enabled = false;
                timer2.Stop();
            }
        }

        private void Tick(object sender, EventArgs e)
        {

            t++;
            int ms = t % 10;
            int s = (t % 600 - ms) / 10;
            int min = (t % 36000 - 10 * s - ms) / 600;
            int h = t / 36000;
            label2.Text = h.ToString() + ":" + min.ToString() + ":" + s.ToString() + "." + ms.ToString();
        }
        private void ucBtnExt11_BtnClick(object sender, EventArgs e)
        {
            timer2.Stop();


            label2.Text = "00:00:00.0";
        }

        private void ucBtnExt13_BtnClick(object sender, EventArgs e)
        {
            item++;
            int index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = item;
            dataGridView1.Rows[index].Cells[1].Value = label2.Text;
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
            double mj = m.ToDouble();
            ucProcessExt1.Value = ((mj / allt) * 100).ToInt();
            windowsTaskbar.SetProgressValue(ucProcessExt1.Value, 100, this.Handle);
        }
        SoundPlayer p = new SoundPlayer();
        private void ucBtnExt9_BtnClick(object sender, EventArgs e)
        {
            allt = textBox1.Text.ToInt() * 6000 + textBox2.Text.ToInt() * 600 + textBox3.Text.ToInt() * 100 + textBox4.Text.ToInt() * 10;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            if (ucBtnExt9.BtnText == "开始")
            {
                timer1.Start();
                ucBtnExt9.BtnText = "暂停";
                try
                {
                    if (Properties.Settings.Default.TimerWave == true)
                    {
                        p.SoundLocation = Application.StartupPath + "//" + Properties.Settings.Default.TimerWaveFile;
                        p.Load();
                        p.Play();
                    }
                }
                catch
                {

                }
            }
            else
            {
                timer1.Stop();
                p.Stop();
                ucBtnExt9.BtnText = "开始";
            }
        }

        private void ucBtnExt10_BtnClick(object sender, EventArgs e)
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
            ucBtnExt9.BtnText = "开始";
            p.Stop();
            p.Dispose();
        }

        private void Timer_Shown(object sender, EventArgs e) => windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, this.Handle);
    }
}
