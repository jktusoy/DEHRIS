using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEHRISAPI;

namespace DEHRIS.Personnel.Modules
{
    public partial class ucTrainingAssignment : UserControl
    {
        public ucTrainingAssignment()
        {
            InitializeComponent();
            PopulatePersonnel();

          


        }


        public void SetFlipPanel()
        {

            ucTrainingView uctrainview = new ucTrainingView();
            uctrainview.ShowCRUD = false;
            uctrainview.UpdateView();

            flipTRNA.Front = objlTraining;
            flipTRNA.Back = uctrainview;
            flipTRNA.TimerInterval = 10;
          
        }
        public void PopulatePersonnel()
        {

            DEHRISAPI.PersonnelUtility personutil = new PersonnelUtility();
            objlPersonnelView.SetObjects(personutil.GetPersonnel());

        
        }

        public void PopulateTrainingByPersonnelID(int personnelID)
        {
            DEHRISAPI.PersonnelUtility personutil = new PersonnelUtility();
            objlTraining.SetObjects(personutil.GetTrainingListByPersonnelID(personnelID));
            
        }

        private void objlPersonnelView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void briTRAAdd_Click(object sender, EventArgs e)
        {
            flipTRNA.Flip();
           
        }




    }
}
