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
        public IController<Training> mController;
        public Training mItem = new Training();
        private String mTitle ="Training";
        private EnumTypes.TransactionType mtransType = EnumTypes.TransactionType.Add;

        public Training Item
        {
            get { return mItem; }
            set { mItem = value; }
        }
        public String Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }
        public EnumTypes.TransactionType TransactionType
        {
            get { return mtransType; }
            set { mtransType = value; }
        }
            
        public ucTraining(IController<Training> trainingController)
        {
            InitializeComponent();
            mController = trainingController;
        }


        public List<object> ListItem()
        {

            return mController.GetList().Cast<object>().ToList();
        }

        public void UpdateTitle()
        {

            if (mtransType == EnumTypes.TransactionType.Add)
            {
                lblTitle.Text = "Adding new record: " + mTitle;
            }
            else if (mtransType == EnumTypes.TransactionType.Update)
            {
                lblTitle.Text = "Updating new record: " + mTitle;
            }
            else
            {
                lblTitle.Text = "Viewing new record: " + mTitle;
            }
        
        }

        public void ViewItem(Object obj, bool enabled)
        {
            try
            {

                txtTRNDuration.ReadOnly = !enabled;
                txtTRNConductedBy.ReadOnly = !enabled;
                txtTRNMethod.ReadOnly = !enabled;
                txtTRNRemarks.ReadOnly = !enabled;
                txtTRNTitle.ReadOnly = !enabled;
                txtTRNTrainingType.ReadOnly = !enabled;
                txtTRNMethod.ReadOnly = !enabled;



                if (enabled) {
                    dtpTRNDateFrom.ReadOnly = !enabled;
                    dtpTRNDateFrom.Format = DateTimePickerFormat.Short;
                    dtpTRNDateFrom.Value =(DateTime)Item.DateFrom;

                    dtpTRNDateTo.ReadOnly = !enabled;
                    dtpTRNDateTo.Format = DateTimePickerFormat.Short;
                    dtpTRNDateFrom.Value = (DateTime)Item.DateTo;
                
                }

                else {

                    dtpTRNDateFrom.ReadOnly = !enabled;
                    dtpTRNDateFrom.Format = DateTimePickerFormat.Custom;
                    dtpTRNDateFrom.CustomFormat = " ";

                    dtpTRNDateTo.ReadOnly = !enabled;
                    dtpTRNDateTo.Format = DateTimePickerFormat.Custom;
                    dtpTRNDateTo.CustomFormat = " ";
                }

              



                mItem = (Training)obj;
                txtTRNDuration.Text = mItem.Duration.ToString();
                txtTRNConductedBy.Text = mItem.ConductedBy;
                txtTRNMethod.Text = mItem.Method;
                txtTRNRemarks.Text = mItem.Remarks;
                txtTRNTitle.Text = mItem.Title;
                txtTRNTrainingType.Text = mItem.Type;
                txtTRNMethod.Text = mItem.Method;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        public void EditItem(Object obj)
        {
            try
            {

                ViewItem(obj,true);

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

            dtpTRNDateFrom.Enabled = true;
            dtpTRNDateFrom.Format = DateTimePickerFormat.Short;

            dtpTRNDateTo.Enabled = true;
            dtpTRNDateTo.Format = DateTimePickerFormat.Short;   

            txtTRNDuration.Enabled = true;
            txtTRNConductedBy.Enabled = true;
            txtTRNMethod.Enabled = true;
            txtTRNRemarks.Enabled = true;
            txtTRNTitle.Enabled = true;
            txtTRNTrainingType.Enabled = true;
            txtTRNMethod.Enabled = true;
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
            mItem = trn;
            mController.Add(trn);
        }
        public void UpdateItem(Object obj)
        {

            int valint = 0;
            long trainingID = mItem.TrainingID;
            txtTRNTitle.Tag = 0;
            int.TryParse(txtTRNDuration.Text, out valint);
            

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
            mItem = trn;
            mController.Update(trn);
        }


    }
}
