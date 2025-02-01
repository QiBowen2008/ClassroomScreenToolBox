using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{
	public partial class frmCalcPK :Sunny .UI.UIForm2
	{
		public frmCalcPK()
		{
			InitializeComponent();
		}
		public  static int tcount=0;
		public static int t=0;
        private DateTime startTime; // 记录开始时间
        private TimeSpan elapsedTime; // 记录经过的时间
        private bool isRunning = false; // 记录秒表是否正在运行
        private void Tick(object sender, EventArgs e)
        {

            // 计算经过的时间
            elapsedTime = DateTime.Now - startTime;
            // 更新 Label 显示
            lblTimer.Text = elapsedTime.ToString(@"hh\:mm\:ss\.ff");
        }
        void FrmChallengeLoad(object sender, EventArgs e)
		{
			ChangeNumber();
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
			if(data.fangshi == 2||data .fangshi ==3)
			{
                startTime = DateTime.Now - elapsedTime; // 设置开始时间
                timer2.Enabled = true;
                timer2.Start();
				if(data.fangshi == 2)
				{
					label9.Text = "共" + data.count + "题";
                }
            }
			else if(data.fangshi == 1)
			{
                lblTimer.Text = ts.ToString(@"hh\:mm\:ss\.ff");
				timer3.Start();
                startTime = DateTime.Now - elapsedTime; // 设置开始时间
            }
        }
        TimeSpan ts = new TimeSpan(days: 0, hours: 0, minutes: data.min, seconds: data.sec, milliseconds: 0);

        public static int point;
        private void NumberButton_Click(object sender, EventArgs e)
        {
           Sunny .UI . UIButton button = sender as Sunny .UI.UIButton;
            if (button != null)
            {
                textBox1 .Text += button.Text; // 将按钮的文本追加到文本框中
            }
        }
        void ChangeNumber()
		{
			Random random = new Random();
			if(data .weishu ==1)
			{
				label1 .Text =random .Next (1,10).ToString();
				label3 .Text =random .Next (1,10).ToString();
			}
			else if(data .weishu ==2 )
			{
				label1 .Text =random .Next (10,100).ToString();
				label3 .Text =random .Next (10,100).ToString();
			}
			else if(data .weishu ==3 )
			{
				label1 .Text =random .Next (100,1000).ToString();
				label3 .Text =random .Next (100,1000).ToString();
			}
			if(data .suanfa == 1)
			{
				int a= random .Next (1,3);
				if(a==1)
					label2 .Text ="+";
				if(a==2)
					label2 .Text ="-";
			}
			if(data .suanfa == 2)
			{
				int a= random .Next (1,3);
				if(a==1)
					label2 .Text ="x" ;
				if(a==2)
					label2 .Text ="÷";
			}
			if(data .suanfa == 3)
			{
				int a= random .Next (1,5);
				if(a==1)
					label2 .Text ="+";
				if(a==2)
					label2 .Text ="-";
				if(a==3)
					label2 .Text ="x" ;
				if(a==4)
					if(Convert .ToInt32 (label1 .Text )%Convert .ToInt32 (label3 .Text )==0)
						label2 .Text ="÷";
					else 
						label2 .Text ="+";
			}
			label10.Text = "第" + (tcount+1).ToString() + "题";
        }
		bool CheckRightWrong()
		{
			if(label2 .Text =="+")
			{
				if(Convert .ToInt32 ( textBox1 .Text )==Convert .ToInt32 (label1 .Text )+Convert .ToInt32 (label3 .Text )==true )
				{
					return true ;
				}
				else 
				{
					return false ;
				}
			}
			else if(label2 .Text =="-")
			{
				if(Convert .ToInt32 ( textBox1 .Text )==Convert .ToInt32 (label1 .Text )-Convert .ToInt32 (label3 .Text )==true )
				{
					return true ;
				}
				else 
				{
					return false ;
				}
			}
			else if(label2 .Text =="x")
			{
				if(Convert .ToInt32 ( textBox1 .Text )==Convert .ToInt32 (label1 .Text )*Convert .ToInt32 (label3 .Text )==true )
				{
					return true ;
				}
				else 
				{
					return false ;
				}
			}
			else if(label2 .Text =="÷")
			{
				if(Convert .ToInt32 ( textBox1 .Text )==Convert .ToInt32 (label1 .Text )/Convert .ToInt32 (label3 .Text )==true )
				{
					return true ;
				}
				else 
				{
					return false ;
				}
			}
			else {
				return true ;
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			try
			{
			tcount ++;
			bool result= CheckRightWrong();
			
			if(result ==true ){
				point ++;
				label8 .Text="回答正确";
			}
			else 
			{
				label8 .Text="回答错误";
				if(data.fangshi ==3)
				{
					GameOver ();
				}
			}
			if(data.fangshi ==2&& tcount == data.count)
                {
					GameOver ();
                }
			else
				{
					ChangeNumber();
				}
			label6 .Text =point .ToString ();
			}
			catch(Exception ex)
			{
				label8 .Text=ex.Message;
			}
			textBox1.Text = "";
		}
		void GameOver()
		{
			timer3.Stop();
			timer2.Stop();
			MessageBox .Show ("游戏结束，您的得分是"+point .ToString ()+"分");
			this.Close ();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			label8 .Text="";
		}

        private void uiButton11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1 .Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void uiButton12_Click(object sender, EventArgs e)
        {
			textBox1.Text = "";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - startTime;
			// 更新 Label 显示
			if ((ts - elapsedTime).Ticks > 0)
			{
				lblTimer.Text = (ts - elapsedTime).ToString(@"hh\:mm\:ss\.ff");
			}
			else
			{
				GameOver();
			}
        }
    }
}
