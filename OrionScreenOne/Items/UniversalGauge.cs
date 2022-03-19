using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrionScreenOne.Items
{
    public partial class UniversalGauge : UserControl
    {
        public double Value
        {
            get
            {
                return solidGauge1.Value;
            }
            set
            {
                solidGauge1.Value = value;
            }
        }
        public UniversalGauge()
        {
            InitializeComponent();
            
            this.Location = new Point(200, 200);
            
        }
        public UniversalGauge(int left, int top)
        {
            InitializeComponent();
            this.Location = new Point(left, top);
        }

    }
}
