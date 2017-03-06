using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEHRIS.Tool
{
    public partial class ucSpreadsheet : UserControl
    {



      

        
        public ucSpreadsheet()
        {
            InitializeComponent();
        }

        public void LoadSpreadsheet(string filepath)
        {

            spreadsheet1.Open(filepath);
            spreadsheet1.Show();
        
        }
    }
}
