namespace DEHRIS.Home
{
    partial class ucHomePanel
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
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.HighlightText, System.Drawing.Color.LightSteelBlue);
            this.gradientPanel2.BorderColor = System.Drawing.Color.SteelBlue;
            this.gradientPanel2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.IgnoreThemeBackground = true;
            this.gradientPanel2.Location = new System.Drawing.Point(15, 17);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(421, 384);
            this.gradientPanel2.TabIndex = 3;
            // 
            // ucHomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradientPanel2);
            this.Name = "ucHomePanel";
            this.Size = new System.Drawing.Size(950, 600);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
    }
}
