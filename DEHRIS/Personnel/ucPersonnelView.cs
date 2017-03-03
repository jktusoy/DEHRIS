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

namespace DEHRIS.Importer
{
    public partial class ucPersonnelView : UserControl
    {
        public ucPersonnelView()
        {
            InitializeComponent();

            ExcelEngine excelEngine = new ExcelEngine();



            //IApplication application = excelEngine.Excel;

            //application.DefaultVersion = ExcelVersion.Excel2013;

            //IWorkbook sourceWorkbook = application.Workbooks.Open();
            //sourceWorkbook.Activate();
            //int maxcount = sourceWorkbook.MaxColumnCount;
            this.spreadsheet1.Open(@"C:\Users\user\Desktop\WORKSPACE\temptemp.xlsx");
      
            //this.spreadsheet1.AddSheet(sourceWorkbook.ActiveSheet,0);

            //   IWorkbook destinationWorkbook = application.Workbooks.Open("DestinationWorkbookTemplate.xlsx");

            //Copy first worksheet from the Source workbook to the destination workbook.

            //destinationWorkbook.Worksheets.AddCopy(sourceWorkbook.Worksheets[0]);

            //destinationWorkbook.ActiveSheetIndex = 1;

            //destinationWorkbook.SaveAs("CopiedWorkbook.xlsx");

            //sourceWorkbook.Close();

            //destinationWorkbook.Close();
            excelEngine.Dispose();
            //this.spreadsheet1.AddSheet()
        }

 




        private void spreadsheet1_Click(object sender, EventArgs e)
        {
        
        }

        private void tabBarPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
