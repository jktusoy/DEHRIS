using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;

namespace DEHRIS.Tool
{
    public partial class ucSpreadsheet : UserControl
    {



        public ucSpreadsheet()
        {
            InitializeComponent();
        }

        public ucSpreadsheet(string filepath)
        {
            InitializeComponent();
       
            spreadsheet1.Open(filepath);
            spreadsheet1.Show();
 
            MessageBox.Show(spreadsheet1.Workbook.Worksheets.Count.ToString());
            MessageBox.Show(spreadsheet1.Workbook.Worksheets.Count.ToString());
        }

 
        public void FillUpForms(List<MODEL.Data.Applicants> applist, int templateID)
        {

            MessageBox.Show("");

            DEHRIS.Others.CustomPopUpNotifier customnotif = new Others.CustomPopUpNotifier();
            customnotif.SetNotification(Others.CustomPopUpNotifier.NotificationType.Successful, "Record successfully updated.");

            IWorksheet worksheet = spreadsheet1.Workbook.Worksheets[1];//int)item.WorksheetNo+1
         


           CONTROLLER.ImportController impCont = new CONTROLLER.ImportController();
           List<MODEL.Data.TemplateImportDetails> imporDet = impCont.GetTemplateImport(templateID).TemplateImportDetails;
            
            foreach (var item in imporDet)
	        {
                for (int i = 1; i < applist.Count; i++)
			    {
                    int p = 10 + i;
                   
                    int counnnnt = spreadsheet1.Workbook.Worksheets.Count;
                    string name = spreadsheet1.FileName;
                    switch (item.Columnname)
                    {
                        case "fullname":
                            worksheet[item.Address + p.ToString()].Text = applist[i].Fullname;
                            break;
                        case "telephoneNo":
                            worksheet[item.Address + p.ToString()].Text = applist[i].TelephoneNo;
                            break;
                        case "cellphoneNo":
                            worksheet[item.Address + p.ToString()].Text = applist[i].CellphoneNo;
                            break;
                        case "emailAddress":
                            worksheet[item.Address + p.ToString()].Text = applist[i].EmailAddress;
                            break;
                        case "eligibility":
                            worksheet[item.Address + p.ToString()].Text = applist[i].Eligibility;
                            break;
                        case "remarks":
                            worksheet[item.Address + p.ToString()].Text = applist[i].PresentAddress;
                            break;

                        default:
                            break;
                    }
                
			    }
                //IWorksheet worksheets = spreadsheet1.Workbook.Worksheets[(int)item.WorksheetNo];
                //worksheets = spreadsheet1.Workbook.Worksheets[1];
                //worksheets["C12"].Text = "FASDFASFSDF";


	        }
         
          
                
        }



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spreadsheet1_Click(object sender, EventArgs e)
        {
          
        }

        private void xpToolBar1_Click(object sender, EventArgs e)
        {
            IWorksheet worksheet = spreadsheet1.Workbook.Worksheets[0];
            MODEL.Data.Applicants app = new MODEL.Data.Applicants();
            CONTROLLER.ApplicantController appCtlr = new CONTROLLER.ApplicantController();
            CONTROLLER.ImportController importcontroller = new CONTROLLER.ImportController();
            List<MODEL.Data.TemplateImportDetails> detailler = importcontroller.GetTemplateImport(1).TemplateImportDetails; //later should not be hardcoded

            for (int i = 4; i < 20; i++) //later should not be 4
            {
                foreach (var item in detailler)
                {
                    if (item.Address.ToString().Length > 0)
                    {
                        string vall = worksheet[item.Address + i.ToString()].Text;
                        ComposeClass(app, FirstCharToUpper(item.Columnname), vall);
                    }
                }
                appCtlr.Add(app);
            }

            //Read/access the value of the cell (B3)
        
        }


      


        public  string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        public void ComposeClass(object obj, string column, string value)
        {
            if (obj.GetType().GetProperty(column) != null)
            {
                obj.GetType().GetProperty(column).SetValue(obj,value,null);

            }
        }
    
    }
}
