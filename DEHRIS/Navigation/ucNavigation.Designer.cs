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
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            this.tabSplitterContainer1 = new Syncfusion.Windows.Forms.Tools.TabSplitterContainer();
            this.tabSplitterPage1 = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.clock2 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.tabSplitterPage2 = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.tabSplitterContainer1.SuspendLayout();
            this.tabSplitterPage1.SuspendLayout();
            this.tabSplitterPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
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
            this.tabSplitterContainer1.SplitterPosition = 154;
            this.tabSplitterContainer1.Swapped = true;
            this.tabSplitterContainer1.TabIndex = 1;
            this.tabSplitterContainer1.Text = "tabSplitterContainer1";
            // 
            // tabSplitterPage1
            // 
            this.tabSplitterPage1.AutoScroll = true;
            this.tabSplitterPage1.Controls.Add(this.clock2);
            this.tabSplitterPage1.Hide = false;
            this.tabSplitterPage1.Location = new System.Drawing.Point(0, 174);
            this.tabSplitterPage1.Name = "tabSplitterPage1";
            this.tabSplitterPage1.Size = new System.Drawing.Size(262, 264);
            this.tabSplitterPage1.TabIndex = 1;
            this.tabSplitterPage1.Text = "tabSplitterPage1";
            // 
            // clock2
            // 
            this.clock2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clock2.BackColor = System.Drawing.Color.Transparent;
            this.clock2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.clock2.BeforeTouchSize = new System.Drawing.Size(238, 119);
            this.clock2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(119)))));
            this.clock2.ClockFormat = "HH:mm:ss";
            this.clock2.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock2.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            this.clock2.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock2.CurrentDateTime = new System.DateTime(2017, 3, 2, 16, 0, 45, 896);
            this.clock2.CustomTime = new System.DateTime(2017, 3, 6, 20, 28, 34, 633);
            this.clock2.DigitalRenderer = digitalClockRenderer1;
            this.clock2.DisplayDates = true;
            this.clock2.EnableRemainder = true;
            this.clock2.EndGradientBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            this.clock2.IsTransparent = true;
            this.clock2.Location = new System.Drawing.Point(12, 82);
            this.clock2.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock2.MinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(119)))));
            this.clock2.Name = "clock2";
            this.clock2.Now = new System.DateTime(((long)(0)));
            this.clock2.Remainder = new System.DateTime(2017, 3, 2, 16, 0, 45, 896);
            this.clock2.Renderer = clockRenderer1;
            this.clock2.ShowAMorPM = true;
            this.clock2.ShowClockFrame = false;
            this.clock2.ShowCustomTimeClock = true;
            this.clock2.ShowHourDesignator = true;
            this.clock2.Size = new System.Drawing.Size(238, 119);
            this.clock2.StartGradientBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.clock2.StopTimer = false;
            this.clock2.TabIndex = 2;
            this.clock2.Text = "clock2";
            this.clock2.VisualStyle = Syncfusion.Windows.Forms.Tools.ClockVisualStyle.OfficeBlue;
            // 
            // tabSplitterPage2
            // 
            this.tabSplitterPage2.AutoScroll = true;
            this.tabSplitterPage2.Controls.Add(this.gradientPanel2);
            this.tabSplitterPage2.Hide = false;
            this.tabSplitterPage2.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterPage2.Name = "tabSplitterPage2";
            this.tabSplitterPage2.Size = new System.Drawing.Size(262, 154);
            this.tabSplitterPage2.TabIndex = 2;
            this.tabSplitterPage2.Text = "tabSplitterPage2";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.HighlightText, System.Drawing.Color.LightSteelBlue);
            this.gradientPanel2.BorderColor = System.Drawing.Color.SteelBlue;
            this.gradientPanel2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.groupBar1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.IgnoreThemeBackground = true;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(262, 154);
            this.gradientPanel2.TabIndex = 2;
            // 
            // groupBar1
            // 
            this.groupBar1.AllowCollapse = true;
            this.groupBar1.AllowDrop = true;
            this.groupBar1.BeforeTouchSize = new System.Drawing.Size(260, 152);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.HeaderBackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.IndexOnVisibleItems = true;
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.Size = new System.Drawing.Size(260, 152);
            this.groupBar1.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.groupBar1.TabIndex = 0;
            this.groupBar1.Text = "groupBar1";
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
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabSplitterContainer tabSplitterContainer1;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPage1;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPage2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.Clock clock2;

    }
}
