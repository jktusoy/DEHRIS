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
using DEHRIS.MODEL.Data;
using DEHRIS.CONTROLLER;
using System.IO;
using Syncfusion.Windows.Forms.Tools;

namespace DEHRIS.Importer
{
    public partial class ucPersonnelView : UserControl
    {
        PersonnelUtility prodUtil = new PersonnelUtility();
        DEHRIS.Personnel.Modules.ucEligibility ucEligib;
        DEHRIS.Personnel.Modules.ucEducationalBackground ucEduc;
        public ucPersonnelView()
        {
            InitializeComponent();

            //dtPrBirthdate.Format = DateTimePickerFormat.Custom;
            //dtPrBirthdate.CustomFormat = " ";
            txtBdate.Text = "";


            objlPersonnelView.SetObjects(prodUtil.GetPersonnel());


            EducationalBackground educc = new EducationalBackground();
            ucEduc = new Personnel.Modules.ucEducationalBackground(educc);
            flipEduc.Front = objEducBack;
            flipEduc.Back = ucEduc;
            flipEduc.TimerInterval = 10;

            CivilService civ = new CivilService();
            ucEligib = new Personnel.Modules.ucEligibility(civ);
            flipEligib.Front = objEligib;
            flipEligib.Back = ucEligib;
            flipEligib.TimerInterval = 10;


         }





        #region FUNCTIONS

            #region PERSONNEL
            /////////////////////////  PERSONNEL
            private void ShowPersonnelViewData(DEHRIS.MODEL.Data.Personnel ppersonnel)
            {
                int defaulter = 0;
                // txtPrBirthPlace
                txtPrCitizenship.Text = ppersonnel.Citizenship;
                txtPrBirthPlace.Text = ppersonnel.BirthPlace;
                txtPrFirstname.Text = ppersonnel.Firstname;
                txtPrHeight.Text = ppersonnel.Height;
                txtPrLastname.Text = ppersonnel.Lastname;
                txtPrMiddlename.Text = ppersonnel.Middlename;
                txtPrNameExt.Text = ppersonnel.NameExtension;
                txtPrWeight.Text = ppersonnel.Weight;
                cbBloodType.Text = ppersonnel.Bloodtype;
                int.TryParse(ppersonnel.Civilstatus, out defaulter);
                cbCivilStatus.SelectedIndex = defaulter;
                txtBdate.Text = ppersonnel.DateOfBirth.ToShortDateString();
                int _personnelID = int.Parse(ppersonnel.PersonnelID.ToString());
                byte[] byter = prodUtil.GetPersonnelProfilePic(_personnelID).BinaryImage;

                if (ppersonnel.Sex.Equals("1"))
                {
                    rbMale.Checked =true;
                    rbFemale.Checked = false;
                }
                else if (ppersonnel.Sex.Equals("2"))
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = true;
                }
                else
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                }

                LoadProfilePicture(byter);
                LoadCivilService(_personnelID);
                LoadEducationalBackground(_personnelID);
            }
      
            private void SetPersonnelEditable(bool iseditable)
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
                    txtBdate.ReadOnly = false;
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
                  //  dtPrBirthdate.Enabled = false;
                    txtBdate.ReadOnly = true;
                }

            }



            private void ClearPersonnelViewData()
            {
                // txtPrBirthPlace
                txtPrCitizenship.Text = "";
                txtPrFirstname.Text = "";
                txtPrHeight.Text = "";
                txtPrLastname.Text = "";
                txtPrMiddlename.Text = "";
                txtPrNameExt.Text = "";
                txtPrWeight.Text = "";
                cbBloodType.Text = "";
                cbCivilStatus.Text = "";
                cBirthDate.Text = "";
                txtPrBirthPlace.Text = "";

                txtBdate.Text = "";
              
                //dtPrBirthdate.Format = DateTimePickerFormat.Custom;
                //dtPrBirthdate.CustomFormat = " ";


            }


            #endregion


                    #region  PERSONNEL PROFILE
                    public void LoadProfilePicture(byte[] bytearray)
                    {
                        pictureProfile.Image = DEHRIS.Properties.Resources.icon_user_default;
                        if (bytearray == null)
                            return;

                        using (var ms = new MemoryStream(bytearray))
                        {
                            pictureProfile.Image = Image.FromStream(ms);
                            pictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureProfile.Show();
                        }
                    }

                    public void LoadEducationalBackground(int ppersonnelID)
                    {
                        objEducBack.SetObjects(prodUtil.GetEducationalBackgroundListByPersonnelID(ppersonnelID));
                    }

                    public void SelectEducationalBackground(EducationalBackground educback)
                    {
                       
                        flipEduc.Flip();
                    }

                    #endregion


                    #region PERSONNEL QUALIFICATION

                    public void LoadESpecialSkills(int ppersonnelID)
                    {
                        objCivilService.SetObjects(prodUtil.GetSpecialSkillsListByPersonnelID(ppersonnelID));
                    }

     
                    public void LoadCivilService(int ppersonnelID)
                    {
                        objCivilService.SetObjects(prodUtil.GetCivilServiceListByPersonnelID(ppersonnelID));
                    }

                    public void LoadSeminar(int ppersonnelID)
                    {
                        objCivilService.SetObjects(prodUtil.GetTrainingListByPersonnelID(ppersonnelID));
                    }

                    public void LoadWorkExperience(int ppersonnelID)
                    {
                        objCivilService.SetObjects(prodUtil.GetWorkExperienceListByPersonnelID(ppersonnelID));
                    }
                    #endregion


                    #region PERSONNEL ATTACHMENTS



                    #endregion
        #endregion

     

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

      

    





      


    
     
        private void InitiateFlipping()
        {
         

           

        }





        #region EVENTS

        /////////////////////////  PERSONNEL
        private void objlPersonnelView_SelectionChanged(object sender, EventArgs e)
        {
            SetPersonnelEditable(false);
            DEHRIS.MODEL.Data.Personnel selectePersonnel = (DEHRIS.MODEL.Data.Personnel)objlPersonnelView.SelectedObject;
            ShowPersonnelViewData(selectePersonnel);
            
        }
        /////////////////////////  PROFILE


        /////////////////////////  QUALIFICATIONS


        /////////////////////////  ATTACHMENT

       
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
        
        }

        private void briEdit_Click(object sender, EventArgs e)
        {
          
        }

        private void ucPersonnelView_Click(object sender, EventArgs e)
        {
          
        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void biAddEligib_Click(object sender, EventArgs e)
        {

        }

        private void briEligibAdd_Click(object sender, EventArgs e)
        {
            flipEligib.Flip();
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
        #endregion

        private void briEducAdd_Click(object sender, EventArgs e)
        {
            SelectEducationalBackground((EducationalBackground)objEducBack.SelectedObject);
        }

        private void tabSplitterContainer1_Click(object sender, EventArgs e)
        {
         
        }

        private void briEligAdd_Click(object sender, EventArgs e)
        {
            //ToolTipInfo tooltip = new ToolTipInfo();
            //tooltip.BackColor = Color.Blue;
            //tooltip.Header.Text = "SOMETHING";
   
            //tooltip.Body.Text = "this is the body, this is the body,this is the body";
            //tooltip.BackColor = Color.Blue;

            //superToolTip1.SetToolTip(briEligAdd, tooltip);
            //superToolTip1.ShowAlways = true;
            //superToolTip1.Show(tooltip, new Point(25, 25), 10);
            //popupNotifier1.TitleText = "SAMPLE";
            //popupNotifier1.Image = Properties.Resources.information;
            //popupNotifier1.Popup();
            DEHRIS.Others.CustomPopUpNotifier customnotif = new Others.CustomPopUpNotifier();
            customnotif.SetNotification(Others.CustomPopUpNotifier.NotificationType.Error, "Error, user must input valid string format");
             
        }

        private void briEligEdit_Click(object sender, EventArgs e)
        {
            DEHRIS.Others.CustomPopUpNotifier customnotif = new Others.CustomPopUpNotifier();
            customnotif.SetNotification(Others.CustomPopUpNotifier.NotificationType.Warning, "Error, user must input valid string format");
         
        }

        private void briEligDelete_Click(object sender, EventArgs e)
        {
            DEHRIS.Others.CustomPopUpNotifier customnotif = new Others.CustomPopUpNotifier();
            customnotif.SetNotification(Others.CustomPopUpNotifier.NotificationType.Information, "Error, user must input valid string format");
         
        }

        private void briPersonnelAdd_Click(object sender, EventArgs e)
        {
            briPersonnelAdd.Enabled = false;
            briPersonnelUpdate.Enabled = false;
            briPersonnelDelete.Enabled = false;
            ClearPersonnelViewData();
            objlPersonnelView.Select();
        }

        private void briPersonnelSave_Click(object sender, EventArgs e)
        {
            briPersonnelAdd.Enabled = true;
            briPersonnelUpdate.Enabled = true;
            briPersonnelDelete.Enabled = true;
        }

        private void briPersonnelEdit_Click(object sender, EventArgs e)
        {
            briPersonnelAdd.Enabled = false;
            briPersonnelUpdate.Enabled = false;
            briPersonnelDelete.Enabled = false;
        }

        private void briPersonnelDelete_Click(object sender, EventArgs e)
        {
            briPersonnelAdd.Enabled = false;
            briPersonnelUpdate.Enabled = false;
            briPersonnelDelete.Enabled = false;
        }

        private void briPersonnelRefresh_Click(object sender, EventArgs e)
        {
            briPersonnelAdd.Enabled = true;
            briPersonnelUpdate.Enabled = true;
            briPersonnelDelete.Enabled = true;
        }

        private void groupBar1_GroupBarItemSelected_1(object sender, EventArgs e)
        {

        }

        private void xptbSeminars_Click(object sender, EventArgs e)
        {

        }
    }
}
