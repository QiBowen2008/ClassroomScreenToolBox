using IWshRuntimeLibrary;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{
    public partial class Set : Sunny.UI.UIForm
    {
        public Set()
        {
            InitializeComponent();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e) => Close();
        private void Set_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.AutoStart == "False")
            {
                ucRadioButton3.Checked = true;
            }
            else if (Properties.Settings.Default.AutoStart == "Icon")
            {
                ucRadioButton4.Checked = true;
            }
            else if (Properties.Settings.Default.AutoStart == "Hurry")
            {
                ucRadioButton5.Checked = true;
            }
            string[] data = Properties.Settings.Default.DayMatterEventLib.Cast<string>().ToArray<string>();
            comboBox6.Items.AddRange(data);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucCheckBox3_CheckedChangeEvent(object sender, EventArgs e) => Properties.Settings.Default.AutoShutdownMsg = ucCheckBox3.Checked;

        private void ucBtnExt3_BtnClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            comboBox5.Text = openFileDialog1.FileName;
            if (openFileDialog1.FileNames.Count() > 1)
            {
                MessageBox.Show("您选择的文件已经添加到列表框中");
            }
            comboBox5.Items.Add(openFileDialog1.FileNames);
        }

        private void ucBtnExt4_BtnClick(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ucBtnExt4.FillColor = colorDialog1.Color;
            ucBtnExt4.RectColor = colorDialog1.Color;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            if (ucRadioButton3.Checked == true)
            {
                Properties.Settings.Default.AutoStart = "False";
            }
            else if (ucRadioButton4.Checked == true)
            {
                Properties.Settings.Default.AutoStart = "Icon";
            }
            else if (ucRadioButton5.Checked == true)
            {
                Properties.Settings.Default.AutoStart = "Hurry";
            }

            Properties.Settings.Default.StopWatchWave = ucCheckBox6.Checked;
            Properties.Settings.Default.TimerWave = ucRadioButton2.Checked;
            Properties.Settings.Default.TimerWaveFile = comboBox5.Text;
            Properties.Settings.Default.DayMatterOpen = ucCheckBox8.Checked;
            Properties.Settings.Default.TimerColorRGB = colorDialog1.Color;
            Properties.Settings.Default.AutoShutdownMsgTime = comboBox3.Text;
            Properties.Settings.Default.DayMatterEventLib.Clear();
            foreach (string aa in comboBox6.Items)
            {
                Properties.Settings.Default.DayMatterEventLib.Add(aa);
            }
            Properties.Settings.Default.AutoShutdownPinlv = comboBox4.Text;
            Properties.Settings.Default.Save();
            if (ucBtnExt3.Enabled == true && comboBox5.Text == "")
            {
                MessageBox.Show("文件名为空");
            }
            if (ucRadioButton4.Checked == true)
            {
                AutoStart.Instance.QuickDescribe = "软件描述";
                //设置快捷方式的名称
                AutoStart.Instance.QuickName = "教师多媒体屏幕工具箱";
                //设置自启动的窗口类型，后台服务类的软件可以设置为最小窗口
                AutoStart.Instance.WindowStyle = WshWindowStyle.WshMinimizedFocus;

                //快捷方式设置true时，有就忽略、没有就创建，自启动快捷方式只能存在一个
                //设置开机自启动，true 自启动，false 不自启动
                AutoStart.Instance.SetAutoStart(true);
                //设置桌面快捷方式，true 创建桌面快捷方式（有就跳过，没有就创建），false 删除桌面快捷方式
                AutoStart.Instance.SetDesktopQuick(true);
            }
            Close();
        }

        private void ucCheckBox1_CheckedChangeEvent(object sender, EventArgs e) => Properties.Settings.Default.AutoShutdown = ucCheckBox1.Checked;

        private void ucCheckBox2_CheckedChangeEvent(object sender, EventArgs e) => Properties.Settings.Default.AutoIcon = ucCheckBox2.Checked;

        private void ucCheckBox5_CheckedChangeEvent(object sender, EventArgs e) => Properties.Settings.Default.TimerRing = ucCheckBox5.Checked;

        private void ucCheckBox4_CheckedChangeEvent(object sender, EventArgs e)
        {
            Properties.Settings.Default.TimerColor = ucCheckBox4.Checked;
            if (ucCheckBox4.Checked == true)
            {
                ucBtnExt4.Enabled = true;
            }
        }
    }
}
