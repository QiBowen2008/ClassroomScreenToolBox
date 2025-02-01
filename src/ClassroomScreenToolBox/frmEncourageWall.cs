using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{
    public partial class frmEncourageWall : Form
    {
        public frmEncourageWall()
        {
            InitializeComponent();
        }

        private void Hurryup_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DayMatterOpen == true)
            {
                label1.Text = "今天距离" + Properties.Settings.Default.DayMatterEventLib + "还有" + Properties.Settings.Default.DayMatterTime + "天";
            }
            else
            {
                label1.Text = "今天是" + DateTime.Now.ToLongDateString().ToString();    
            }
            label2.Text = Properties.Settings.Default.Saying;
            if(string .IsNullOrEmpty (label2 .Text))
            {
                label3.Text = "";
                label2.Text = "";
            }

            
        }
        public static string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }

        }
        public static string GetSaying()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://v.api.aa1.cn/api/api-wenan-mingrenmingyan/index.php?aa1=text");
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string unprocessresult = reader.ReadToEnd();
            int length = unprocessresult.Length;
            string result = unprocessresult.Substring(3, length - 7);
            return result;
        }

        private void ucExt1_Click(object sender, EventArgs e) => Close();
    }
}
