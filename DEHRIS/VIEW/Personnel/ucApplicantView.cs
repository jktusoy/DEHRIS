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
using DEHRISAPI;
using DEHRISModel.Data;
namespace DEHRIS.Importer
{
    public partial class ucApplicantView : UserControl
    {
        public ucApplicantView()
        {
            InitializeComponent();


            DEHRISAPI.PersonnelUtility prodUtil = new PersonnelUtility();
          //  objlPersonnelView.SetObjects(prodUtil.GetPersonnel());
            //IApplication application = excelEngine.Excel;


            //application.DefaultVersion = ExcelVersion.Excel2013;

            //IWorkbook sourceWorkbook = application.Workbooks.Open();
            //sourceWorkbook.Activate();
            //int maxcount = sourceWorkbook.MaxColumnCount;
            //  this.spreadsheet1.Open(@"C:\Users\user\Desktop\WORKSPACE\temptemp.xlsx");

            //this.spreadsheet1.AddSheet(sourceWorkbook.ActiveSheet,0);

            //   IWorkbook destinationWorkbook = application.Workbooks.Open("DestinationWorkbookTemplate.xlsx");

            //Copy first worksheet from the Source workbook to the destination workbook.

            //destinationWorkbook.Worksheets.AddCopy(sourceWorkbook.Worksheets[0]);

            //destinationWorkbook.ActiveSheetIndex = 1;

            //destinationWorkbook.SaveAs("CopiedWorkbook.xlsx");

            //sourceWorkbook.Close();

            //destinationWorkbook.Close();
            //excelEngine.Dispose();
            //this.spreadsheet1.AddSheet()
        }






        private void spreadsheet1_Click(object sender, EventArgs e)
        {

        }

        private void tabBarPage1_Click(object sender, EventArgs e)
        {

        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void objlPersonnelView_SelectionChanged(object sender, EventArgs e)
        {
            SetEditable(false);
            DEHRISModel.Data.Personnel selectePersonnel = (DEHRISModel.Data.Personnel)objlPersonnelView.SelectedObject;
            ShowViewData(selectePersonnel);
        }

        //public enum Status { Active = 0, Canceled = 3 }; 
        //Setting the drop down values from it

        //cbStatus.DataSource = Enum.GetValues(typeof(Status));
        //Getting the enum from the selected item

        //Status status; 
        //Enum.TryParse<Status>(cbStatus.SelectedValue.ToString(), out status); 
        //public void PopulateComboBox(Combo)
        //{

        //    ArrayList USStates = new ArrayList();
        //    USStates.Add(new USState("Alaska", "AK", 1));
        //    USStates.Add(new USState("Arizona", "AZ", 2));
        //    USStates.Add(new USState("Arkansas", "AK", 3));
        //}

        private void ShowViewData(DEHRISModel.Data.Personnel ppersonnel)
        {
            // txtPrBirthPlace
            txtPrCitizenship.Text = ppersonnel.Citizenship;
            txtPrBirthPlace.Text = ppersonnel.PermanenetAddress.AddressName;
            txtPrFirstname.Text = ppersonnel.Firstname;
            txtPrHeight.Text = ppersonnel.Height;
            txtPrLastname.Text = ppersonnel.Lastname;
            txtPrMiddlename.Text = ppersonnel.Middlename;
            txtPrNameExt.Text = ppersonnel.NameExtension;
            txtPrWeight.Text = ppersonnel.Weight;
            cbBloodType.Text = ppersonnel.Bloodtype;
            cbCivilStatus.Text = ppersonnel.Civilstatus;
            cBirthDate.Text = ppersonnel.DateOfBirth.ToShortDateString();
        }


        private void SetEditable(bool iseditable)
        {
            // txtPrBirthPlace
            if (iseditable)
            {
                txtPrCitizenship.ReadOnly = false;
                txtPrFirstname.ReadOnly = false;
                txtPrHeight.ReadOnly = false;
                txtPrLastname.ReadOnly = false;
                txtPrMiddlename.ReadOnly = false;
                txtPrNameExt.ReadOnly = false;
                txtPrWeight.ReadOnly = false;
                //cbBloodType. = false;
                //cbCivilStatus.ReadOnly = false;
                //cBirthDate.ReadOnly = false;
            }
            else
            {
                txtPrCitizenship.ReadOnly = true;
                txtPrFirstname.ReadOnly = true;
                txtPrHeight.ReadOnly = true;
                txtPrLastname.ReadOnly = true;
                txtPrMiddlename.ReadOnly = true;
                txtPrNameExt.ReadOnly = true;
                txtPrWeight.ReadOnly = true;
            }

        }



        private void ClearViewData()
        {
            // txtPrBirthPlace
            txtPrCitizenship.Text = "";
            txtPrFirstname.Text = "";
            txtPrHeight.Text = "";
            txtPrLastname.Text = "";
            txtPrMiddlename.Text = "";
            txtPrNameExt.Text = "";
            txtPrWeight.Text = "";
        }

        private void xpPrAdd_Click(object sender, EventArgs e)
        {

        }

        private void groupBar1_GroupBarItemSelected(object sender, EventArgs e)
        {

        }

        private void bariAdd_Click(object sender, EventArgs e)
        {


        }

        private void biAdd_Click(object sender, EventArgs e)
        {
            ClearViewData();
        }

        private void briEdit_Click(object sender, EventArgs e)
        {
            SetEditable(true);
        }

        private void ucPersonnelView_Click(object sender, EventArgs e)
        {
            DEHRISAPI.PersonnelUtility prodUtil = new PersonnelUtility();
            objlPersonnelView.SetObjects(prodUtil.GetPersonnel());
        }
    }
}
