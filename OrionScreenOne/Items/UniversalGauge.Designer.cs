
using System;
using System.Windows.Media;

namespace OrionScreenOne.Items
{
    partial class UniversalGauge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.SuspendLayout();
            // 
            // solidGauge1
            // 
            this.Height = 100;
            this.Width = 200;
            this.solidGauge1.From = 0;
            this.solidGauge1.To = 100;
            this.BackColor = System.Drawing.Color.Transparent;
            this.solidGauge1.Location = new System.Drawing.Point(0, 0);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(200, 99);
            this.solidGauge1.TabIndex = 0;
            this.solidGauge1.Text = "solidGauge1";
            this.solidGauge1.Base.LabelsVisibility = System.Windows.Visibility.Hidden;
            this.solidGauge1.Base.GaugeActiveFill = new System.Windows.Media.LinearGradientBrush()
            {
                GradientStops = new System.Windows.Media.GradientStopCollection()
                {
                    new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Chocolate,.5),
                    new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Red,1),
                }
            };
            this.solidGauge1.InnerRadius = 80;
            this.solidGauge1.Base.GaugeBackground = new SolidColorBrush(Color.FromRgb(226, 228, 241));
            this.solidGauge1.AnimationsSpeed = new TimeSpan(0, 0, 0, 0, 200);
            // 
            // label1
            // 
            // 
            // UniversalGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.solidGauge1);
            this.Name = "UniversalGauge";
            this.Size = new System.Drawing.Size(200, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.SolidGauge solidGauge1;
    }
}
