using OrionScreenOne.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeDRocket;

namespace OrionScreenOne
{
    public partial class Main : Form
    {

        _3DObject _3DObject = new _3DObject();
        Label labelA1 = new Label();
        Label labelA2 = new Label();
        Label TAltitude = new Label() { Text = "Altitude", Width = 150, BackColor = Color.Transparent };
        Label TPressure = new Label() { Text = "Pressure", Width = 150, BackColor = Color.Transparent };
        Label TSpeed = new Label() { Text = "Speed", Width = 200, BackColor = Color.Transparent };
        Label TMach = new Label() { Text = "Mach", Width = 200, BackColor = Color.Transparent };
        Label PAltitude = new Label() { Text = "Altitude", Width = 150, BackColor = Color.Transparent };
        Label PPressure = new Label() { Text = "Pressure", Width = 150, BackColor = Color.Transparent };
        Label PSpeed = new Label() { Text = "Speed", Width = 200, BackColor = Color.Transparent };
        Label PMach = new Label() { Text = "Mach", Width = 200, BackColor = Color.Transparent };
        UniversalGauge universalGaugeA1 = new UniversalGauge(15, 500, 10000); // Rocket Altitude 
        UniversalGauge universalGaugeA2 = new UniversalGauge(215, 500, 10); //Rocket Pressure
        UniversalGauge universalGaugeA3 = new UniversalGauge(15, 650, 2); // Rocket Mach
        UniversalGauge universalGaugeA4 = new UniversalGauge(215, 650, 1000); // Rocket Speed
        UniversalGauge universalGaugeA5 = new UniversalGauge(1150, 500, 10000); // Payload Altitude 
        UniversalGauge universalGaugeA6 = new UniversalGauge(1350, 500, 10); //Payload Pressure
        UniversalGauge universalGaugeA7 = new UniversalGauge(1150, 650, 2); // Payload Mach
        UniversalGauge universalGaugeA8 = new UniversalGauge(1350, 650, 1000); // Payload Speed
        TimeLine TimeLine = new TimeLine();
        public Main()
        {
            InitializeComponent();
            CreateView();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void CreateView()
        {

            var fontFamily = new Font(FontFamily.GenericMonospace, 16, FontStyle.Regular);
            //Set TimeLine
            TimeLineOrion.Child = TimeLine;
            TimeLineOrion.BackColor = Color.Transparent;
            TimeLineOrion.Width = 900;
            TimeLineOrion.Height = 80;
            TimeLineOrion.Location = new Point(350,800);

            //Set Axis Infos
            Three3D.BackColor = Color.Transparent;
            Three3D.Location = new Point(50, 30);
            Three3D.Height = 350;
            Three3D.Width = 350;
            Three3D.Child = _3DObject;

            //Added Telemetry Text
            labelA1.Text = "ROCKET TELEMETRY\nINFORMATION";
            labelA1.BackColor = Color.Transparent;
            labelA1.Height = 100;
            labelA1.Width = 400;
            labelA1.Font = new Font(FontFamily.GenericSansSerif, 22, FontStyle.Bold);
            labelA1.TextAlign = ContentAlignment.MiddleCenter;
            labelA1.ForeColor = Color.FromArgb(255, 154, 127, 196);
            labelA1.Location = new Point(15,400);
            this.Controls.Add(labelA1);

            //Added Payload Text
            labelA2.Text = "PAYLOAD TELEMETRY\nINFORMATION";
            labelA2.BackColor = Color.Transparent;
            labelA2.Height = 100;
            labelA2.Width = 400;
            labelA2.Font = new Font(FontFamily.GenericSansSerif, 22, FontStyle.Bold);
            labelA2.TextAlign = ContentAlignment.MiddleCenter;
            labelA2.ForeColor = Color.FromArgb(255, 154, 127, 196);
            labelA2.Location = new Point(1150, 400);
            this.Controls.Add(labelA2);

            //Added  Payload Info
            PAltitude.Location = new Point(1200, 600);
            PAltitude.Font = fontFamily;
            PPressure.Location = new Point(1400, 600);
            PPressure.Font = fontFamily;
            PMach.Location = new Point(1220, 750);
            PMach.Font = fontFamily;
            PSpeed.Location = new Point(1415, 750);
            PSpeed.Font = fontFamily;
            PAltitude.ForeColor = Color.FromArgb(255, 255, 255, 255);
            PPressure.ForeColor = Color.FromArgb(255, 255, 255, 255);
            PMach.ForeColor = Color.FromArgb(255, 255, 255, 255);
            PSpeed.ForeColor = Color.FromArgb(255, 255, 255,255);
            this.Controls.Add(PAltitude);
            this.Controls.Add(PPressure);
            this.Controls.Add(PMach);
            this.Controls.Add(PSpeed);
            this.Controls.Add(universalGaugeA5);
            this.Controls.Add(universalGaugeA6);
            this.Controls.Add(universalGaugeA7);
            this.Controls.Add(universalGaugeA8);
            // Added Telemetry Info

            TAltitude.Location = new Point(60, 600);
            TAltitude.Font = fontFamily;
            TPressure.Location = new Point(260, 600);
            TPressure.Font = fontFamily;
            TMach.Location = new Point(80, 750);
            TMach.Font = fontFamily;
            TSpeed.Location = new Point(280, 750);
            TSpeed.Font = fontFamily;
            TAltitude.ForeColor = Color.FromArgb(255, 255, 255, 255);
            TPressure.ForeColor = Color.FromArgb(255, 255, 255, 255);
            TMach.ForeColor = Color.FromArgb(255, 255, 255, 255);
            TSpeed.ForeColor = Color.FromArgb(255, 255, 255, 255);
            this.Controls.Add(TAltitude);
            this.Controls.Add(TPressure);
            this.Controls.Add(TMach);
            this.Controls.Add(TSpeed);
            this.Controls.Add(universalGaugeA1);
            this.Controls.Add(universalGaugeA2);
            this.Controls.Add(universalGaugeA3);
            this.Controls.Add(universalGaugeA4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 100;
            timer.Start();
            //ThreeDObjects.Run();


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeLine.Timer_Elapsed(null, null);
            _3DObject.TranformX(1);
            //_3DObject.TranformY(1);
            //_3DObject.TranformZ(1);
            Random random = new Random();
            universalGaugeA1.Value = random.Next(20, 10000);
            universalGaugeA2.Value = random.Next(0, 10)+Convert.ToDouble(random.NextDouble().ToString().Substring(0,4));
            universalGaugeA3.Value = Convert.ToDouble(random.NextDouble().ToString().Substring(0, 4));
            universalGaugeA4.Value = random.Next(20, 1000);
            universalGaugeA5.Value = random.Next(20, 10000);
            universalGaugeA6.Value = random.Next(0, 10) + Convert.ToDouble(random.NextDouble().ToString().Substring(0, 4));
            universalGaugeA7.Value = Convert.ToDouble(random.NextDouble().ToString().Substring(0, 4));
            universalGaugeA8.Value = random.Next(20, 1000);
        }
    }
}
