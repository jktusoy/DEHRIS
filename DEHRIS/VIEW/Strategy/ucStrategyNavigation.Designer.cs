namespace DEHRIS.Strategy
{
    partial class ucStrategyNavigation
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
            Syncfusion.Windows.Forms.Tools.TextItem textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem8 = new Syncfusion.Windows.Forms.Tools.TextItem();
            this.hubTile1 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.gridBagLayout1 = new Syncfusion.Windows.Forms.Tools.GridBagLayout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridBagLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // hubTile1
            // 
            textItem5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem5.Text = "something";
            textItem5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hubTile1.Banner = textItem5;
            this.hubTile1.BannerIcon = global::DEHRIS.Properties.Resources.attachment;
            textItem6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem6.HubTile = this.hubTile1;
            textItem6.Text = "THIS IS A BODY HEADER THAT IS HELPFUL";
            textItem6.TextColor = System.Drawing.Color.Black;
            this.hubTile1.Body = textItem6;
            this.hubTile1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem7.Text = "something this is";
            textItem7.TextColor = System.Drawing.Color.Black;
            this.hubTile1.Footer = textItem7;
            this.hubTile1.HoveredBorderColor = System.Drawing.Color.Red;
            this.hubTile1.IsSelectionMarked = true;
            this.hubTile1.Location = new System.Drawing.Point(207, 169);
            this.hubTile1.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile1.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile1.Name = "hubTile1";
            this.hubTile1.SelectionArrowColor = System.Drawing.Color.DarkRed;
            this.hubTile1.ShowBanner = true;
            this.hubTile1.ShowBannerIcon = true;
            this.hubTile1.ShowRotateTileBanner = true;
            this.hubTile1.Size = new System.Drawing.Size(241, 120);
            this.hubTile1.SwitchRotateTileBannerVisibility = true;
            this.hubTile1.TabIndex = 0;
            this.hubTile1.TileType = Syncfusion.Windows.Forms.Tools.HubTileType.RotateTile;
            textItem8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.hubTile1.Title = textItem8;
            this.hubTile1.TurnLiveTileOn = true;
            // 
            // gridBagLayout1
            // 
            this.gridBagLayout1.ContainerControl = this;
            // 
            // ucStrategyNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hubTile1);
            this.Name = "ucStrategyNavigation";
            this.Size = new System.Drawing.Size(655, 459);
            ((System.ComponentModel.ISupportInitialize)(this.gridBagLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.HubTile hubTile1;
        private Syncfusion.Windows.Forms.Tools.GridBagLayout gridBagLayout1;

    }
}
