using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace ThreeDRocket
{
    public class GaugeViewModel : INotifyPropertyChanged
    {
        public Border Border;
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        public GaugeViewModel()
        {
            Angle = -85;
            Value = 0;
        }
        int _angle;
        public int Angle
        {
            get
            {
                return _angle;
            }

            private set
            {
                _angle = value;
                NotifyPropertyChanged("Angle");
            }
        }
        int _value;
        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (value >= 0 && value <= 170)
                {
                    _value = value;
                    Angle = value - 85;
                    NotifyPropertyChanged("Value");
                }
            }
        }





        int x;
        public int X { get { return x; } set
            {
                x = value;
                NotifyPropertyChanged(nameof(X));
            } }

        int y;
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                NotifyPropertyChanged(nameof(Y));
            }
        }
        ///==========================
        ///

        int a1x;
        int a1y;
        public int a1X { get { return a1x; } set { a1x = value; NotifyPropertyChanged(nameof(a1X)); } }
        public int a1Y { get { return a1y; } set { a1y = value; NotifyPropertyChanged(nameof(a1Y)); } }


        int a2x;
        int a2y;
        public int a2X { get { return a2x; } set { a2x = value; NotifyPropertyChanged(nameof(a2X)); } }
        public int a2Y { get { return a2y; } set { a2y = value; NotifyPropertyChanged(nameof(a2Y)); } }


        int a3x;
        int a3y;
        public int a3X { get { return a3x; } set { a3x = value; NotifyPropertyChanged(nameof(a3X)); } }
        public int a3Y { get { return a3y; } set { a3y = value; NotifyPropertyChanged(nameof(a3Y)); } }

        int a4x;
        int a4y;
        public int a4X { get { return a4x; } set { a4x = value; NotifyPropertyChanged(nameof(a4X)); } }
        public int a4Y { get { return a4y; } set { a4y = value; NotifyPropertyChanged(nameof(a4Y)); } }

        int a5x;
        int a5y;
        public int a5X { get { return a5x; } set { a5x = value; NotifyPropertyChanged(nameof(a5X)); } }
        public int a5Y { get { return a5y; } set { a5y = value; NotifyPropertyChanged(nameof(a5Y)); } }

        int a6x;
        int a6y;
        public int a6X { get { return a6x; } set { a6x = value; NotifyPropertyChanged(nameof(a6X)); } }
        public int a6Y { get { return a6y; } set { a6y = value; NotifyPropertyChanged(nameof(a6Y)); } }

        int a7x;
        int a7y;
        public int a7X { get { return a7x; } set { a7x = value; NotifyPropertyChanged(nameof(a7X)); } }
        public int a7Y { get { return a7y; } set { a7y = value; NotifyPropertyChanged(nameof(a7Y)); } }

        int a8x;
        int a8y;
        public int a8X { get { return a8x; } set { a8x = value; NotifyPropertyChanged(nameof(a8X)); } }
        public int a8Y { get { return a8y; } set { a8y = value; NotifyPropertyChanged(nameof(a8Y)); } }
    }
}
