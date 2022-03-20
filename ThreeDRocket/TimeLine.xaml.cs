using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ThreeDRocket.TimeLineModel;

namespace ThreeDRocket
{
    /// <summary>
    /// Interaction logic for TimeLine.xaml
    /// </summary>
    public partial class TimeLine : UserControl
    {
        Timer timer;
        public static int i = 0;
        GaugeViewModel obj;
        TimeLineModel model;
        public TimeLine()
        {
            InitializeComponent();
            obj = new GaugeViewModel();
            obj.Border = Rotate;
            this.DataContext = obj;
            model = new TimeLineModel();


            //timer = new Timer();
            //timer.Interval = 50;
            //timer.Elapsed += Timer_Elapsed;
            //timer.Start();

            obj.a1X = data[20].x;
            obj.a1Y = data[20].y;

            obj.a2X = data[80].x;
            obj.a2Y = data[80].y;

            obj.a5X = data[140].x;
            obj.a5Y = data[140].y;

            obj.a3X = data[240].x;
            obj.a3Y = data[240].y-2;

            obj.a4X = data[320].x;
            obj.a4Y = data[320].y-3;
            

            obj.a6X = data[410].x;
            obj.a6Y = data[410].y+5;

            obj.a7X = data[520].x;
            obj.a7Y = data[520].y;

            obj.a8X = data[650].x;
            obj.a8Y = data[650].y;
        }

        public void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                switch(i)
                {
                    case 20:
                        {
                            StartUp.Background = new SolidColorBrush(Color.FromRgb(0,255,0));
                            break;
                        }
                    case 80:
                        {
                            LiftOFF.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            break;
                        }
                    case 140:
                        {
                            Anonymous.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            break;
                        }
                    case 240:
                        {
                            Apogee.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            break;
                        }
                    case 320:
                        {
                            DragParachute.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            break;
                        }
                    case 410:
                        {
                            PayLoad.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            break;
                        }
                    case 520:
                        {
                            MainParachute.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            break;
                        }
                    case 650:
                        {
                            Landing.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            break;
                        }
                }
                obj.X = TimeLineModel.data[i].x;
                obj.Y = TimeLineModel.data[i].y;
                i++;
            }
            catch
            {
                i = 0;
                return;
            }
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    timer.Stop();
        //    //string jsonData = JsonConvert.SerializeObject(TimeLineModel.data);
        //   // File.WriteAllText(@"C:\Users\eminn\OneDrive\Desktop\timelineOrion.json", jsonData);
        //    obj.X += 1;
        //    var msg = XX.Content.ToString().Split('=')[1];
        //    XX.Content = XX.Content.ToString().Replace(msg, obj.X.ToString());
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    obj.X -= 1;
        //    var msg = XX.Content.ToString().Split('=')[1];
        //    XX.Content = XX.Content.ToString().Replace(msg, obj.X.ToString());
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    obj.Y += 1;
        //    var msg = YY.Content.ToString().Split('=')[1];
        //    YY.Content = YY.Content.ToString().Replace(msg, obj.Y.ToString());
        //}

        //private void Button_Click_3(object sender, RoutedEventArgs e)
        //{
        //    obj.Y -= 1;
        //    var msg = YY.Content.ToString().Split('=')[1];
        //    YY.Content = YY.Content.ToString().Replace(msg, obj.Y.ToString());
        //}

        //private void Button_Click_4(object sender, RoutedEventArgs e)
        //{
        //    var msg = txt.Text.Split(' ');
        //    obj.X = Convert.ToInt32(msg[0]);
        //    obj.Y = Convert.ToInt32(msg[1]);
        //}
    }
}
