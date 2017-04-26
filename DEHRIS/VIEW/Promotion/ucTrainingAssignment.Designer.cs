namespace DEHRIS.Personnel.Modules
{
    partial class ucTrainingAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTrainingAssignment));
            this.tabSplitterContainer1 = new Syncfusion.Windows.Forms.Tools.TabSplitterContainer();
            this.tabSplitterPage2 = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.objlPersonnelView = new BrightIdeasSoftware.ObjectListView();
            this.cFullName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabSplitterPage1 = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xptbPersonnel = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.briTRATitle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briTRAAdd = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briTRADelete = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briTRARefresh = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.objlTraining = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabSplitterContainer1.SuspendLayout();
            this.tabSplitterPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objlPersonnelView)).BeginInit();
            this.tabSplitterPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objlTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSplitterContainer1
            // 
            this.tabSplitterContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSplitterContainer1.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterContainer1.Name = "tabSplitterContainer1";
            this.tabSplitterContainer1.PrimaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.tabSplitterPage2});
            this.tabSplitterContainer1.SecondaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.tabSplitterPage1});
            this.tabSplitterContainer1.Size = new System.Drawing.Size(848, 430);
            this.tabSplitterContainer1.SplitterBackColor = System.Drawing.SystemColors.Control;
            this.tabSplitterContainer1.SplitterPosition = 202;
            this.tabSplitterContainer1.TabIndex = 0;
            this.tabSplitterContainer1.Text = "tabSplitterContainer1";
            // 
            // tabSplitterPage2
            // 
            this.tabSplitterPage2.AutoScroll = true;
            this.tabSplitterPage2.Controls.Add(this.panel2);
            this.tabSplitterPage2.Hide = false;
            this.tabSplitterPage2.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterPage2.Name = "tabSplitterPage2";
            this.tabSplitterPage2.Size = new System.Drawing.Size(848, 202);
            this.tabSplitterPage2.TabIndex = 2;
            this.tabSplitterPage2.Text = "tabSplitterPage2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.objlPersonnelView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 202);
            this.panel2.TabIndex = 0;
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
            this.objlPersonnelView.Location = new System.Drawing.Point(0, 0);
            this.objlPersonnelView.Name = "objlPersonnelView";
            this.objlPersonnelView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.objlPersonnelView.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.objlPersonnelView.SelectedForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.objlPersonnelView.ShowCommandMenuOnRightClick = true;
            this.objlPersonnelView.ShowGroups = false;
            this.objlPersonnelView.ShowImagesOnSubItems = true;
            this.objlPersonnelView.ShowItemCountOnGroups = true;
            this.objlPersonnelView.ShowItemToolTips = true;
            this.objlPersonnelView.Size = new System.Drawing.Size(848, 202);
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
            this.objlPersonnelView.SelectedIndexChanged += new System.EventHandler(this.objlPersonnelView_SelectedIndexChanged);
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
            // tabSplitterPage1
            // 
            this.tabSplitterPage1.AutoScroll = true;
            this.tabSplitterPage1.Controls.Add(this.panel1);
            this.tabSplitterPage1.Hide = false;
            this.tabSplitterPage1.Location = new System.Drawing.Point(0, 222);
            this.tabSplitterPage1.Name = "tabSplitterPage1";
            this.tabSplitterPage1.Size = new System.Drawing.Size(848, 208);
            this.tabSplitterPage1.TabIndex = 1;
            this.tabSplitterPage1.Text = "tabSplitterPage1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 208);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.94231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.05769F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 208);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // xptbPersonnel
            // 
            this.xptbPersonnel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.xptbPersonnel.Bar.BarName = "Add";
            this.xptbPersonnel.Bar.Caption = "Add";
            this.xptbPersonnel.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.briTRATitle,
            this.briTRAAdd,
            this.briTRADelete,
            this.briTRARefresh});
            this.xptbPersonnel.Bar.Manager = null;
            this.xptbPersonnel.Bar.SeparatorIndices.AddRange(new int[] {
            1});
            this.xptbPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xptbPersonnel.LargeIcons = true;
            this.xptbPersonnel.Location = new System.Drawing.Point(3, 3);
            this.xptbPersonnel.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xptbPersonnel.Name = "xptbPersonnel";
            this.xptbPersonnel.ShowChevron = true;
            this.xptbPersonnel.Size = new System.Drawing.Size(842, 25);
            this.xptbPersonnel.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.xptbPersonnel.TabIndex = 4;
            this.xptbPersonnel.Text = "Add";
            // 
            // briTRATitle
            // 
            this.briTRATitle.BarName = "briTRATitle";
            this.briTRATitle.ID = "Training Assignment";
            this.briTRATitle.ShowToolTipInPopUp = false;
            this.briTRATitle.SizeToFit = true;
            this.briTRATitle.Text = "Training Assignment";
            // 
            // briTRAAdd
            // 
            this.briTRAAdd.BarName = "briTRAAdd";
            this.briTRAAdd.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRAAdd.Image")));
            this.briTRAAdd.ShowToolTipInPopUp = false;
            this.briTRAAdd.SizeToFit = true;
            this.briTRAAdd.Click += new System.EventHandler(this.briTRAAdd_Click);
            // 
            // briTRADelete
            // 
            this.briTRADelete.BarName = "briTRADelete";
            this.briTRADelete.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRADelete.Image")));
            this.briTRADelete.ShowToolTipInPopUp = false;
            this.briTRADelete.SizeToFit = true;
            // 
            // briTRARefresh
            // 
            this.briTRARefresh.BarName = "briTRARefresh";
            this.briTRARefresh.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRARefresh.Image")));
            this.briTRARefresh.ShowToolTipInPopUp = false;
            this.briTRARefresh.SizeToFit = true;
            // 
            // objlTraining
            // 
            this.objlTraining.AllColumns.Add(this.olvColumn1);
            this.objlTraining.AllowColumnReorder = true;
            this.objlTraining.AllowDrop = true;
            this.objlTraining.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.objlTraining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objlTraining.CellEditUseWholeCell = false;
            this.objlTraining.CellVerticalAlignment = System.Drawing.StringAlignment.Far;
            this.objlTraining.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.objlTraining.Cursor = System.Windows.Forms.Cursors.Default;
            this.objlTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objlTraining.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objlTraining.FullRowSelect = true;
            this.objlTraining.HideSelection = false;
            this.objlTraining.Location = new System.Drawing.Point(0, 0);
            this.objlTraining.Name = "objlTraining";
            this.objlTraining.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.objlTraining.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.objlTraining.SelectedForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.objlTraining.ShowCommandMenuOnRightClick = true;
            this.objlTraining.ShowGroups = false;
            this.objlTraining.ShowImagesOnSubItems = true;
            this.objlTraining.ShowItemCountOnGroups = true;
            this.objlTraining.ShowItemToolTips = true;
            this.objlTraining.Size = new System.Drawing.Size(842, 173);
            this.objlTraining.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objlTraining.TabIndex = 3;
            this.objlTraining.UnfocusedSelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.objlTraining.UseAlternatingBackColors = true;
            this.objlTraining.UseCompatibleStateImageBehavior = false;
            this.objlTraining.UseExplorerTheme = true;
            this.objlTraining.UseFilterIndicator = true;
            this.objlTraining.UseFiltering = true;
            this.objlTraining.UseHotItem = true;
            this.objlTraining.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Fullname";
            this.olvColumn1.EnableButtonWhenItemIsDisabled = true;
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.Groupable = false;
            this.olvColumn1.Text = "FullName";
            this.olvColumn1.Width = 445;
            // 
            // ucTrainingAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabSplitterContainer1);
            this.Name = "ucTrainingAssignment";
            this.Size = new System.Drawing.Size(848, 430);
            this.tabSplitterContainer1.ResumeLayout(false);
            this.tabSplitterPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objlPersonnelView)).EndInit();
            this.tabSplitterPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objlTraining)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabSplitterContainer tabSplitterContainer1;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPage1;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private BrightIdeasSoftware.ObjectListView objlPersonnelView;
        private BrightIdeasSoftware.OLVColumn cFullName;
        private BrightIdeasSoftware.ObjectListView objlTraining;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xptbPersonnel;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRATitle;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRAAdd;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRADelete;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRARefresh;
        private wdi.ui.FlipPanel flipTRNA;
    }
}
