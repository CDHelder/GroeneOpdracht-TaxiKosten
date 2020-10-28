using System;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GroeneOpdracht_TaxiKosten_Rekenaar
{
    public partial class totaleBedrag : Form
    {
        int timerHours, timerMins, timerSecs, timerMiniSecs;
        string YearMonthDayNumbers, TodayLabel;
        bool isActive;

        public totaleBedrag()
        {
            InitializeComponent();

            YearMonthDayNumbers = DateTime.Now.Year.ToString() + "-" 
            + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();

            labelDatum.Text = YearMonthDayNumbers;
            labelDag.Text = DateTime.Now.DayOfWeek.ToString();

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
            ResetCalc();
        }

        private void ResetTime()
        {
            timerHours = 00;
            timerMins = 00;
            timerSecs = 00;
            timerMiniSecs = 0;
        }

        private void geredenKm_TextChanged(object sender, EventArgs e)
        {
            //De berekening wordt pas gedaan als het aantal gereden Km is ingevoerd
            if (timerMiniSecs != 0)
            {

                //Berekening totale aantal minuten
                double SecsInMins = timerSecs / 60;
                SecsInMins = Math.Round(SecsInMins);
                int intSecsInMins = Convert.ToInt32(SecsInMins);

                int HoursInMins = timerHours * 60;

                int TotalMins = intSecsInMins + timerMins + HoursInMins;
                tijdInMin.Text = TotalMins.ToString();

                //Berekening bedrag van totale minuten + overdag of avondtijden overweging
                double bedragMins;
                if (timerHours >= 8 && timerHours <= 18)
                    bedragMins = TotalMins * 0.25;
                else
                    bedragMins = TotalMins * 0.45;


                //Kijken of weekendtoeslag relevant is
                bool weekendToeslagErbij;
                if ((((labelDag.Text == "Friday" && timerHours >= 22) ||
                    (labelDag.Text == "Saterday") ||
                    (labelDag.Text == "Sunday") ||
                    (labelDag.Text == "Monday" && timerHours <= 6))))
                {
                    weekendToeslag.Text = "Ja";
                    weekendToeslagErbij = true;
                }
                else
                {
                    weekendToeslag.Text = "Nee";
                    weekendToeslagErbij = false;
                }

                //Het totale bedrag berekenen
                double weekendToeslagBedrag;
                string geheleBedrag;
                if (weekendToeslagErbij == true)
                {
                    weekendToeslagBedrag = (bedragMins + Convert.ToDouble(geredenKm.Text) / 100) * 15;
                    geheleBedrag = bedragMins + geredenKm.Text + weekendToeslagBedrag;
                }
                else
                {
                    geheleBedrag = bedragMins + geredenKm.Text;
                }
                Totaal.Text = geheleBedrag.TrimStart('0');

            }
        }

        private void geredenKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Zorg ervoor dat Textbox alleen nummers toelaat
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
        private void ResetCalc()
        {
            geredenKm.Text = "";
            tijdInMin.Text = "";
            weekendToeslag.Text = "";
            Totaal.Text = "";
        }
    }
}
