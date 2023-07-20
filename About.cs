using System;
using System.Windows.Forms;

namespace ClassroomScreenToolBox
{
    public partial class About : Sunny.UI.UIForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e) => Close();

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
