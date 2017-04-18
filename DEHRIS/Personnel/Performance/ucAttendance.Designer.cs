namespace DEHRIS.Personnel.Performance
{
    partial class ucAttendance
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.objlPersonnelView = new BrightIdeasSoftware.ObjectListView();
            this.cFullName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objlPersonnelView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.objlPersonnelView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 369F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 414);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 39);
            this.panel1.TabIndex = 1;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(676, 39);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(676, 39);
            this.gradientLabel1.TabIndex = 0;
            this.gradientLabel1.Text = "ATTENDANCE";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objlPersonnelView
            // 
            this.objlPersonnelView.AllColumns.Add(this.cFullName);
            this.objlPersonnelView.AllowColumnReorder = true;
            this.objlPersonnelView.AllowDrop = true;
            this.objlPersonnelView.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.objlPersonnelView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objlPersonnelView.CellEditUseWholeCell = false;
            this.objlPersonnelView.CellVerticalAlignment = System.Drawing.StringAlignment.Far;
            this.objlPersonnelView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cFullName});
            this.objlPersonnelView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objlPersonnelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objlPersonnelView.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objlPersonnelView.FullRowSelect = true;
            this.objlPersonnelView.HideSelection = false;
            this.objlPersonnelView.Location = new System.Drawing.Point(3, 48);
            this.objlPersonnelView.Name = "objlPersonnelView";
            this.objlPersonnelView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.objlPersonnelView.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.objlPersonnelView.SelectedForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.objlPersonnelView.ShowCommandMenuOnRightClick = true;
            this.objlPersonnelView.ShowGroups = false;
            this.objlPersonnelView.ShowImagesOnSubItems = true;
            this.objlPersonnelView.ShowItemCountOnGroups = true;
            this.objlPersonnelView.ShowItemToolTips = true;
            this.objlPersonnelView.Size = new System.Drawing.Size(676, 363);
            this.objlPersonnelView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objlPersonnelView.TabIndex = 2;
            this.objlPersonnelView.UnfocusedSelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.objlPersonnelView.UseAlternatingBackColors = true;
            this.objlPersonnelView.UseCompatibleStateImageBehavior = false;
            this.objlPersonnelView.UseExplorerTheme = true;
            this.objlPersonnelView.UseFilterIndicator = true;
            this.objlPersonnelView.UseFiltering = true;
            this.objlPersonnelView.UseHotItem = true;
            this.objlPersonnelView.View = System.Windows.Forms.View.Details;
            // 
            // cFullName
            // 
            this.cFullName.AspectName = "Fullname";
            this.cFullName.EnableButtonWhenItemIsDisabled = true;
            this.cFullName.FillsFreeSpace = true;
            this.cFullName.Groupable = false;
            this.cFullName.Text = "FullName";
            this.cFullName.Width = 445;
            // 
            // ucAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucAttendance";
            this.Size = new System.Drawing.Size(682, 414);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objlPersonnelView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private BrightIdeasSoftware.ObjectListView objlPersonnelView;
        private BrightIdeasSoftware.OLVColumn cFullName;
    }
}
