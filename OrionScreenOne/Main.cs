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
        List<Tuple<string, int, int>> testValue = new List<Tuple<string, int, int>>();
        int forValue = 0;
        private void CreateTestData()
        {
            testValue.Add(new Tuple<string, int, int>("x", 1, 3));
            testValue.Add(new Tuple<string, int, int>("y", 0, 3));
            testValue.Add(new Tuple<string, int, int>("z", 0, 3));
            testValue.Add(new Tuple<string, int, int>("x", 1, 5));
            testValue.Add(new Tuple<string, int, int>("y", 1, 5));
            testValue.Add(new Tuple<string, int, int>("z", 1, 5));
            testValue.Add(new Tuple<string, int, int>("x", 1, 6));
            testValue.Add(new Tuple<string, int, int>("y", 1, 6));
            testValue.Add(new Tuple<string, int, int>("z", 1, 6));
            testValue.Add(new Tuple<string, int, int>("x", 1, 7));
            testValue.Add(new Tuple<string, int, int>("y", 1, 7));
            testValue.Add(new Tuple<string, int, int>("z", 1, 7));
            testValue.Add(new Tuple<string, int, int>("x", 1, 8));
            testValue.Add(new Tuple<string, int, int>("y", 1, 8));
            testValue.Add(new Tuple<string, int, int>("z", 1, 8));
            testValue.Add(new Tuple<string, int, int>("x", 1, 9));
            testValue.Add(new Tuple<string, int, int>("y", 1, 9));
            testValue.Add(new Tuple<string, int, int>("z", 1, 9));
            testValue.Add(new Tuple<string, int, int>("x", 1, 10));
            testValue.Add(new Tuple<string, int, int>("y", 1, 10));
            testValue.Add(new Tuple<string, int, int>("z", 1, 10));
            testValue.Add(new Tuple<string, int, int>("x", 1, 11));
            testValue.Add(new Tuple<string, int, int>("y", 1, 11));
            testValue.Add(new Tuple<string, int, int>("z", 1, 11));
            testValue.Add(new Tuple<string, int, int>("x", 1, 12));
            testValue.Add(new Tuple<string, int, int>("y", 1, 12));
            testValue.Add(new Tuple<string, int, int>("z", 1, 12));
            testValue.Add(new Tuple<string, int, int>("x", 1, 13));
            testValue.Add(new Tuple<string, int, int>("y", 1, 13));
            testValue.Add(new Tuple<string, int, int>("z", 1, 13));
            testValue.Add(new Tuple<string, int, int>("x", 1, 14));
            testValue.Add(new Tuple<string, int, int>("y", 1, 14));
            testValue.Add(new Tuple<string, int, int>("z", 1, 14));
            testValue.Add(new Tuple<string, int, int>("x", 1, 15));
            testValue.Add(new Tuple<string, int, int>("y", 1, 15));
            testValue.Add(new Tuple<string, int, int>("z", 1, 15));
            testValue.Add(new Tuple<string, int, int>("x", 1, 16));
            testValue.Add(new Tuple<string, int, int>("y", 1, 16));
            testValue.Add(new Tuple<string, int, int>("z", 1, 16));
            testValue.Add(new Tuple<string, int, int>("x", 1, 17));
            testValue.Add(new Tuple<string, int, int>("y", 1, 17));
            testValue.Add(new Tuple<string, int, int>("z", 1, 17));
            testValue.Add(new Tuple<string, int, int>("x", 1, 18));
            testValue.Add(new Tuple<string, int, int>("y", 1, 18));
            testValue.Add(new Tuple<string, int, int>("z", 1, 18));
            testValue.Add(new Tuple<string, int, int>("x", 1, 19));
            testValue.Add(new Tuple<string, int, int>("y", 1, 19));
            testValue.Add(new Tuple<string, int, int>("z", 1, 19));
            testValue.Add(new Tuple<string, int, int>("x", 1, 20));
            testValue.Add(new Tuple<string, int, int>("y", 1, 20));
            testValue.Add(new Tuple<string, int, int>("z", 1, 20));
            testValue.Add(new Tuple<string, int, int>("x", 1, 21));
            testValue.Add(new Tuple<string, int, int>("y", 1, 21));
            testValue.Add(new Tuple<string, int, int>("z", 1, 21));
            testValue.Add(new Tuple<string, int, int>("x", 1, 22));
            testValue.Add(new Tuple<string, int, int>("y", 1, 22));
            testValue.Add(new Tuple<string, int, int>("z", 1, 22));
        }






        _3DObject _3DObject = new _3DObject();
        Label labelA1 = new Label();
        UniversalGauge universalGaugeA1 = new UniversalGauge(15, 500, 10000); // Rocket Altitude 
        Label Altitude = new Label() { Text = "Altitude", Width = 150, BackColor = Color.Transparent };
        UniversalGauge universalGaugeA2 = new UniversalGauge(215, 500, 10); //Rocket Pressure
        Label Pressure = new Label() { Text = "Pressure", Width = 150, BackColor = Color.Transparent };
        UniversalGauge universalGaugeA3 = new UniversalGauge(15, 650, 2); // Rocket Mach
        Label Mach = new Label() { Text = "Mach", Width = 200, BackColor = Color.Transparent };
        UniversalGauge universalGaugeA4 = new UniversalGauge(215, 650, 1000); // Rocket Speed
        Label Speed = new Label() { Text = "Speed", Width = 200, BackColor = Color.Transparent };
        UniversalGauge universalGaugeA5 = new UniversalGauge(215, 650, 100);
        UniversalGauge universalGaugeA6 = new UniversalGauge(215, 650, 10);
        UniversalGauge universalGaugeA7 = new UniversalGauge(215, 650, 10000);
        UniversalGauge universalGaugeA8 = new UniversalGauge(215, 650, 100);
        TimeLine TimeLine = new TimeLine();
        public Main()
        {
            CreateTestData();
            InitializeComponent();
            CreateView();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void CreateView()
        {
            //Set TimeLine
            TimeLineOrion.Child = TimeLine;
            TimeLineOrion.BackColor = Color.Transparent;
            TimeLineOrion.Width = 900;
            TimeLineOrion.Height = 80;
            TimeLineOrion.Location = new Point(350,750);

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

            // Added Telemetry Info
            var fontFamily = new Font(FontFamily.GenericMonospace, 16, FontStyle.Regular);
            Altitude.Location = new Point(60, 600);
            Altitude.Font = fontFamily;
            Pressure.Location = new Point(260, 600);
            Pressure.Font = fontFamily;
            Mach.Location = new Point(80, 750);
            Mach.Font = fontFamily;
            Speed.Location = new Point(280, 750);
            Speed.Font = fontFamily;
            this.Controls.Add(Altitude);
            this.Controls.Add(Pressure);
            this.Controls.Add(Mach);
            this.Controls.Add(Speed);
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
            _3DObject.TranformY(1);
            _3DObject.TranformZ(1);
            Random random = new Random();
            universalGaugeA1.Value = random.Next(20, 10000);
            universalGaugeA2.Value = random.Next(0, 10)+Convert.ToDouble(random.NextDouble().ToString().Substring(0,4));
            universalGaugeA3.Value = Convert.ToDouble(random.NextDouble().ToString().Substring(0, 4));
            universalGaugeA4.Value = random.Next(20, 1000);
            forValue+=3;
        }
    }
}
