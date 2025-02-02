using IWshRuntimeLibrary;
using Sunny.UI;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{
    public partial class frmSet : UIForm2
    {
        public frmSet()
        {
            InitializeComponent();
        }

        private void ucExt1_Click(object sender, EventArgs e) => Close();
        private void Set_Load(object sender, EventArgs e)
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
                if (control is UITabControl tabControl)
                {
                    // 遍历TabControl中的所有TabPage
                    foreach (TabPage tabPage in tabControl.TabPages)
                    {
                        foreach (Control tabcontrol in tabPage.Controls)
                        {
                            tabcontrol.Width = (int)(tabcontrol.Width * scaleFactor);
                            tabcontrol.Height = (int)(tabcontrol.Height * scaleFactor);
                            tabcontrol.Left = (int)(tabcontrol.Left * scaleFactor);
                            tabcontrol.Top = (int)(tabcontrol.Top * scaleFactor);
                            tabcontrol.Font = new Font(tabcontrol.Font.FontFamily, tabcontrol.Font.SizeInPoints * scaleFactor, tabcontrol.Font.Style);
                        }
                    }
                }
            }
            if (Properties.Settings.Default.AutoStart == "False")
            {
                ucRadioButton3.Checked = true;
            }
            else if (Properties.Settings.Default.AutoStart == "Icon")
            {
                ucRadioButton4.Checked = true;
            }
            string[] data = Properties.Settings.Default.DayMatterEventLib.Cast<string>().ToArray<string>();
            comboBox6.Items.AddRange(data);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ucExt3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileNames.Count() > 1)
            {
                MessageBox.Show("您选择的文件已经添加到列表框中");
            }
        }

        private void ucExt4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucExt2_Click(object sender, EventArgs e)
        {
            if (ucRadioButton3.Checked == true)
            {
                Properties.Settings.Default.AutoStart = "False";
            }
            else if (ucRadioButton4.Checked == true)
            {
                Properties.Settings.Default.AutoStart = "Icon";
            }
            Properties.Settings.Default.DayMatterOpen = ucCheckBox8.Checked;
            Properties.Settings.Default.TimerColorRGB = colorDialog1.Color;
            Properties.Settings.Default.DayMatterEventLib.Clear();
            foreach (string aa in comboBox6.Items)
            {
                Properties.Settings.Default.DayMatterEventLib.Add(aa);
            }
            Properties.Settings.Default.Save();
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

    }
}
