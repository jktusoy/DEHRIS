namespace DEHRIS.VIEW
{
    partial class ViewManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewManager));
            this.tbsViewMgr = new Syncfusion.Windows.Forms.Tools.TabSplitterContainer();
            this.tabSplitterPage1 = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.pnlViewMgrContent = new System.Windows.Forms.Panel();
            this.tabSplitterPage2 = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.objlViewMgr = new BrightIdeasSoftware.ObjectListView();
            this.lblViewMgrlHeader = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.xpToolBar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.briTitle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briAdd = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imgControls = new System.Windows.Forms.ImageList(this.components);
            this.briEdit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briDelete = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briSave = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briRefresh = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tbsViewMgr.SuspendLayout();
            this.tabSplitterPage1.SuspendLayout();
            this.tabSplitterPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objlViewMgr)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsViewMgr
            // 
            this.tbsViewMgr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsViewMgr.Location = new System.Drawing.Point(0, 62);
            this.tbsViewMgr.Name = "tbsViewMgr";
            this.tbsViewMgr.PrimaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.tabSplitterPage1});
            this.tbsViewMgr.SecondaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.tabSplitterPage2});
            this.tbsViewMgr.Size = new System.Drawing.Size(713, 280);
            this.tbsViewMgr.SplitterBackColor = System.Drawing.SystemColors.Control;
            this.tbsViewMgr.SplitterPosition = 139;
            this.tbsViewMgr.Swapped = true;
            this.tbsViewMgr.TabIndex = 1;
            this.tbsViewMgr.Text = "tabSplitterContainer1";
            // 
            // tabSplitterPage1
            // 
            this.tabSplitterPage1.AutoScroll = true;
            this.tabSplitterPage1.Controls.Add(this.pnlViewMgrContent);
            this.tabSplitterPage1.Hide = false;
            this.tabSplitterPage1.Location = new System.Drawing.Point(0, 159);
            this.tabSplitterPage1.Name = "tabSplitterPage1";
            this.tabSplitterPage1.Size = new System.Drawing.Size(713, 121);
            this.tabSplitterPage1.TabIndex = 3;
            this.tabSplitterPage1.Text = "Manage";
            // 
            // pnlViewMgrContent
            // 
            this.pnlViewMgrContent.AutoScroll = true;
            this.pnlViewMgrContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewMgrContent.Location = new System.Drawing.Point(0, 0);
            this.pnlViewMgrContent.Name = "pnlViewMgrContent";
            this.pnlViewMgrContent.Size = new System.Drawing.Size(713, 121);
            this.pnlViewMgrContent.TabIndex = 3;
            // 
            // tabSplitterPage2
            // 
            this.tabSplitterPage2.AutoScroll = true;
            this.tabSplitterPage2.Controls.Add(this.objlViewMgr);
            this.tabSplitterPage2.Hide = false;
            this.tabSplitterPage2.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterPage2.Name = "tabSplitterPage2";
            this.tabSplitterPage2.Size = new System.Drawing.Size(713, 139);
            this.tabSplitterPage2.TabIndex = 2;
            this.tabSplitterPage2.Text = "View";
            // 
            // objlViewMgr
            // 
            this.objlViewMgr.AllowColumnReorder = true;
            this.objlViewMgr.AllowDrop = true;
            this.objlViewMgr.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.objlViewMgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objlViewMgr.CellEditUseWholeCell = false;
            this.objlViewMgr.CellVerticalAlignment = System.Drawing.StringAlignment.Far;
            this.objlViewMgr.Cursor = System.Windows.Forms.Cursors.Default;
            this.objlViewMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objlViewMgr.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objlViewMgr.FullRowSelect = true;
            this.objlViewMgr.HideSelection = false;
            this.objlViewMgr.Location = new System.Drawing.Point(0, 0);
            this.objlViewMgr.Name = "objlViewMgr";
            this.objlViewMgr.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.objlViewMgr.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.objlViewMgr.SelectedForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.objlViewMgr.ShowCommandMenuOnRightClick = true;
            this.objlViewMgr.ShowGroups = false;
            this.objlViewMgr.ShowImagesOnSubItems = true;
            this.objlViewMgr.ShowItemCountOnGroups = true;
            this.objlViewMgr.ShowItemToolTips = true;
            this.objlViewMgr.Size = new System.Drawing.Size(713, 139);
            this.objlViewMgr.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objlViewMgr.TabIndex = 3;
            this.objlViewMgr.UnfocusedSelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.objlViewMgr.UseAlternatingBackColors = true;
            this.objlViewMgr.UseCompatibleStateImageBehavior = false;
            this.objlViewMgr.UseExplorerTheme = true;
            this.objlViewMgr.UseFilterIndicator = true;
            this.objlViewMgr.UseFiltering = true;
            this.objlViewMgr.UseHotItem = true;
            this.objlViewMgr.View = System.Windows.Forms.View.Details;
            this.objlViewMgr.SelectedIndexChanged += new System.EventHandler(this.objlViewMgr_SelectedIndexChanged);
            // 
            // lblViewMgrlHeader
            // 
            this.lblViewMgrlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewMgrlHeader.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblViewMgrlHeader.BeforeTouchSize = new System.Drawing.Size(713, 34);
            this.lblViewMgrlHeader.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.lblViewMgrlHeader.BorderColor = System.Drawing.Color.LightGray;
            this.lblViewMgrlHeader.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblViewMgrlHeader.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewMgrlHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblViewMgrlHeader.Location = new System.Drawing.Point(0, 0);
            this.lblViewMgrlHeader.Name = "lblViewMgrlHeader";
            this.lblViewMgrlHeader.Size = new System.Drawing.Size(713, 34);
            this.lblViewMgrlHeader.TabIndex = 2;
            this.lblViewMgrlHeader.Text = "Training";
            this.lblViewMgrlHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xpToolBar1
            // 
            this.xpToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xpToolBar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.xpToolBar1.Bar.BarName = "";
            this.xpToolBar1.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.briTitle,
            this.briAdd,
            this.briEdit,
            this.briDelete,
            this.briSave,
            this.briRefresh});
            this.xpToolBar1.Bar.Manager = null;
            this.xpToolBar1.Location = new System.Drawing.Point(-3, 35);
            this.xpToolBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xpToolBar1.Name = "xpToolBar1";
            this.xpToolBar1.Size = new System.Drawing.Size(716, 25);
            this.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.xpToolBar1.TabIndex = 0;
            this.xpToolBar1.Text = "xpToolBar1";
            // 
            // briTitle
            // 
            this.briTitle.BarName = "briTitle";
            this.briTitle.ShowToolTipInPopUp = false;
            this.briTitle.SizeToFit = true;
            // 
            // briAdd
            // 
            this.briAdd.BarName = "briAdd";
            this.briAdd.ImageIndex = 0;
            this.briAdd.ImageList = this.imgControls;
            this.briAdd.ShowToolTipInPopUp = false;
            this.briAdd.SizeToFit = true;
            this.briAdd.Click += new System.EventHandler(this.briAdd_Click);
            // 
            // imgControls
            // 
            this.imgControls.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgControls.ImageStream")));
            this.imgControls.TransparentColor = System.Drawing.Color.Transparent;
            this.imgControls.Images.SetKeyName(0, "add-icon32.png");
            this.imgControls.Images.SetKeyName(1, "delete-icon32.png");
            this.imgControls.Images.SetKeyName(2, "edit-icon32.png");
            this.imgControls.Images.SetKeyName(3, "refresh.png");
            this.imgControls.Images.SetKeyName(4, "save.png");
            this.imgControls.Images.SetKeyName(5, "add-iconDisabled32.png");
            this.imgControls.Images.SetKeyName(6, "delete-iconDisabled32.png");
            this.imgControls.Images.SetKeyName(7, "edit-iconDisabled32.png");
            // 
            // briEdit
            // 
            this.briEdit.BarName = "briEdit";
            this.briEdit.ImageIndex = 2;
            this.briEdit.ImageList = this.imgControls;
            this.briEdit.ShowToolTipInPopUp = false;
            this.briEdit.SizeToFit = true;
            this.briEdit.Click += new System.EventHandler(this.briEdit_Click);
            // 
            // briDelete
            // 
            this.briDelete.BarName = "briDelete";
            this.briDelete.ImageIndex = 1;
            this.briDelete.ImageList = this.imgControls;
            this.briDelete.ShowToolTipInPopUp = false;
            this.briDelete.SizeToFit = true;
            this.briDelete.Click += new System.EventHandler(this.briDelete_Click);
            // 
            // briSave
            // 
            this.briSave.BarName = "briSave";
            this.briSave.ImageIndex = 4;
            this.briSave.ImageList = this.imgControls;
            this.briSave.ShowToolTipInPopUp = false;
            this.briSave.SizeToFit = true;
            this.briSave.Click += new System.EventHandler(this.briSave_Click);
            // 
            // briRefresh
            // 
            this.briRefresh.BarName = "briRefresh";
            this.briRefresh.ImageIndex = 3;
            this.briRefresh.ImageList = this.imgControls;
            this.briRefresh.ShowToolTipInPopUp = false;
            this.briRefresh.SizeToFit = true;
            this.briRefresh.Click += new System.EventHandler(this.briRefresh_Click);
            // 
            // ViewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xpToolBar1);
            this.Controls.Add(this.lblViewMgrlHeader);
            this.Controls.Add(this.tbsViewMgr);
            this.Name = "ViewManager";
            this.Size = new System.Drawing.Size(713, 342);
            this.tbsViewMgr.ResumeLayout(false);
            this.tabSplitterPage1.ResumeLayout(false);
            this.tabSplitterPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objlViewMgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabSplitterContainer tbsViewMgr;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPage1;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPage2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xpToolBar1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblViewMgrlHeader;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTitle;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briAdd;
        private System.Windows.Forms.ImageList imgControls;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briEdit;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briDelete;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briSave;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briRefresh;
        private BrightIdeasSoftware.ObjectListView objlViewMgr;
        private System.Windows.Forms.Panel pnlViewMgrContent;


    }
}
