using System;
using System.Windows.Forms;

namespace GroeneOpdracht_TaxiKosten_Rekenaar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private DateTime StartTime;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            Startknop.Text = timer1.Enabled ? "Stop" : "Start";
            StartTime = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            double milisecs = elapsed.TotalMilliseconds / 100;
            Text += elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":";

            label1.Text = Text;
        }
    }
}
