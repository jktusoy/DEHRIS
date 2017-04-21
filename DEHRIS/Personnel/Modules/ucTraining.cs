using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEHRISModel.Enum;
using DEHRISModel.Data;
using DEHRISAPI;
namespace DEHRIS.Personnel.Modules
{
    public partial class ucTraining : UserControl
    {


        public TransactionType transType = TransactionType.Add;
        public ucTraining()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xptbPersonnel_Click(object sender, EventArgs e)
        {

        }
        public Training TrainingItem { set; get; }


        public void PopulateFields(Training item)
        {

            txtTRNDuration.Text = item.Duration.ToString();
            txtTRNConductedBy.Text = item.ConductedBy;
            txtTRNMethod.Text = item.Method;
            txtTRNRemarks.Text = item.Remarks;
            txtTRNTitle.Text = item.Title;
        }
        public void FillObject( )
        {
            int valint = 0;
            long trainingID = 0;
            txtTRNTitle.Tag = 0;
            int.TryParse(txtTRNDuration.Text, out valint);
            long.TryParse(txtTRNTitle.Tag.ToString(),out trainingID);
    
            TrainingItem = new Training() { 
             IsMandatory = true,
             ConductedBy = txtTRNConductedBy.Text,
             DateFrom = dtpTRNDateFrom.Value,
             DateTo = dtpTRNDateTo.Value,
             Title = txtTRNTitle.Text,
             Remarks = txtTRNRemarks.Text,
             Method = txtTRNMethod.Text,
             Duration = valint,
             TrainingID = trainingID   
            };
           
        }
        private void briTRNSave_Click(object sender, EventArgs e)
        {
            FillObject();
            PerformanceManagementUtility pmUtil = new PerformanceManagementUtility();
            if (transType == TransactionType.Add)
                pmUtil.Add(TrainingItem);
            else if (transType == TransactionType.Edit)
                pmUtil.Update(TrainingItem);

        }
    }
}
