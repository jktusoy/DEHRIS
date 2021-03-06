﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEHRIS.VIEW;
using DEHRIS.VIEW.Tools;
namespace DEHRIS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void DefaultView()
        {
            Navigation.ucNavigation _ucnavigation = new Navigation.ucNavigation();
            gpNavigation.Controls.Clear();
            gpNavigation.Controls.Add(_ucnavigation);
            _ucnavigation.Dock = DockStyle.Fill;

            Home.ucHomePanel _ucHomeView = new Home.ucHomePanel();
            gpMain.Controls.Clear();
            gpMain.Controls.Add(_ucHomeView);
            _ucHomeView.Dock = DockStyle.Fill;
        
        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

        private void tlsbtVMG_Click(object sender, EventArgs e)
        {
            Organization.ucVMG iucVMG = new Organization.ucVMG();
            gpMain.Controls.Clear();
            gpMain.Controls.Add(iucVMG);
            iucVMG.Dock = DockStyle.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Organization.ucOrganizationalChart iucOrgChart = new Organization.ucOrganizationalChart();
            gpMain.Controls.Clear();
            gpMain.Controls.Add(iucOrgChart);
            iucOrgChart.Dock = DockStyle.Fill;
        }

        private void tsBtnImporter_Click(object sender, EventArgs e)
        {
            ucImportTool iucImport = new  ucImportTool();
            gpMain.Controls.Clear();
            gpMain.Controls.Add(iucImport);
            iucImport.Dock = DockStyle.Fill;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DefaultView();
            
            this.tabControlAdv1.ShowTabCloseButton = true;

            //Restrict the close button to be shown only for the active tab pages

            this.tabControlAdv1.ShowCloseButtonForActiveTabOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Home.ucHomePanel iucHome = new Home.ucHomePanel();
            gpMain.Controls.Clear();
            gpMain.Controls.Add(iucHome);
            iucHome.Dock = DockStyle.Fill;
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            Dashboard.Reports.ucDashboard iucDashboard = new Dashboard.Reports.ucDashboard();
            gpMain.Controls.Clear();
            gpMain.Controls.Add(iucDashboard);
            iucDashboard.Dock = DockStyle.Fill;
        }

        private void tsbIPCR_Click(object sender, EventArgs e)
        {
            Tool.ucSpreadsheet ucspreadsheet = new Tool.ucSpreadsheet(@"C:\Users\Cocoypower\Source\Repo\DEHRIS\ExternalFiles\OPCR.xls");
            gpMain.Controls.Clear();
            gpMain.Controls.Add(ucspreadsheet);
            ucspreadsheet.Dock = DockStyle.Fill;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Tool.ucBrowser ucBrowser = new Tool.ucBrowser();
           
            gpMain.Controls.Clear();
            gpMain.Controls.Add(ucBrowser);
            ucBrowser.Dock = DockStyle.Fill;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Organization.ucViewOrgChar ucOrgChar = new Organization.ucViewOrgChar();

            gpMain.Controls.Clear();
            gpMain.Controls.Add(ucOrgChar);
            ucOrgChar.Dock = DockStyle.Fill;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.frmLogin frmlog = new Home.frmLogin();
            frmlog.Show();
            this.Hide();
        }

        private void tsbEvents_Click(object sender, EventArgs e)
        {
            Others.Form2 myForm = new Others.Form2();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            gpMain.Controls.Clear();
            gpMain.Controls.Add(myForm); 
            myForm.Show();
        }

        private void tsbPMTraining_Click(object sender, EventArgs e)
        {
            //Personnel.Modules.ucTrainingView ucTrn = new Personnel.Modules.ucTrainingView();

            //gpMain.Controls.Clear();
            //gpMain.Controls.Add(ucTrn);
            //ucTrn.Dock = DockStyle.Fill;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CONTROLLER.Helper.PromotionNavigation.TrainingView(gpMain);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            CONTROLLER.Helper.PromotionNavigation.TrainingView2(gpMain);
        }

      


    }
}
