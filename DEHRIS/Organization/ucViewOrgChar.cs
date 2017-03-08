using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEHRIS.Organization
{
    public partial class ucViewOrgChar : UserControl
    {
        public ucViewOrgChar()
        {
            InitializeComponent();
            diagram1.Load(@"C:\Users\Cocoypower\Source\Repo\DEHRIS\Resources\doc1.edd");
        }
    }
}
