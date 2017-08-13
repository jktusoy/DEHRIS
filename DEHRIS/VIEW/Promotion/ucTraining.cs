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
using Syncfusion.Windows.Forms.Tools;
namespace DEHRIS.VIEW.Promotion
{
    public partial class ucTraining : UserControl, ICRUDDefinition
    {
        SimpleDelegate item;
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

        public void UpdateTitle(EnumTypes.TransactionType mtransType)
        {

            if (mtransType == EnumTypes.TransactionType.Add)
            {
                lblTitle.Text = "Adding new " + mTitle + " record"; 
            }
            else if (mtransType == EnumTypes.TransactionType.Update)
            {
                lblTitle.Text = "Updating " + mTitle + " record";
            }
            else
            {
                lblTitle.Text = "Viewing " + mTitle + " record";
            }
        
        }

        public void ViewItem(Object obj, bool enabled)
        {
            try
            {
                foreach (var item in this.Controls)
                {
                    if (item is TextBox)
                        ((TextBox)item).ReadOnly = !enabled;
                    else if (item is DateTimePickerAdv)
                    {
                        if (enabled)
                        {
                            ((DateTimePickerAdv)item).ReadOnly = !enabled;
                            ((DateTimePickerAdv)item).Format = DateTimePickerFormat.Short;
                            ((DateTimePickerAdv)item).Value = (DateTime)Item.DateFrom;
                        }
                        else {
                            ((DateTimePickerAdv)item).ReadOnly = !enabled;
                            ((DateTimePickerAdv)item).Format = DateTimePickerFormat.Custom;
                            ((DateTimePickerAdv)item).CustomFormat = " ";
                        
                        }

                    }
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

        public void DelegateAssign(SimpleDelegate basicc)
        {

            item = basicc;

        }



        public bool EditItem(Object obj)
        {
            try
            {

                ViewItem(obj,true);
                return true;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteItem(Object obj)
        {
            return false;
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

            dtpTRNDateFrom.ReadOnly = false;
            dtpTRNDateFrom.Format = DateTimePickerFormat.Short;

            dtpTRNDateTo.ReadOnly = false;
            dtpTRNDateTo.Format = DateTimePickerFormat.Short;

            txtTRNDuration.ReadOnly = false;
            txtTRNConductedBy.ReadOnly = false;
            txtTRNMethod.ReadOnly = false;
            txtTRNRemarks.ReadOnly = false;
            txtTRNTitle.ReadOnly = false;
            txtTRNTrainingType.ReadOnly = false;
            txtTRNMethod.ReadOnly = false;
        }


        public bool AddItem()
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
            return true;
        }
        public bool UpdateItem(Object obj)
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
            return true;
        }


    }
}
