using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEHRIS.MODEL.Enum;
using DEHRIS.MODEL.Data;
using DEHRIS.VIEW.Structure;
using DEHRIS.CONTROLLER;
using DEHRIS.CONTROLLER.Structure;
namespace DEHRIS.VIEW.Promotion
{
    public partial class ucTraining : UserControl, ICRUDDefinition
    {
        private IController<Training> Controller;
        public Training moItem = new Training();
        private TransactionType transType = TransactionType.Add;

        public Training Item
        {
            get { return moItem; }
            set { moItem = value; }
        }


            
        public ucTraining(IController<Training> trainingController)
        {
            InitializeComponent();
            Controller = trainingController;
        }

        public void ViewItem(Object obj)
        {
            try
            {

                moItem = (Training)obj;
                txtTRNDuration.Text = moItem.Duration.ToString();
                txtTRNConductedBy.Text = moItem.ConductedBy;
                txtTRNMethod.Text = moItem.Method;
                txtTRNRemarks.Text = moItem.Remarks;
                txtTRNTitle.Text = moItem.Title;
                txtTRNTrainingType.Text = moItem.Type;
                txtTRNMethod.Text = moItem.Method;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        public void ClearItem()
        {

            txtTRNDuration.Text = "";
            txtTRNConductedBy.Text = "";
            txtTRNMethod.Text = "";
            txtTRNRemarks.Text = "";
            txtTRNTitle.Text = "";
            txtTRNTrainingType.Text = "";
            txtTRNMethod.Text = "";
        }


        public void AddItem()
        {
            int valint = 0;
            long trainingID = 0;
            txtTRNTitle.Tag = 0;
            int.TryParse(txtTRNDuration.Text, out valint);
            long.TryParse(txtTRNTitle.Tag.ToString(), out trainingID);

            Training trn = new Training()
            {
                IsMandatory = true,
                ConductedBy = txtTRNConductedBy.Text,
                DateFrom = dtpTRNDateFrom.Value,
                DateTo = dtpTRNDateTo.Value,
                Title = txtTRNTitle.Text,
                Remarks = txtTRNRemarks.Text,
                Method = txtTRNMethod.Text,
                Type = txtTRNTrainingType.Text,
                Duration = valint,
                TrainingID = trainingID
            };
            moItem = trn;
            Controller.Add(trn);
        }
        public void UpdateItem(Object obj)
        {

            int valint = 0;
            long trainingID = moItem.TrainingID;
            txtTRNTitle.Tag = 0;
            int.TryParse(txtTRNDuration.Text, out valint);
            long.TryParse(txtTRNTitle.Tag.ToString(), out trainingID);

            Training trn = new Training()
            {
                IsMandatory = true,
                ConductedBy = txtTRNConductedBy.Text,
                DateFrom = dtpTRNDateFrom.Value,
                DateTo = dtpTRNDateTo.Value,
                Title = txtTRNTitle.Text,
                Remarks = txtTRNRemarks.Text,
                Method = txtTRNMethod.Text,
                Type = txtTRNTrainingType.Text,
                Duration = valint,
                TrainingID = trainingID
            };
            moItem = trn;
            Controller.Update(trn);
        }


    }
}
