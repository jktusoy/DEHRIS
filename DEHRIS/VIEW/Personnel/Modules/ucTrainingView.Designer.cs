namespace DEHRIS.Personnel.Modules
{
    partial class ucTrainingView
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
            this.objlTrainingView = new BrightIdeasSoftware.ObjectListView();
            this.cTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cRemarks = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlTRNVCRUD = new System.Windows.Forms.Panel();
            this.ucTraining2 = new DEHRIS.Personnel.Modules.ucTraining();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objlTrainingView)).BeginInit();
            this.pnlTRNVCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.objlTrainingView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTRNVCRUD, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // objlTrainingView
            // 
            this.objlTrainingView.AllColumns.Add(this.cTitle);
            this.objlTrainingView.AllColumns.Add(this.cRemarks);
            this.objlTrainingView.AllColumns.Add(this.olvColumn2);
            this.objlTrainingView.AllColumns.Add(this.olvColumn3);
            this.objlTrainingView.AllColumns.Add(this.olvColumn4);
            this.objlTrainingView.AllowColumnReorder = true;
            this.objlTrainingView.AllowDrop = true;
            this.objlTrainingView.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.objlTrainingView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objlTrainingView.CellEditUseWholeCell = false;
            this.objlTrainingView.CellVerticalAlignment = System.Drawing.StringAlignment.Far;
            this.objlTrainingView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTitle,
            this.cRemarks,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.objlTrainingView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objlTrainingView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objlTrainingView.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objlTrainingView.FullRowSelect = true;
            this.objlTrainingView.HideSelection = false;
            this.objlTrainingView.Location = new System.Drawing.Point(3, 3);
            this.objlTrainingView.Name = "objlTrainingView";
            this.objlTrainingView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.objlTrainingView.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.objlTrainingView.SelectedForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.objlTrainingView.ShowCommandMenuOnRightClick = true;
            this.objlTrainingView.ShowGroups = false;
            this.objlTrainingView.ShowImagesOnSubItems = true;
            this.objlTrainingView.ShowItemCountOnGroups = true;
            this.objlTrainingView.ShowItemToolTips = true;
            this.objlTrainingView.Size = new System.Drawing.Size(444, 594);
            this.objlTrainingView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objlTrainingView.TabIndex = 2;
            this.objlTrainingView.UnfocusedSelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.objlTrainingView.UseAlternatingBackColors = true;
            this.objlTrainingView.UseCompatibleStateImageBehavior = false;
            this.objlTrainingView.UseExplorerTheme = true;
            this.objlTrainingView.UseFilterIndicator = true;
            this.objlTrainingView.UseFiltering = true;
            this.objlTrainingView.UseHotItem = true;
            this.objlTrainingView.View = System.Windows.Forms.View.Details;
            this.objlTrainingView.SelectionChanged += new System.EventHandler(this.objlTrainingView_SelectionChanged);
            // 
            // cTitle
            // 
            this.cTitle.AspectName = "Title";
            this.cTitle.EnableButtonWhenItemIsDisabled = true;
            this.cTitle.FillsFreeSpace = true;
            this.cTitle.Groupable = false;
            this.cTitle.Text = "Title";
            this.cTitle.Width = 445;
            // 
            // cRemarks
            // 
            this.cRemarks.AspectName = "Remarks";
            this.cRemarks.Text = "Remarks";
            // 
            // pnlTRNVCRUD
            // 
            this.pnlTRNVCRUD.Controls.Add(this.ucTraining2);
            this.pnlTRNVCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTRNVCRUD.Location = new System.Drawing.Point(453, 3);
            this.pnlTRNVCRUD.Name = "pnlTRNVCRUD";
            this.pnlTRNVCRUD.Size = new System.Drawing.Size(444, 594);
            this.pnlTRNVCRUD.TabIndex = 3;
            // 
            // ucTraining2
            // 
            this.ucTraining2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTraining2.Location = new System.Drawing.Point(0, 0);
            this.ucTraining2.Name = "ucTraining2";
            this.ucTraining2.Size = new System.Drawing.Size(444, 594);
            this.ucTraining2.TabIndex = 4;
            this.ucTraining2.TrainingItem = null;
            // 
            // ucTrainingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTrainingView";
            this.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objlTrainingView)).EndInit();
            this.pnlTRNVCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ucTraining ucTraining1;
        private BrightIdeasSoftware.ObjectListView objlTrainingView;
        private BrightIdeasSoftware.OLVColumn cTitle;
        private BrightIdeasSoftware.OLVColumn cRemarks;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Panel pnlTRNVCRUD;
        private ucTraining ucTraining2;
    }
}
