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
        UniversalGauge universalGaugeA1 = new UniversalGauge(15, 500);
        UniversalGauge universalGaugeA2 = new UniversalGauge(215, 500);
        UniversalGauge universalGaugeA3 = new UniversalGauge(15, 650);
        UniversalGauge universalGaugeA4 = new UniversalGauge(215, 650);
        public Main()
        {
            CreateTestData();
            InitializeComponent();
            CreateView();
        }
        private void CreateView()
        {
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
            this.Controls.Add(universalGaugeA1);
            this.Controls.Add(universalGaugeA2);
            this.Controls.Add(universalGaugeA3);
            this.Controls.Add(universalGaugeA4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            timer.Start();
            //ThreeDObjects.Run();


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            switch(testValue[forValue].Item1)
            {
                case "x":
                    {
                        _3DObject.TranformX(testValue[forValue].Item2);
                        break;
                    }
                case "y":
                    {
                        _3DObject.TranformY(testValue[forValue].Item2);
                        break;
                    }
                case "z":
                    {
                        _3DObject.TranformZ(testValue[forValue].Item2);
                        break;
                    }
            }
            switch (testValue[forValue+1].Item1)
            {
                case "x":
                    {
                        _3DObject.TranformX(testValue[forValue+1].Item2);
                        break;
                    }
                case "y":
                    {
                        _3DObject.TranformY(testValue[forValue+1].Item2);
                        break;
                    }
                case "z":
                    {
                        _3DObject.TranformZ(testValue[forValue+1].Item2);
                        break;
                    }
            }
            switch (testValue[forValue+2].Item1)
            {
                case "x":
                    {
                        _3DObject.TranformX(testValue[forValue+2].Item2);
                        break;
                    }
                case "y":
                    {
                        _3DObject.TranformY(testValue[forValue+2].Item2);
                        break;
                    }
                case "z":
                    {
                        _3DObject.TranformZ(testValue[forValue+2].Item2);
                        break;
                    }
            }
            Random random = new Random();
            universalGaugeA1.Value = random.Next(20, 100);
            universalGaugeA2.Value = random.Next(20, 100);
            universalGaugeA3.Value = random.Next(20, 100);
            universalGaugeA4.Value = random.Next(20, 100);
            forValue+=3;
        }
    }
}
