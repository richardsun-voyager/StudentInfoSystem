using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmSysConfig : Form
    {
        private bool TimerEnabled=false;
        private int interval=3600;
        public frmSysConfig()
        {
            InitializeComponent();
        }

        private void checkBoxTIMERENABLE_CheckedChanged(object sender, EventArgs e)
        {
            TimerEnabled = checkBoxTIMERENABLE.Checked;
        }
        public void SetTimer(Timer timer)
        {
            timer.Enabled = TimerEnabled;
            timer.Interval = interval;
        }

        private void comboBoxTIMEINTERVAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            interval = (comboBoxTIMEINTERVAL.SelectedIndex + 1) * 3600;
        }
    }
}