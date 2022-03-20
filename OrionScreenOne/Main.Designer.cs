
using System.Windows.Forms;

namespace OrionScreenOne
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.Three3D = new System.Windows.Forms.Integration.ElementHost();
            this._3DObject1 = new ThreeDRocket._3DObject();
            this.TimeLineOrion = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Three3D
            // 
            this.Three3D.Location = new System.Drawing.Point(13, 27);
            this.Three3D.Name = "Three3D";
            this.Three3D.Size = new System.Drawing.Size(283, 210);
            this.Three3D.TabIndex = 1;
            this.Three3D.Text = "elementHost1";
            this.Three3D.Child = this._3DObject1;
            // 
            // TimeLineOrion
            // 
            this.TimeLineOrion.Location = new System.Drawing.Point(540, 297);
            this.TimeLineOrion.Name = "TimeLineOrion";
            this.TimeLineOrion.Size = new System.Drawing.Size(200, 100);
            this.TimeLineOrion.TabIndex = 2;
            this.TimeLineOrion.Text = "elementHost1";
            this.TimeLineOrion.Child = null;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::OrionScreenOne.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.TimeLineOrion);
            this.Controls.Add(this.Three3D);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Integration.ElementHost Three3D;
        private ThreeDRocket._3DObject _3DObject1;
        private System.Windows.Forms.Integration.ElementHost TimeLineOrion;
    }
}