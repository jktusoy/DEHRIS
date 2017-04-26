using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEHRIS.MODEL.Data;
namespace DEHRIS.Personnel.Modules
{
    public partial class ucEligibility : UserControl
    {
       
        public ucEligibility(CivilService CivilServ)
        {
            InitializeComponent();
            txtExamPlace.Text = CivilServ.ExamDate;
            txtLicenseNo.Text = CivilServ.Civilservice_number;
            txtRate.Text = CivilServ.Rate;
            txtTitle.Text = CivilServ.CivilServiceName;

        }
    }
}
