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
using DEHRISModel.Data;

namespace DEHRIS.Personnel.Modules
{
    public partial class ucTrainingView : UserControl
    {
        private bool showCRUD = true;

        public ucTrainingView()
        {
            InitializeComponent();
            PopulateTrainingView();
         

        }


        public void UpdateView()
        {
            if (!showCRUD)
            {
                tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.AutoSize;
                tableLayoutPanel1.ColumnStyles[0].Width = 100;
                tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.AutoSize;
                tableLayoutPanel1.ColumnStyles[1].Width = 0;
                pnlTRNVCRUD.Controls.Clear();
            }
        
        }

        public void PopulateTrainingView()
        {
            PerformanceManagementUtility putil = new PerformanceManagementUtility();
            objlTrainingView.SetObjects(putil.GetSeminarList());

        }

        private void objlTrainingView_SelectionChanged(object sender, EventArgs e)
        {

            Training itemSelection = (Training)objlTrainingView.SelectedObject;
            if (itemSelection != null)
                this.ucTraining2.PopulateFields(itemSelection);

        }
        public bool ShowCRUD { get { return showCRUD; } set { showCRUD = value; } }
        private void ucTraining2_Load(object sender, EventArgs e)
        {

        }
    }
}
