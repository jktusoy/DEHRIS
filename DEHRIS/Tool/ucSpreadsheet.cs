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

        public void LoadSpreadsheet(string filepath)
        {

            spreadsheet1.Open(filepath);
            spreadsheet1.Show();

            //Access the first worksheet from the workbook instance.
            IWorksheet worksheet = spreadsheet1.Workbook.Worksheets[0];

            //Read/access the value of the cell (B3)
            MessageBox.Show(worksheet["A1"].Text);
         
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
