namespace DEHRIS.Navigation
{
    partial class ucNavigation
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
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer3 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer3 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            this.tabSplitterContainer1 = new Syncfusion.Windows.Forms.Tools.TabSplitterContainer();
            this.tabSplitterPage1 = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.tabSplitterPage2 = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.tabSplitterContainer1.SuspendLayout();
            this.tabSplitterPage1.SuspendLayout();
            this.tabSplitterPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSplitterContainer1
            // 
            this.tabSplitterContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSplitterContainer1.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterContainer1.Name = "tabSplitterContainer1";
            this.tabSplitterContainer1.PrimaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.tabSplitterPage1});
            this.tabSplitterContainer1.SecondaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.tabSplitterPage2});
            this.tabSplitterContainer1.Size = new System.Drawing.Size(262, 438);
            this.tabSplitterContainer1.SplitterBackColor = System.Drawing.SystemColors.Control;
            this.tabSplitterContainer1.SplitterPosition = 261;
            this.tabSplitterContainer1.Swapped = true;
            this.tabSplitterContainer1.TabIndex = 1;
            this.tabSplitterContainer1.Text = "tabSplitterContainer1";
            // 
            // tabSplitterPage1
            // 
            this.tabSplitterPage1.AutoScroll = true;
            this.tabSplitterPage1.Controls.Add(this.clock1);
            this.tabSplitterPage1.Hide = false;
            this.tabSplitterPage1.Location = new System.Drawing.Point(0, 281);
            this.tabSplitterPage1.Name = "tabSplitterPage1";
            this.tabSplitterPage1.Size = new System.Drawing.Size(262, 157);
            this.tabSplitterPage1.TabIndex = 1;
            this.tabSplitterPage1.Text = "tabSplitterPage1";
            // 
            // tabSplitterPage2
            // 
            this.tabSplitterPage2.AutoScroll = true;
            this.tabSplitterPage2.Controls.Add(this.gradientPanel2);
            this.tabSplitterPage2.Hide = false;
            this.tabSplitterPage2.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterPage2.Name = "tabSplitterPage2";
            this.tabSplitterPage2.Size = new System.Drawing.Size(262, 261);
            this.tabSplitterPage2.TabIndex = 2;
            this.tabSplitterPage2.Text = "tabSplitterPage2";
            // 
            // clock1
            // 
            this.clock1.BackColor = System.Drawing.Color.Transparent;
            this.clock1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.clock1.BeforeTouchSize = new System.Drawing.Size(250, 125);
            this.clock1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(119)))));
            this.clock1.ClockFormat = "HH:mm:ss";
            this.clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.CircularFrame;
            this.clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            this.clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock1.CurrentDateTime = new System.DateTime(2017, 3, 2, 16, 0, 45, 896);
            this.clock1.CustomTime = new System.DateTime(2017, 3, 2, 16, 7, 38, 642);
            this.clock1.DigitalRenderer = digitalClockRenderer3;
            this.clock1.DisplayDates = true;
            this.clock1.EndGradientBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            this.clock1.IsTransparent = true;
            this.clock1.Location = new System.Drawing.Point(3, 15);
            this.clock1.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock1.MinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(119)))));
            this.clock1.Name = "clock1";
            this.clock1.Now = new System.DateTime(((long)(0)));
            this.clock1.Remainder = new System.DateTime(2017, 3, 2, 16, 0, 45, 896);
            this.clock1.Renderer = clockRenderer3;
            this.clock1.ShowClockFrame = false;
            this.clock1.ShowCustomTimeClock = false;
            this.clock1.ShowHourDesignator = false;
            this.clock1.Size = new System.Drawing.Size(250, 125);
            this.clock1.StartGradientBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.clock1.StopTimer = false;
            this.clock1.TabIndex = 1;
            this.clock1.Text = "clock1";
            this.clock1.VisualStyle = Syncfusion.Windows.Forms.Tools.ClockVisualStyle.OfficeBlue;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.HighlightText, System.Drawing.Color.LightSteelBlue);
            this.gradientPanel2.BorderColor = System.Drawing.Color.SteelBlue;
            this.gradientPanel2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.IgnoreThemeBackground = true;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(262, 261);
            this.gradientPanel2.TabIndex = 2;
            // 
            // ucNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabSplitterContainer1);
            this.Name = "ucNavigation";
            this.Size = new System.Drawing.Size(262, 438);
            this.tabSplitterContainer1.ResumeLayout(false);
            this.tabSplitterPage1.ResumeLayout(false);
            this.tabSplitterPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabSplitterContainer tabSplitterContainer1;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPage1;
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPage2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;

    }
}
