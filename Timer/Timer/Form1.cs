using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class FormTimer : Form
    {
        int endTime;
        int nowTime;
        public FormTimer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textSetTime.Text, out endTime))
            {
                endTime = 1;
            }
            nowTime = 0;

            timerControl.Start();
        }

        private void timerControl_Tick(object sender, EventArgs e)
        {
            int remainingTime;
            nowTime++;
            remainingTime = endTime - nowTime;
            textRemainingTime.Text = remainingTime.ToString();

            if (endTime == nowTime)
            {
                timerControl.Stop();
                MessageBox.Show("時間になりました！");
            }
            else
            {

            }
        }
    }
}
