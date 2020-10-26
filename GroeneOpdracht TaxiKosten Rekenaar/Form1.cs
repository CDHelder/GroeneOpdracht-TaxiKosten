using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace GroeneOpdracht_TaxiKosten_Rekenaar
{
    public partial class Form1 : Form
    {
        int timerHours, timerMins, timerSecs, timerMiniSecs;
        bool isActive;

        public Form1()
        {
            InitializeComponent();

            ResetTime();

            isActive = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm");
            timeNow.Text = clock;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timerMiniSecs++;

                if (timerMiniSecs >= 100)
                {
                    timerSecs++;
                    timerMiniSecs = 0;

                    if (timerSecs >= 60)
                    {
                        timerMins++;
                        timerSecs = 00;
                        if (timerMins >= 60)
                        {
                            timerHours++;
                            timerMins = 00;
                            if (timerHours >= 24)
                            {
                                timerHours = 00;
                            }
                        }
                    }
                }
            }
            TimerToText();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            isActive = true;
            ChangeColorToRed();
        }

        private void From1_Load(object sender, EventArgs e)
        {
            ResetTime();
            isActive = false;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            isActive = false;
            ChangeColorToSnow();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
            ChangeColorToSnow();

        }
        private void ResetTime()
        {
            timerHours = 00;
            timerMins = 00;
            timerSecs = 00;
            timerMiniSecs = 0;
        }
        private void ChangeColorToRed()
        {
            timerHour.ForeColor = System.Drawing.Color.Red;
            timerMin.ForeColor = System.Drawing.Color.Red;
            timerSec.ForeColor = System.Drawing.Color.Red;
        }
        private void ChangeColorToSnow()
        {
            timerHour.ForeColor = System.Drawing.Color.Snow;
            timerMin.ForeColor = System.Drawing.Color.Snow;
            timerSec.ForeColor = System.Drawing.Color.Snow;
        }
        private void TimerToText()
        {
            timerHour.Text = timerHours.ToString();
            timerMin.Text = timerMins.ToString();
            timerSec.Text = timerSecs.ToString();
        }
    }
}
