using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{
	public partial class frmCalcPKSet : Sunny .UI.UIForm2 

	{
		public frmCalcPKSet()
		{
			InitializeComponent();
		}
		public static int point;
        private void Button1Click(object sender, EventArgs e)
{
    try
    {
        // 设置 data.fangshi
        if (radioButton1.Checked)
        {
            data.fangshi = 1;
        }
        else if (radioButton9.Checked)
        {
            data.fangshi = 3;
        }
        else
        {
            data.fangshi = 2;
        }

        // 设置 data.weishu
        if (radioButton3.Checked)
        {
            data.weishu = 1;
        }
        else if (radioButton4.Checked)
        {
            data.weishu = 2;
        }
        else if (radioButton5.Checked)
        {
            data.weishu = 3;
        }

        // 设置 data.suanfa
        if (radioButton6.Checked)
        {
            data.suanfa = 1;
        }
        else if (radioButton7.Checked)
        {
            data.suanfa = 2;
        }
        else if (radioButton8.Checked)
        {
            data.suanfa = 3;
        }

        // 设置 data.min, data.sec, data.count 并添加异常处理
        data.min = Convert.ToInt32(numericUpDown1.Value);
        data.sec = Convert.ToInt32(numericUpDown3.Value);
        data.count = Convert.ToInt32(numericUpDown2.Value);

        // 打开新窗口
        frmCalcPK frmc = new frmCalcPK();
        frmc.Show();
    }
    catch (Exception ex)
    {
        MessageBox.Show("发生错误: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
		

        private void frmCalcPKSet_Load(object sender, EventArgs e)
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
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * scaleFactor, control.Font.Style);
            }
            Height = (int)(Height * scaleFactor);
            Width = (int)(Width * scaleFactor);
            titleHeight = Convert.ToInt32(titleHeight * scaleFactor);
            titleFont = new Font(titleFont.FontFamily, titleFont.Size * scaleFactor, titleFont.Style);
        }
    }
}
