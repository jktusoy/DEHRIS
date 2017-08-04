namespace DEHRIS.Tool
{
    partial class ucSpreadsheet
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
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSpreadsheet));
            this.miniToolBar1 = new Syncfusion.Windows.Forms.Tools.MiniToolBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spreadsheet1 = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.xpToolBar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolBar1
            // 
            this.miniToolBar1.Name = "miniToolBar1";
            this.miniToolBar1.Size = new System.Drawing.Size(24, 24);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.spreadsheet1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xpToolBar1);
            this.splitContainer1.Size = new System.Drawing.Size(949, 670);
            this.splitContainer1.SplitterDistance = 635;
            this.splitContainer1.TabIndex = 3;
            // 
            // spreadsheet1
            // 
            this.spreadsheet1.AllowCellContextMenu = true;
            this.spreadsheet1.AllowExtendRowColumnCount = true;
            this.spreadsheet1.AllowFormulaRangeSelection = true;
            this.spreadsheet1.AllowTabItemContextMenu = true;
            this.spreadsheet1.AllowZooming = true;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.spreadsheet1.CopyPaste = spreadsheetCopyPaste1;
            this.spreadsheet1.DefaultColumnCount = 101;
            this.spreadsheet1.DefaultRowCount = 101;
            this.spreadsheet1.DisplayAlerts = true;
            this.spreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheet1.FileName = "Book1";
            this.spreadsheet1.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.spreadsheet1.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.spreadsheet1.IsCustomTabItemContextMenuEnabled = false;
            this.spreadsheet1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheet1.Name = "spreadsheet1";
            this.spreadsheet1.SelectedTabIndex = 0;
            this.spreadsheet1.SelectedTabItem = null;
            this.spreadsheet1.ShowBusyIndicator = true;
            this.spreadsheet1.Size = new System.Drawing.Size(949, 635);
            this.spreadsheet1.TabIndex = 9;
            this.spreadsheet1.TabItemContextMenu = null;
            this.spreadsheet1.Text = "spreadsheet1";
            this.spreadsheet1.Click += new System.EventHandler(this.spreadsheet1_Click);
            // 
            // xpToolBar1
            // 
            this.xpToolBar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.xpToolBar1.Bar.BarName = "";
            this.xpToolBar1.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.xpToolBar1.Bar.Manager = null;
            this.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpToolBar1.LargeIcons = true;
            this.xpToolBar1.Location = new System.Drawing.Point(0, 0);
            this.xpToolBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xpToolBar1.Name = "xpToolBar1";
            this.xpToolBar1.ShowChevron = true;
            this.xpToolBar1.Size = new System.Drawing.Size(949, 25);
            this.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.xpToolBar1.TabIndex = 1;
            this.xpToolBar1.Text = "xpToolBar1";
            this.xpToolBar1.Click += new System.EventHandler(this.xpToolBar1_Click);
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.ID = "SOMETHING";
            this.barItem1.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("barItem1.Image")));
            this.barItem1.ShowToolTipInPopUp = true;
            this.barItem1.SizeToFit = true;
            this.barItem1.Text = "SOMETHING";
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            // 
            // ucSpreadsheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucSpreadsheet";
            this.Size = new System.Drawing.Size(949, 670);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.MiniToolBar miniToolBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet spreadsheet1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xpToolBar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;

    }
}
