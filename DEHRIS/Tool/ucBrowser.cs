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
    public partial class ucBrowser : UserControl
    {
        public ucBrowser()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://www.google.com");
            webBrowser1.Show();
        }
    }
}
