using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using System.Windows.Forms;

using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace DEHRIS.Document
{
    public partial class ucSlideShow : UserControl
    {
        public ucSlideShow()
        {
            InitializeComponent();

            //Create an instance of WordDocument.
            //using (WordDocument wordDocument = new WordDocument())
            //{
            //    //Open an existing Word document.
            //    wordDocument.Open("Sample.docx");
            //    //Read the text in the first paragraph.
            //    textBox1.Text = wordDocument.Sections[0].Body.Paragraphs[0].Text;
            //    // OR
            //    //Read the text in the last paragraph.
            //    textBox1.Text = wordDocument.LastParagraph.Text;
            //}
        }
    }
}
