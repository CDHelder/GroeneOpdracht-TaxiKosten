namespace GroeneOpdracht_TaxiKosten_Rekenaar
{
    partial class totaleBedrag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeNow = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelDag = new System.Windows.Forms.Label();
            this.Startknop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tijdInMin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weekendToeslag = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerHour = new System.Windows.Forms.Label();
            this.timerMin = new System.Windows.Forms.Label();
            this.timerSec = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.geredenKm = new System.Windows.Forms.TextBox();
            this.labelTotaal = new System.Windows.Forms.Label();
            this.Totaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeNow
            // 
            this.timeNow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNow.ForeColor = System.Drawing.Color.Snow;
            this.timeNow.Location = new System.Drawing.Point(12, 9);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(315, 121);
            this.timeNow.TabIndex = 0;
            this.timeNow.Text = "00:00";
            this.timeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.ForeColor = System.Drawing.Color.Snow;
            this.labelDatum.Location = new System.Drawing.Point(371, 30);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(378, 75);
            this.labelDatum.TabIndex = 1;
            this.labelDatum.Text = "28-10-2020";
            this.labelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDag
            // 
            this.labelDag.AutoSize = true;
            this.labelDag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDag.ForeColor = System.Drawing.Color.Snow;
            this.labelDag.Location = new System.Drawing.Point(411, 105);
            this.labelDag.Name = "labelDag";
            this.labelDag.Size = new System.Drawing.Size(297, 55);
            this.labelDag.TabIndex = 2;
            this.labelDag.Text = "Wednesday";
            this.labelDag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Startknop
            // 
            this.Startknop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startknop.Location = new System.Drawing.Point(387, 273);
            this.Startknop.Name = "Startknop";
            this.Startknop.Size = new System.Drawing.Size(109, 47);
            this.Startknop.TabIndex = 3;
            this.Startknop.Text = "Start";
            this.Startknop.UseVisualStyleBackColor = true;
            this.Startknop.Click += new System.EventHandler(this.Start_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(502, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Stop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(146, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Aantal Km:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(78, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = "Aantal minuten:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tijdInMin
            // 
            this.tijdInMin.AutoSize = true;
            this.tijdInMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tijdInMin.ForeColor = System.Drawing.Color.Snow;
            this.tijdInMin.Location = new System.Drawing.Point(315, 170);
            this.tijdInMin.Name = "tijdInMin";
            this.tijdInMin.Size = new System.Drawing.Size(0, 32);
            this.tijdInMin.TabIndex = 8;
            this.tijdInMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(41, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 33);
            this.label8.TabIndex = 9;
            this.label8.Text = "Weekend toeslag?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weekendToeslag
            // 
            this.weekendToeslag.AutoSize = true;
            this.weekendToeslag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekendToeslag.ForeColor = System.Drawing.Color.Snow;
            this.weekendToeslag.Location = new System.Drawing.Point(315, 203);
            this.weekendToeslag.Name = "weekendToeslag";
            this.weekendToeslag.Size = new System.Drawing.Size(0, 32);
            this.weekendToeslag.TabIndex = 10;
            this.weekendToeslag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(617, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerHour
            // 
            this.timerHour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerHour.ForeColor = System.Drawing.Color.Snow;
            this.timerHour.Location = new System.Drawing.Point(408, 160);
            this.timerHour.Name = "timerHour";
            this.timerHour.Size = new System.Drawing.Size(111, 109);
            this.timerHour.TabIndex = 12;
            this.timerHour.Text = "0";
            this.timerHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMin
            // 
            this.timerMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerMin.ForeColor = System.Drawing.Color.Snow;
            this.timerMin.Location = new System.Drawing.Point(500, 161);
            this.timerMin.Name = "timerMin";
            this.timerMin.Size = new System.Drawing.Size(111, 109);
            this.timerMin.TabIndex = 13;
            this.timerMin.Text = "0";
            this.timerMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSec
            // 
            this.timerSec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerSec.ForeColor = System.Drawing.Color.Snow;
            this.timerSec.Location = new System.Drawing.Point(597, 161);
            this.timerSec.Name = "timerSec";
            this.timerSec.Size = new System.Drawing.Size(111, 109);
            this.timerSec.TabIndex = 14;
            this.timerSec.Text = "0";
            this.timerSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // geredenKm
            // 
            this.geredenKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geredenKm.Location = new System.Drawing.Point(321, 136);
            this.geredenKm.Multiline = true;
            this.geredenKm.Name = "geredenKm";
            this.geredenKm.Size = new System.Drawing.Size(51, 31);
            this.geredenKm.TabIndex = 15;
            this.geredenKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.geredenKm.TextChanged += new System.EventHandler(this.geredenKm_TextChanged);
            this.geredenKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.geredenKm_KeyPress);
            // 
            // labelTotaal
            // 
            this.labelTotaal.AutoSize = true;
            this.labelTotaal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotaal.ForeColor = System.Drawing.Color.Snow;
            this.labelTotaal.Location = new System.Drawing.Point(41, 287);
            this.labelTotaal.Name = "labelTotaal";
            this.labelTotaal.Size = new System.Drawing.Size(136, 33);
            this.labelTotaal.TabIndex = 16;
            this.labelTotaal.Text = "Totaal: €";
            this.labelTotaal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Totaal
            // 
            this.Totaal.AutoSize = true;
            this.Totaal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaal.ForeColor = System.Drawing.Color.Snow;
            this.Totaal.Location = new System.Drawing.Point(166, 284);
            this.Totaal.Name = "Totaal";
            this.Totaal.Size = new System.Drawing.Size(0, 37);
            this.Totaal.TabIndex = 17;
            this.Totaal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totaleBedrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(761, 345);
            this.Controls.Add(this.Totaal);
            this.Controls.Add(this.labelTotaal);
            this.Controls.Add(this.geredenKm);
            this.Controls.Add(this.timerSec);
            this.Controls.Add(this.timerMin);
            this.Controls.Add(this.timerHour);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.weekendToeslag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tijdInMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Startknop);
            this.Controls.Add(this.labelDag);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.timeNow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "totaleBedrag";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.From1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelDag;
        private System.Windows.Forms.Button Startknop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tijdInMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label weekendToeslag;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerHour;
        private System.Windows.Forms.Label timerMin;
        private System.Windows.Forms.Label timerSec;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox geredenKm;
        private System.Windows.Forms.Label labelTotaal;
        private System.Windows.Forms.Label Totaal;
    }
}

