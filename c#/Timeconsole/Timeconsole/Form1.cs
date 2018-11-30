using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timeconsole
{
    public partial class Time_console : Form
    {
        public Time_console()
        {
            InitializeComponent();
        }

        private void timer_test_Tick(object sender, EventArgs e)
        {
            timer_test.Enabled = true;
            MessageBox.Show("hello world");
        }
    }
}
