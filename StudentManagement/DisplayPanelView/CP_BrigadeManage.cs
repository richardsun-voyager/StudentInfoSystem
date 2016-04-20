using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CP_BrigadeManage : UserControl
    {
        public CP_BrigadeManage()
        {
            InitializeComponent();
        }

        private void CP_BrigadeManageLoad(object sender, EventArgs e)
        {
             DayOfWeek dayOfWeek= DateTime.Today.DayOfWeek;
        }


    }
}
