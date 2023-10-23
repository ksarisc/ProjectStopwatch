using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectStopwatch
{
    public partial class ProjectTimer : UserControl
    {
        private readonly System.Threading.Timer timer;
        private readonly Action<string> updateTime;

        private bool running = false;
        private DateTime? start;

        public ProjectTimer()
        {
            InitializeComponent();
            timer = new System.Threading.Timer(Callback, null, System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            updateTime = new Action<string>(UpdateTime);
        }

        private void ProjectTimer_Load(object sender, EventArgs e)
        {

        }

        private void Callback(object state)
        {
            if (!running)
            {
                timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                return;
            }

            string value;
            if (start == null)
            {
                start = DateTime.Now;
                value = "00:00:00";
            }
            else
                value = DateTime.Now.Subtract(start.Value).ToString(@"hh\:mm\:ss");
            TimerBox.Invoke(updateTime, new object[] { value });
        }

        private void UpdateTime(string value)
        {
            TimerBox.Text = value;
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            running = true;
            timer.Change(1000, 1000);
        }
    }
}
