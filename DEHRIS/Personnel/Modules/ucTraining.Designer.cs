namespace DEHRIS.Personnel.Modules
{
    partial class ucTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTraining));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTRNDuration = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.xptbPersonnel = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.briTRNTitle = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briTRNAdd = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briTRNEdit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briTRNDelete = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briTRNRefresh = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.briTRNSave = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.txtTRNMethod = new System.Windows.Forms.TextBox();
            this.txtTRNTrainingType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTRNTitle = new System.Windows.Forms.TextBox();
            this.dtpTRNDateFrom = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.dtpTRNDateTo = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTrnTitle = new System.Windows.Forms.Label();
            this.txtTRNConductedBy = new System.Windows.Forms.TextBox();
            this.txtTRNRemarks = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTRNDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTRNDateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTRNDateTo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gradientLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.68478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.31522F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 368);
            this.tableLayoutPanel1.TabIndex = 77;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(541, 42);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientLabel1.Location = new System.Drawing.Point(3, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(541, 42);
            this.gradientLabel1.TabIndex = 2;
            this.gradientLabel1.Text = "TRAINING";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTRNDuration);
            this.panel1.Controls.Add(this.xptbPersonnel);
            this.panel1.Controls.Add(this.txtTRNMethod);
            this.panel1.Controls.Add(this.txtTRNTrainingType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTRNTitle);
            this.panel1.Controls.Add(this.dtpTRNDateFrom);
            this.panel1.Controls.Add(this.dtpTRNDateTo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTrnTitle);
            this.panel1.Controls.Add(this.txtTRNConductedBy);
            this.panel1.Controls.Add(this.txtTRNRemarks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 320);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(441, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 95;
            this.label8.Text = "hours";
            // 
            // txtTRNDuration
            // 
            this.txtTRNDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRNDuration.BackGroundColor = System.Drawing.SystemColors.Window;
            this.txtTRNDuration.BeforeTouchSize = new System.Drawing.Size(249, 20);
            this.txtTRNDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTRNDuration.IntegerValue = ((long)(1));
            this.txtTRNDuration.Location = new System.Drawing.Point(186, 137);
            this.txtTRNDuration.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTRNDuration.Name = "txtTRNDuration";
            this.txtTRNDuration.NullString = "";
            this.txtTRNDuration.Size = new System.Drawing.Size(249, 20);
            this.txtTRNDuration.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTRNDuration.TabIndex = 94;
            this.txtTRNDuration.Text = "1";
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
            this.briTRNTitle,
            this.briTRNAdd,
            this.briTRNEdit,
            this.briTRNDelete,
            this.briTRNRefresh,
            this.briTRNSave});
            this.xptbPersonnel.Bar.Manager = null;
            this.xptbPersonnel.Bar.SeparatorIndices.AddRange(new int[] {
            1});
            this.xptbPersonnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xptbPersonnel.LargeIcons = true;
            this.xptbPersonnel.Location = new System.Drawing.Point(0, 0);
            this.xptbPersonnel.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.xptbPersonnel.Name = "xptbPersonnel";
            this.xptbPersonnel.ShowChevron = true;
            this.xptbPersonnel.Size = new System.Drawing.Size(541, 25);
            this.xptbPersonnel.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.xptbPersonnel.TabIndex = 93;
            this.xptbPersonnel.Text = "Add";
            this.xptbPersonnel.Click += new System.EventHandler(this.xptbPersonnel_Click);
            // 
            // briTRNTitle
            // 
            this.briTRNTitle.BarName = "briTRNTitle";
            this.briTRNTitle.ID = "TRAINING";
            this.briTRNTitle.ShowToolTipInPopUp = false;
            this.briTRNTitle.SizeToFit = true;
            this.briTRNTitle.Text = "TRAINING";
            // 
            // briTRNAdd
            // 
            this.briTRNAdd.BarName = "briTRNAdd";
            this.briTRNAdd.DisabledImage = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRNAdd.DisabledImage")));
            this.briTRNAdd.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRNAdd.Image")));
            this.briTRNAdd.ShowToolTipInPopUp = false;
            this.briTRNAdd.SizeToFit = true;
            // 
            // briTRNEdit
            // 
            this.briTRNEdit.BarName = "briTRNEdit";
            this.briTRNEdit.DisabledImage = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRNEdit.DisabledImage")));
            this.briTRNEdit.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRNEdit.Image")));
            this.briTRNEdit.ShowToolTipInPopUp = false;
            this.briTRNEdit.SizeToFit = true;
            // 
            // briTRNDelete
            // 
            this.briTRNDelete.BarName = "briTRNDelete";
            this.briTRNDelete.DisabledImage = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRNDelete.DisabledImage")));
            this.briTRNDelete.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRNDelete.Image")));
            this.briTRNDelete.ShowToolTipInPopUp = false;
            this.briTRNDelete.SizeToFit = true;
            // 
            // briTRNRefresh
            // 
            this.briTRNRefresh.BarName = "briTRNRefresh";
            this.briTRNRefresh.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRNRefresh.Image")));
            this.briTRNRefresh.ShowToolTipInPopUp = false;
            this.briTRNRefresh.SizeToFit = true;
            // 
            // briTRNSave
            // 
            this.briTRNSave.BarName = "briTRNSave";
            this.briTRNSave.Image = ((Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)(resources.GetObject("briTRNSave.Image")));
            this.briTRNSave.ShowToolTipInPopUp = false;
            this.briTRNSave.SizeToFit = true;
            this.briTRNSave.Click += new System.EventHandler(this.briTRNSave_Click);
            // 
            // txtTRNMethod
            // 
            this.txtTRNMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRNMethod.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRNMethod.Location = new System.Drawing.Point(186, 274);
            this.txtTRNMethod.Name = "txtTRNMethod";
            this.txtTRNMethod.Size = new System.Drawing.Size(306, 26);
            this.txtTRNMethod.TabIndex = 92;
            // 
            // txtTRNTrainingType
            // 
            this.txtTRNTrainingType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRNTrainingType.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRNTrainingType.Location = new System.Drawing.Point(186, 245);
            this.txtTRNTrainingType.Name = "txtTRNTrainingType";
            this.txtTRNTrainingType.Size = new System.Drawing.Size(306, 26);
            this.txtTRNTrainingType.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 90;
            this.label7.Text = "METHOD:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "REMARKS:";
            // 
            // txtTRNTitle
            // 
            this.txtTRNTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRNTitle.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRNTitle.Location = new System.Drawing.Point(186, 50);
            this.txtTRNTitle.Name = "txtTRNTitle";
            this.txtTRNTitle.Size = new System.Drawing.Size(306, 26);
            this.txtTRNTitle.TabIndex = 88;
            // 
            // dtpTRNDateFrom
            // 
            this.dtpTRNDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTRNDateFrom.BorderColor = System.Drawing.Color.Empty;
            this.dtpTRNDateFrom.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpTRNDateFrom.DropDownImage = null;
            this.dtpTRNDateFrom.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dtpTRNDateFrom.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTRNDateFrom.Location = new System.Drawing.Point(186, 193);
            this.dtpTRNDateFrom.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpTRNDateFrom.MinValue = new System.DateTime(((long)(0)));
            this.dtpTRNDateFrom.Name = "dtpTRNDateFrom";
            this.dtpTRNDateFrom.Size = new System.Drawing.Size(306, 22);
            this.dtpTRNDateFrom.TabIndex = 87;
            this.dtpTRNDateFrom.Value = new System.DateTime(2017, 3, 10, 20, 12, 6, 918);
            // 
            // dtpTRNDateTo
            // 
            this.dtpTRNDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTRNDateTo.BorderColor = System.Drawing.Color.Empty;
            this.dtpTRNDateTo.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpTRNDateTo.DropDownImage = null;
            this.dtpTRNDateTo.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.dtpTRNDateTo.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTRNDateTo.Location = new System.Drawing.Point(186, 219);
            this.dtpTRNDateTo.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpTRNDateTo.MinValue = new System.DateTime(((long)(0)));
            this.dtpTRNDateTo.Name = "dtpTRNDateTo";
            this.dtpTRNDateTo.Size = new System.Drawing.Size(306, 22);
            this.dtpTRNDateTo.TabIndex = 86;
            this.dtpTRNDateTo.Value = new System.DateTime(2017, 3, 10, 20, 12, 6, 918);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 85;
            this.label6.Text = "TRAINING TYPE:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "DATE TO:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 83;
            this.label3.Text = "DATE FROM:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "CONDUCTED BY:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 81;
            this.label2.Text = "DURATION:";
            // 
            // lblTrnTitle
            // 
            this.lblTrnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrnTitle.AutoSize = true;
            this.lblTrnTitle.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrnTitle.Location = new System.Drawing.Point(41, 55);
            this.lblTrnTitle.Name = "lblTrnTitle";
            this.lblTrnTitle.Size = new System.Drawing.Size(43, 18);
            this.lblTrnTitle.TabIndex = 80;
            this.lblTrnTitle.Text = "TITLE:";
            // 
            // txtTRNConductedBy
            // 
            this.txtTRNConductedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRNConductedBy.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRNConductedBy.Location = new System.Drawing.Point(186, 162);
            this.txtTRNConductedBy.Name = "txtTRNConductedBy";
            this.txtTRNConductedBy.Size = new System.Drawing.Size(306, 26);
            this.txtTRNConductedBy.TabIndex = 79;
            // 
            // txtTRNRemarks
            // 
            this.txtTRNRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTRNRemarks.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRNRemarks.Location = new System.Drawing.Point(186, 82);
            this.txtTRNRemarks.Multiline = true;
            this.txtTRNRemarks.Name = "txtTRNRemarks";
            this.txtTRNRemarks.Size = new System.Drawing.Size(306, 46);
            this.txtTRNRemarks.TabIndex = 77;
            // 
            // ucTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTraining";
            this.Size = new System.Drawing.Size(547, 368);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTRNDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTRNDateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTRNDateTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTRNMethod;
        private System.Windows.Forms.TextBox txtTRNTrainingType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTRNTitle;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpTRNDateFrom;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpTRNDateTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTrnTitle;
        private System.Windows.Forms.TextBox txtTRNConductedBy;
        private System.Windows.Forms.TextBox txtTRNRemarks;
        private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xptbPersonnel;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRNAdd;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRNEdit;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRNDelete;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRNRefresh;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRNSave;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem briTRNTitle;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtTRNDuration;
        private System.Windows.Forms.Label label8;
    }
}
