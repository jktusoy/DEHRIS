﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.SVG.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Reflection;

namespace DEHRIS.Organization
{
    public partial class ucViewOrgChar : UserControl
    {
        //public ucViewOrgChar()
        //{
        //    InitializeComponent();
        //    diagram2.Load(@"C:\Users\Cocoypower\Source\Repo\DEHRIS\Resources\doc1.edd");
        //}



        #region Members
        Syncfusion.Windows.Forms.Diagram.Label lbl;
        bool needSave = false;
        public string fileName;
        #endregion

        #region Form Initialize
        public ucViewOrgChar()
        {

            InitializeComponent();
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            //string fullPath = Path.Combine(exeDir, "..\\..\\Resources\\Texture.dds");
            paletteGroupBar1.LoadPalette(@"C:\Users\Cocoypower\Source\Repo\DEHRIS\Resources\Flowchart Symbols.edp");
            //  paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\..\Common\Data\Diagram\edp\Flowchart Symbols.edp");

            this.diagram2.BeginUpdate();
            this.diagram2.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram2.Model.BoundaryConstraintsEnabled = false;
            diagram2.Model.HistoryManager.Pause();
          
            diagram2.Model.HistoryManager.Resume();
            this.diagram2.View.SelectionList.Clear();
            GroupBarAppearance();
            this.diagram2.EndUpdate();

            // Wire up OnIdle processing
            Application.Idle += new EventHandler(Application_Idle);
        }
        #endregion

        #region Initailize Diagram with nodes
        /// <summary>
        /// Initialize the diagram
        /// </summary>
        protected void InitailizeDiagram()
        {
            // Add a TextNode to highlight the Diagram Name
         
        }

        /// <summary>
        /// Insert the node
        /// </summary>
        /// <param name="strText">TextNode's text</param>
        /// <param name="ptPinPoint">Node's Location </param>
        /// <param name="nodeSize">Node's size</param>
        /// <returns>returns the node</returns>
        private TextNode InsertTextNode(string strText, PointF ptPinPoint, SizeF nodeSize)
        {
            Syncfusion.Windows.Forms.Diagram.TextNode txtnode = new TextNode(strText);

            txtnode.FontStyle.Size = 10;
            txtnode.FontStyle.Family = "Arial";
            txtnode.FontColorStyle.Color = Color.Black;
            txtnode.LineStyle.LineColor = Color.Transparent;
            txtnode.Size = nodeSize;

            InsertNode(txtnode, ptPinPoint);
            return txtnode;
        }

        /// <summary>
        /// Inserts the node
        /// </summary>
        /// <param name="node">Node</param>
        /// <param name="ptPinPoint">Node's Location</param>
        /// <returns>returns the node</returns>
        private Node InsertNode(Node node, PointF ptPinPoint)
        {
            MeasureUnits units = MeasureUnits.Pixel;
            SizeF szPinOffset = ((IUnitIndependent)node).GetPinPointOffset(units);
            ptPinPoint.X += szPinOffset.Width;
            ptPinPoint.Y += szPinOffset.Height;
            ((IUnitIndependent)node).SetPinPoint(ptPinPoint, units);
            node.EnableCentralPort = true;
            this.diagram2.Model.AppendChild(node);
            return node;
        }

        /// <summary>
        /// Insert the node from palette
        /// </summary>
        /// <param name="name">Node name</param>
        /// <param name="ptPinPoint">Node location</param>
        /// <param name="label">Label's text</param>
        /// <param name="nodeSize">Node size</param>
        /// <returns>returns the node</returns>
        private Node InsertNodeFromPallete(string name, PointF ptPinPoint, string label, SizeF nodeSize)
        {
            Node node = null;
            NodeCollection nodes = paletteGroupBar1.CurrentSymbolPalette.Nodes;

            if (name != null)
            {
                node = (Node)nodes[name].Clone();
                InsertNode(node, ptPinPoint);
            }

            //Set Node's size
            node.Size = nodeSize;
            //Add labels to node
            lbl = new Syncfusion.Windows.Forms.Diagram.Label(node, label);
            lbl.FontStyle.Family = "Arial";
            ((PathNode)node).Labels.Add(lbl);

            return node;
        }

        /// <summary>
        /// Connects the node
        /// </summary>
        /// <param name="parentNode">parent node</param>
        /// <param name="subNode">child node</param>
        private void ConnectNodes(Node parentNode, Node subNode)
        {
            if (parentNode.CentralPort == null || subNode.CentralPort == null)
                return;

            this.diagram2.Model.BeginUpdate();
            // Create directed link
            PointF[] pts = new PointF[] { PointF.Empty, new PointF(0, 1) };
            OrthogonalConnector line = new OrthogonalConnector(pts[0], pts[1]);
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            line.HeadDecorator.FillStyle.Color = Color.Black;
            line.LineStyle.LineColor = Color.Black;
            this.diagram2.Model.AppendChild(line);
            //Connect connectors's end points to the node ports. 
            parentNode.CentralPort.TryConnect(line.TailEndPoint);
            subNode.CentralPort.TryConnect(line.HeadEndPoint);
            this.diagram2.Model.SendToBack(line);
            this.diagram2.Model.EndUpdate();
        }

        /// <summary>
        /// Connect the nodes
        /// </summary>
        /// <param name="parentNode">parent node</param>
        /// <param name="position">node's position</param>
        private void ConnectNodes(Node parentNode, string position)
        {
            if (parentNode.CentralPort == null)
                return;
            PointF[] pts;
            OrthogonalConnector line;
            this.diagram2.Model.BeginUpdate();

            // Create directed link
            if (position == "right")
            {
                pts = new PointF[] { parentNode.PinPoint, new PointF(parentNode.PinPoint.X + 200, parentNode.PinPoint.Y) };
                line = new OrthogonalConnector(pts[0], pts[1]);
            }
            else
            {
                pts = new PointF[] { parentNode.PinPoint, new PointF(parentNode.PinPoint.X - 150, parentNode.PinPoint.Y + 220) };
                line = new OrthogonalConnector(pts[0], pts[1], true);
            }
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            line.HeadDecorator.FillStyle.Color = Color.Black;
            line.LineStyle.LineColor = Color.Black;

            this.diagram2.Model.AppendChild(line);

            parentNode.CentralPort.TryConnect(line.TailEndPoint);
            this.diagram2.Model.SendToBack(line);

            this.diagram2.Model.EndUpdate();
        }
        #endregion

        #region ChangeApperance of controls
        /// <summary>
        /// Change's the appearance of GroupBar
        /// </summary>
        private void GroupBarAppearance()
        {
            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = 80;
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.FlatLook = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        /// <summary>
        /// Sets the Appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {
            this.diagram2.HorizontalRuler.BackgroundColor = Color.White;
            this.diagram2.VerticalRuler.BackgroundColor = Color.White;
            this.diagram2.View.Grid.GridStyle = GridStyle.Line;
            this.diagram2.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.diagram2.View.Grid.Color = Color.LightGray;
            this.diagram2.View.Grid.VerticalSpacing = 15;
            this.diagram2.View.Grid.HorizontalSpacing = 15;
            this.diagram2.Model.BackgroundStyle.GradientCenter = 0.5f;
            this.diagram2.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram2.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram2.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram2.View.Grid.Visible = false;
            this.diagram2.View.BackgroundColor = Color.White;
            this.diagram2.Model.DocumentSize = new PageSize(500, 500);
            this.diagram2.View.SelectionList.Clear();
        }

        #endregion

        #region Properties

        public bool SaveChanges
        {
            get
            {
                if (diagram2.Model.Modified || needSave)
                    return true;
                else
                    return false;
            }
            set
            {
                needSave = value;
            }
        }

        public bool HasFileName
        {
            get
            {
                return (this.fileName != null && this.fileName.Length > 0);
            }
        }

        #endregion

        #region Event Handlers



        void Application_Idle(object sender, EventArgs e)
        {
            if (this.diagram2 != null && this.diagram2.Model != null)
            {
                this.saveToolStripButton.Enabled = true;
                this.saveAsToolStripButton.Enabled = true;
                this.cutToolStripButton.Enabled = diagram2.CanCut;
                this.copyToolStripButton.Enabled = diagram2.CanCopy;
                //if (this.WindowState != FormWindowState.Minimized)
                this.pasteToolStripButton.Enabled = diagram2.CanPaste;
                this.undoToolStripButton.Enabled = diagram2.Model.HistoryManager.CanUndo;
                this.redoToolStripButton.Enabled = diagram2.Model.HistoryManager.CanRedo;
                this.deleteToolStripButton.Enabled = (this.diagram2.View.SelectionList.Count > 0);

            }
            else
            {
                this.saveToolStripButton.Enabled = false;
                this.saveAsToolStripButton.Enabled = false;
                this.cutToolStripButton.Enabled = false;
                this.copyToolStripButton.Enabled = false;
                //if (this.WindowState != FormWindowState.Minimized)
                //    this.pasteToolStripButton.Enabled = false;
                this.undoToolStripButton.Enabled = false;
                this.redoToolStripButton.Enabled = false;
                this.deleteToolStripButton.Enabled = false;
            }
        }

        #region MenuTools

        private void CoonectorToolStripDropDownButton_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in CoonectorToolStripDropDownButton.DropDownItems)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }
            (e.ClickedItem as ToolStripMenuItem).Checked = true;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.HasFileName)
                    {
                        this.saveFileDialog1.FileName = this.fileName;
                    }
                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                        diagram2.Model.Clear();
                        Model model = new Model();
                        model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        model.LineStyle.LineColor = Color.LightGray;
                        diagram2.Model = model;
                    }
                }
                else if (res == DialogResult.No)
                {
                    diagram2.Model.Clear();
                    Model model = new Model();
                    model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    model.LineStyle.LineColor = Color.LightGray;
                    diagram2.Model = model;
                }
            }
            else
            {
                diagram2.Model.Clear();
                Model model = new Model();
                model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                model.LineStyle.LineColor = Color.LightGray;
                diagram2.Model = model;
            }
            this.fileName = "";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.SaveChanges)
            {
                DialogResult res = MessageBoxAdv.Show(this, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.saveFileDialog1.FileName = "Diagram";
                    saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    saveFileDialog1.Title = "Save File As:";

                    if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        this.fileName = this.saveFileDialog1.FileName;
                        SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
                    }

                    this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    this.openFileDialog1.Title = "Open Diagram";
                    this.openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                        }
                    }
                }
                else if (res == DialogResult.No)
                {
                    this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                    this.openFileDialog1.Title = "Open Diagram";
                    this.openFileDialog1.FileName = "";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openFileDialog1.FileName))
                        {
                            OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                        }
                    }
                }
            }
            else
            {
                this.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*";
                this.openFileDialog1.Title = "Open Diagram";
                this.openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                    }
                }
            }
            this.fileName = openFileDialog1.FileName;
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName))
            {
                saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            diagram2.SaveBinary(saveFileDialog1.FileName);
                            break;
                        case 2:
                            diagram2.SaveSoap(saveFileDialog1.FileName);
                            break;
                    }
                    this.fileName = saveFileDialog1.FileName;
                }
            }
            else
            {
                FileInfo fi = new FileInfo(fileName);
                if (fi.Extension == ".edd")
                {
                    diagram2.SaveBinary(fi.FullName);
                }
                else if (fi.Extension == ".xml")
                {
                    diagram2.SaveSoap(fi.FullName);
                }
            }
        }

        private void undoToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram2.Model.HistoryManager.Undo();
        }

        private void redoToolStripButton_Click(object sender, EventArgs e)
        {
            this.diagram2.Model.HistoryManager.Redo();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            diagram2.Controller.Cut();
            this.pasteToolStripButton.Enabled = true;
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            diagram2.Controller.Copy();
            this.pasteToolStripButton.Enabled = true;
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            diagram2.Controller.Paste();
            this.pasteToolStripButton.Enabled = false;
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            diagram2.Model.BeginUpdate();
            diagram2.Controller.Delete();
            diagram2.Model.EndUpdate();
        }


        private void resetToolStripButton_Click(object sender, EventArgs e)
        {
            diagram2.View.ZoomToActual();
        }

        private void pageSettingsToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram2 != null && this.diagram2.Model != null)
            {
                Syncfusion.Windows.Forms.Diagram.PageSetupDialog dlgPrintSetup = new Syncfusion.Windows.Forms.Diagram.PageSetupDialog(this.diagram2.View);

                // Made to make values more user friendly 
                dlgPrintSetup.PrintSettings = this.diagram2.View.PageSettings;
                dlgPrintSetup.PrintZoom = this.diagram2.View.PrintZoom;

                if (dlgPrintSetup.ShowDialog() == DialogResult.OK)
                {
                    this.diagram2.View.PageSettings = dlgPrintSetup.PrintSettings;
                    this.diagram2.View.PrintZoom = dlgPrintSetup.PrintZoom;
                    this.diagram2.View.RefreshPageSettings();
                }
            }
        }

        private void previewToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram2 != null)
            {
                PrintDocument printDoc = this.diagram2.CreatePrintDocument();
                PrintPreviewDialog printPreviewDlg = new PrintPreviewDialog();

                printDoc.PrinterSettings.FromPage = 0;
                printDoc.PrinterSettings.ToPage = 0;
                printDoc.PrinterSettings.PrintRange = PrintRange.AllPages;

                printPreviewDlg.Document = printDoc;
                printPreviewDlg.ShowDialog(this);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.diagram2 != null)
            {
                PrintDocument printDoc = this.diagram2.CreatePrintDocument();
                PrintDialog printDlg = new PrintDialog();
                printDlg.Document = printDoc;
                printDlg.UseEXDialog = true;
                printDlg.AllowSomePages = true;

                if (printDlg.ShowDialog(this) == DialogResult.OK)
                {
                    printDoc.PrinterSettings = printDlg.PrinterSettings;
                    printDoc.Print();
                }
            }
        }

        private void showGridToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.diagram2.View.Grid.Visible)
                this.diagram2.View.Grid.Visible = false;
            else
                this.diagram2.View.Grid.Visible = true;
        }

        private void snapToGridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (diagram2.View.Grid.SnapToGrid)
                diagram2.View.Grid.SnapToGrid = false;
            else
                diagram2.View.Grid.SnapToGrid = true;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://help.syncfusion.com/";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "Diagram";
            saveFileDialog1.Filter = @"EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml";
            saveFileDialog1.Title = "Save File As:";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        diagram2.SaveBinary(saveFileDialog1.FileName);
                        break;
                    case 2:
                        diagram2.SaveSoap(saveFileDialog1.FileName);
                        break;
                    default:
                        diagram2.SaveBinary(saveFileDialog1.FileName);
                        break;
                }
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"W3C Portable Network Graphics(*.png)|*.png";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Png;
                SaveImage(saveFileDialog1.FileName, imgformat);
            }
            else
            {
                return;
            }
        }

        private void jPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Joint Photographic Experts Group(*.jpeg)|*.jpeg";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Jpeg;
                SaveImage(saveFileDialog1.FileName, imgformat);
            }
            else
            {
                return;
            }
        }

        private void gIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Graphics Interchange Format(*.gif)|*.gif";
            saveFileDialog1.Title = "Export Diagram As:";
            this.saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imgformat = ImageFormat.Gif;
                SaveImage(saveFileDialog1.FileName, imgformat);

            }
            else
            {
                return;
            }
        }

        private void sVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = @"Scalable Vector Graphics Format(*.svg)|*.svg";
            saveFileDialog1.Title = "Export Diagram As:";
            saveFileDialog1.FileName = "Diagram";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ToSvg tosvg = new ToSvg();
                // Get Diagram Nodes Bounding Rectangle.
                RectangleF rectBounding = this.diagram2.Model.GetBoundingRect();
                Graphics gfx = tosvg.GetRealGraphics(new Size((int)rectBounding.Width, (int)rectBounding.Height));
                this.diagram2.ExportDiagramToGraphics(gfx);
                tosvg.Save(saveFileDialog1.FileName);

            }
            else
            {
                return;
            }
        }

        private void lineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool(new LineConnectorTool(this.diagram2.Controller));
        }

        private void orthogonalConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool(new OrthogonalConnectorTool(this.diagram2.Controller));
        }

        private void polylineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolyLineConnectorTool polyTool = new PolyLineConnectorTool(this.diagram2.Controller);
            polyTool.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            polyTool.HeadDecorator.Size = new SizeF(6, 6);
            diagram2.Controller.ActivateTool(polyTool);
        }

        private void bezierConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("BezierTool");
        }

        private void splineConnectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveTool("SplineTool");
        }

        private void panToolStripButton_Click(object sender, EventArgs e)
        {
            SetActiveTool("PanTool");
        }


        private void FillStyleToolStripButton_Click(object sender, EventArgs e)
        {
            if (diagram2.View.SelectionList != null && diagram2.View.SelectionList.Count > 0)
            {
                FillStyleDialog fsd = new FillStyleDialog();
                FillStyle fs = null;
                if (DialogResult.OK == fsd.ShowDialog())
                {
                    diagram2.BeginUpdate();

                    foreach (Node node in this.diagram2.View.SelectionList)
                    {
                        if (node is FilledPath)
                        {
                            fs = (FillStyle)TypeDescriptor.GetProperties(node, false)["FillStyle"].GetValue(node);
                            if (fs != null)
                            {
                                fs.Color = fsd.FillStyle.Color;
                                fs.ForeColor = fsd.FillStyle.ForeColor;
                                fs.ColorAlphaFactor = fsd.FillStyle.ColorAlphaFactor;
                                fs.ForeColorAlphaFactor = fsd.FillStyle.ForeColorAlphaFactor;
                                fs.Type = fsd.FillStyle.Type;
                                fs.GradientAngle = fsd.FillStyle.GradientAngle;
                                fs.GradientCenter = fsd.FillStyle.GradientCenter;
                                fs.PathBrushStyle = fsd.FillStyle.PathBrushStyle;
                                fs.HatchBrushStyle = fsd.FillStyle.HatchBrushStyle;
                                fs.Texture = fsd.FillStyle.Texture;
                                fs.TextureWrapMode = fsd.FillStyle.TextureWrapMode;
                            }
                        }
                        else if (node is ConnectorBase)
                        {
                            ((ConnectorBase)node).LineStyle.LineColor = fsd.FillStyle.Color;
                            ((ConnectorBase)node).HeadDecorator.FillStyle.Color = fsd.FillStyle.Color;
                            ((ConnectorBase)node).HeadDecorator.LineStyle.LineColor = fsd.FillStyle.Color;
                        }
                    }
                    diagram2.EndUpdate();
                }
            }
        }

        private void LineStyleToolStripButton_Click(object sender, EventArgs e)
        {
            if (diagram2.View.SelectionList != null && diagram2.View.SelectionList.Count > 0)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.diagram2.BeginUpdate();
                    foreach (Node node in diagram2.View.SelectionList)
                    {
                        node.LineStyle.LineColor = colorDialog1.Color;
                    }
                    diagram2.EndUpdate();
                }
            }
        }

        private void shadowToolStripButton_Click(object sender, EventArgs e)
        {
            if (diagram2.View.SelectionList != null && diagram2.View.SelectionList.Count > 0)
            {
                ShadowStyleDialog ssd = new ShadowStyleDialog();
                ShadowStyle fs = null;
                if (DialogResult.OK == ssd.ShowDialog())
                {
                    diagram2.BeginUpdate();
                    foreach (Node node in this.diagram2.View.SelectionList)
                    {
                        if (!(node is ConnectorBase) && !(node is TextNode))
                        {
                            fs = (ShadowStyle)TypeDescriptor.GetProperties(node, false)["ShadowStyle"].GetValue(node);
                            if (fs != null)
                            {
                                fs.Color = ssd.ShadowStyle.Color;
                                fs.ForeColor = ssd.ShadowStyle.ForeColor;
                                fs.ColorAlphaFactor = ssd.ShadowStyle.ColorAlphaFactor;
                                fs.ForeColorAlphaFactor = ssd.ShadowStyle.ForeColorAlphaFactor;
                                fs.PathBrushStyle = ssd.ShadowStyle.PathBrushStyle;
                                fs.OffsetX = ssd.ShadowStyle.OffsetX;
                                fs.OffsetY = ssd.ShadowStyle.OffsetY;
                                fs.Visible = ssd.ShadowStyle.Visible;
                            }
                        }
                    }
                    diagram2.EndUpdate();
                }
            }

        }

        private void shadingToolStripButton_Click(object sender, EventArgs e)
        {
            if (diagram2.View.SelectionList != null && diagram2.View.SelectionList.Count > 0)
            {
                diagram2.BeginUpdate();
                foreach (Node node in diagram2.View.SelectionList)
                {
                    if (node is FilledPath)
                    {
                        FilledPath filledPath = (FilledPath)node;
                        filledPath.EnableShading = !filledPath.EnableShading;
                    }
                }
                diagram2.EndUpdate();
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram2.View.ZoomOut();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram2.View.ZoomIn();
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagram2.View.ZoomToActual();
        }

        #endregion

        #endregion

        #region Helper Methods
        //Save diagram as Image
        private void SaveImage(string filename, ImageFormat imageformat)
        {
            Image img = this.diagram2.View.ExportDiagramAsImage(false);
            img.Save(filename, imageformat);
        }

        //Save diagram
        private void SaveDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
                    diagram2.SaveBinary(filename);
                    break;
                case 2:
                    diagram2.SaveSoap(filename);
                    break;
                default:
                    diagram2.SaveBinary(filename);
                    break;
            }
        }

        //Open Diagram
        private void OpenDiagramAs(string filename, int index)
        {
            switch (index)
            {
                case 1:
                    diagram2.LoadBinary(filename);
                    break;
                case 2:
                    diagram2.LoadSoap(filename);
                    break;
                default:
                    diagram2.LoadBinary(filename);
                    break;
            }
        }

        private void SetActiveTool(string toolName)
        {
            this.diagram2.Controller.ActivateTool(toolName);
        }
        private void SetActiveTool(LineBaseTool tool)
        {
            tool.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;
            tool.HeadDecorator.Size = new SizeF(6, 6);
            this.diagram2.Controller.ActivateTool(tool);
        }
        #endregion

        private void diagram2_Click(object sender, EventArgs e)
        {

        }

    }
}
