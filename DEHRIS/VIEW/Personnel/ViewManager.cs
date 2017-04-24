using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace DEHRIS.Personnel
{
    public partial class ViewManager : UserControl
    {
        String classType;
        IQueryable iqueryable;
        List<Object> objList;
        public string Title { get; set; }


        //Type myType = Type.GetType("MyNamespace.MyType");
        public ViewManager(List<object> objl)
        {
            InitializeComponent();
            lblViewMgrlHeader.Text = Title;
            objlViewMgr.SetObjects(objl);
        }
        //public List<object> ListObject {
        //    get { return objList; }
        //    set { objList = value; }
        //}

        //public IQueryable DataSource
        //{
        //    get { return objlViewMgr.Objects.AsQueryable(); }
        //    set { iqueryable = value; }
        //}

        private void xpTaskBarBox2_ItemClick(object sender, Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs e)
        {

        }

        private void briAdd_Click(object sender, EventArgs e)
        {
            tbsViewMgr.PrimaryPages.SelectedIndex = 0;
            tbsViewMgr.GetNextControl(tabSplitterPage1, true);
        //   List<myType.> myobj = 
        }



    }
}
