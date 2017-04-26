using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;


namespace ToolTipTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private CustomTooltip.BalloonToolTip balloonToolTip1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.balloonToolTip1 = new CustomTooltip.BalloonToolTip();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.balloonToolTip1.SetBalloonText(this.button2, "I am a Button control");
			this.button2.Location = new System.Drawing.Point(32, 72);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Just for test";
			this.button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// button1
			// 
			this.balloonToolTip1.SetBalloonText(this.button1, "Press this button to toggle the BalloonToolTip ON / OFF");
			this.button1.Location = new System.Drawing.Point(32, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Just for test";
			this.button1.Click += new System.EventHandler(this.button2_Click);
			// 
			// propertyGrid1
			// 
			this.balloonToolTip1.SetBalloonText(this.propertyGrid1, null);
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(176, 8);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.SelectedObject = this.balloonToolTip1;
			this.propertyGrid1.Size = new System.Drawing.Size(224, 336);
			this.propertyGrid1.TabIndex = 4;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// balloonToolTip1
			// 
			this.balloonToolTip1.BackColor = System.Drawing.Color.LightGray;
			this.balloonToolTip1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.balloonToolTip1.Icon = CustomTooltip.BalloonToolTip.BalloonIcons.Info;
			this.balloonToolTip1.Title = "BallonToolTip";
			// 
			// textBox1
			// 
			this.balloonToolTip1.SetBalloonText(this.textBox1, "I am a TextBox control");
			this.textBox1.Location = new System.Drawing.Point(32, 112);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "Just for test";
			// 
			// comboBox1
			// 
			this.balloonToolTip1.SetBalloonText(this.comboBox1, "I am a ComboBox control");
			this.comboBox1.Items.AddRange(new object[] {
														   "Item 1",
														   "Item 2",
														   "Item 3",
														   "Item 4"});
			this.comboBox1.Location = new System.Drawing.Point(32, 144);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(120, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.Text = "Just for test";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(406, 364);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BalloonTip Test";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			this.balloonToolTip1.Enabled = ! this.balloonToolTip1.Enabled;
			this.propertyGrid1.SelectedObject = this.balloonToolTip1;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		}
	}
}
