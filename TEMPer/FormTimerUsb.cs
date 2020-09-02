using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEMPer
{
    public partial class Connect_USB_device : Form
    {
        int y=5;
        public Connect_USB_device()
        {
            InitializeComponent();
        }

        private void Task1()
        {
            Thread.Sleep(500);
            for (y = 5; y != 0; y -= 1)
            {
                Thread.Sleep(1000);
            }
            Thread.Sleep(1000);
            Invoke(new Action(delegate () { button1_Click(null, null); }));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataNemaFile.NumberOfFile = domainUpDown1.Text.ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer1.Start();
            timer1.Enabled = true;
            backgroundWorker1.DoWork += (obj, ea) => Task1();
            backgroundWorker1.RunWorkerAsync();
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
