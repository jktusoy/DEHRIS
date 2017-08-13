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
using Syncfusion.Windows.Forms.Tools;
using DEHRIS.CONTROLLER.Structure;
using BrightIdeasSoftware;
using DEHRIS.MODEL.Data;
using DEHRIS.VIEW.Structure;

namespace DEHRIS.VIEW
{

    public delegate void SimpleDelegate();
    public partial class ViewManager : UserControl
    {
        private ICRUDDefinition mUsercontrol;
        private EnumTypes.ViewType viewType = EnumTypes.ViewType.ViewOnly;
        private EnumTypes.TransactionType transType = EnumTypes.TransactionType.Refresh;
        private EnumTypes.LayoutType layoutType = EnumTypes.LayoutType.FullLoad;
        public object CurrentSelected;

        public string Title { get; set; }

        public EnumTypes.LayoutType LayoutOrientation
        {
            get { return layoutType; }
            set { layoutType = value; }
        }

        public IList<object> GetDataList()
        {
          

            return this.objlViewMgr.SelectedObjects.OfType<object>().ToList();
        }
        public ViewManager()
        {
            InitializeComponent();
            DefaultControl();
            objlViewMgr.UseFiltering = true;
            Generator.GenerateColumns(this.objlViewMgr, Type.GetType("DEHRIS.MODEL.Data.Training"), true);
            briTitle.Text = Title;
            pnlViewMgrContent.Controls.Clear();
            pnlViewMgrContent.Controls.Add((UserControl)mUsercontrol);

            viewType = EnumTypes.ViewType.ViewAndManage;
            ((UserControl)mUsercontrol).Dock = DockStyle.Fill;
            pnlViewMgrContent.Dock = DockStyle.Fill;
        }

        public void TriggerAddButton()
        {
            briAdd.PerformClick();
        }
        public void TriggerEditButton()
        {
            briEdit.PerformClick();
        }
     

        public ViewManager(ICRUDDefinition uccont, string classType, string stitle)
        {
            InitializeComponent();
            DefaultControl();

            SimpleDelegate simpleDelegate = new SimpleDelegate(TriggerEditButton);
            uccont.DelegateAssign(simpleDelegate);
            Title = stitle;
            briTitle.Text = Title;
            Generator.GenerateColumns(this.objlViewMgr, Type.GetType(classType), true);
            objlViewMgr.SetObjects(uccont.ListItem());

            pnlViewMgrContent.Controls.Clear();

            mUsercontrol = uccont;
            pnlViewMgrContent.Controls.Add((UserControl)mUsercontrol);
            viewType = EnumTypes.ViewType.ViewAndManage;
        }

        public void UpdateLayout()
        {

            switch (layoutType)
            {
                case EnumTypes.LayoutType.ViewMainHorizontal:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Horizontal;
                    tbsViewMgr.Swapped = false;
                    break;
                case EnumTypes.LayoutType.ManageMainHorizontal:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Swapped = true;
                    break;
                case EnumTypes.LayoutType.ViewMainVertical:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height * (2 / 3);
                    tbsViewMgr.Orientation = Orientation.Vertical;
                    tbsViewMgr.Swapped = false;
                    break;
                case EnumTypes.LayoutType.ManageMainVertical:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = (tbsViewMgr.Height * 2 / 3) + 50;
                    tbsViewMgr.Orientation = Orientation.Vertical;
                    tbsViewMgr.Swapped = true;
                    break;
                case EnumTypes.LayoutType.FullLoad:
                    tbsViewMgr.Collapsed = true;
                    break;
                default:
                    break;
            }

        }

        public void UpdateLayout(EnumTypes.LayoutType _layoutType)
        {

            switch (_layoutType)
            {
                case EnumTypes.LayoutType.ViewMainHorizontal:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Horizontal;
                    tbsViewMgr.Swapped = false;
                    break;
                case EnumTypes.LayoutType.ManageMainHorizontal:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Swapped = true;
                    break;
                case EnumTypes.LayoutType.ViewMainVertical:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Vertical;
                    tbsViewMgr.Swapped = false;
                    break;
                case EnumTypes.LayoutType.ManageMainVertical:
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.SplitterPosition = tbsViewMgr.Height / 2;
                    tbsViewMgr.Orientation = Orientation.Vertical;
                    tbsViewMgr.Swapped = true;
                    break;
                case EnumTypes.LayoutType.FullLoad:
                    tbsViewMgr.Collapsed = true;
                    break;
                default:
                    break;
            }

        }


        public void ImplementViewType()
        {
            if (viewType == EnumTypes.ViewType.ViewOnly)
            {
                foreach (TabSplitterPage item in tbsViewMgr.SecondaryPages)
                {
                    item.Hide = true;
                }
            }

        }




        private void xpTaskBarBox2_ItemClick(object sender, Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs e)
        {

        }




        #region COMMON FUNCTION
        public bool Edit(bool enabled)
        {



            if (viewType == EnumTypes.ViewType.ViewAndManage)
            {
                object objectv = objlViewMgr.SelectedObject;

                if (objectv == null)
                    return false;
                mUsercontrol.ViewItem(objectv, enabled);

                if (tbsViewMgr.Collapsed == true)
                {
                    tbsViewMgr.Collapsed = false;
                    tbsViewMgr.Swapped = false;
                    tbsViewMgr.Collapsed = true;
                }

            }
            return true;
        }

        public bool Add()
        {

            transType = mUsercontrol.TransactionType = EnumTypes.TransactionType.Add;
            mUsercontrol.UpdateTitle(transType);

            briEdit.Enabled = false;
            briAdd.Enabled = false;
            briDelete.Enabled = false;
            briSave.Enabled = true;
            briCancel.Enabled = true;

            if (tbsViewMgr.Collapsed == true)
            {
                tbsViewMgr.Collapsed = false;
                tbsViewMgr.Swapped = false;
                tbsViewMgr.Collapsed = true;
            }

            mUsercontrol.ClearItem();

            return true;



        }

        public void DefaultControl()
        {

            briEdit.Enabled = true;
            briAdd.Enabled = true;
            briDelete.Enabled = true;
            briSave.Enabled = false;
            briCancel.Enabled = false;
        }


        #endregion

        #region EVENTS
        private void briAdd_Click(object sender, EventArgs e)
        {
            Add();       
        }

        private void objlViewMgr_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            if (briEdit.Enabled == false)
            {
                switch (MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel))
                { 
                    case DialogResult.Yes:
                        briSave.PerformClick();
                        break;
                    case DialogResult.No:
                        briCancel.PerformClick();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            
            }

            mUsercontrol.UpdateTitle(transType);
            mUsercontrol.TransactionType = transType = EnumTypes.TransactionType.Refresh;
            Edit(false);
            DefaultControl();
        }
        private void briSave_Click(object sender, EventArgs e)
        {

            switch (transType)
            {
                case EnumTypes.TransactionType.Add:

                    if (mUsercontrol.AddItem())
                    {
                        DEHRIS.Others.CustomPopUpNotifier customnotif = new Others.CustomPopUpNotifier();
                        customnotif.SetNotification(Others.CustomPopUpNotifier.NotificationType.Successful, "Record successfully updated.");
                        Refresh();
                    }

                    break;
                case EnumTypes.TransactionType.Update:
                    object objectv = CurrentSelected;
                    if (mUsercontrol.UpdateItem(objectv))
                    {
                        DEHRIS.Others.CustomPopUpNotifier customnotif = new Others.CustomPopUpNotifier();
                        customnotif.SetNotification(Others.CustomPopUpNotifier.NotificationType.Successful, "Record successfully updated.");
                        this.Refresh();
                    }
                    break;
            }

            briEdit.Enabled = true;
            briAdd.Enabled = true;
            briDelete.Enabled = true;
            briSave.Enabled = false;
            briCancel.Enabled = false;

            objlViewMgr.SetObjects(mUsercontrol.ListItem());
        }

        private void briDelete_Click(object sender, EventArgs e)
        {

            transType = EnumTypes.TransactionType.Refresh;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
             
                foreach (var item in objlViewMgr.SelectedObjects)
                {
                    object objectv = item;
                    mUsercontrol.DeleteItem(objectv);
                }

                DEHRIS.Others.CustomPopUpNotifier customnotif = new Others.CustomPopUpNotifier();
                customnotif.SetNotification(Others.CustomPopUpNotifier.NotificationType.Successful, "Record/s successfully deleted.");
                Refresh();
            }
           
        }

        private void briRefresh_Click(object sender, EventArgs e)
        {
           
        }


        private void briEdit_Click_1(object sender, EventArgs e)
        {
            transType = mUsercontrol.TransactionType = EnumTypes.TransactionType.Update;
            mUsercontrol.UpdateTitle(transType);


            briEdit.Enabled = false;
            briAdd.Enabled = false;
            briDelete.Enabled = false;
            briSave.Enabled = true;
            briCancel.Enabled = true;

            object objectv = objlViewMgr.SelectedObject;

            if (objectv == null)
                return;
            mUsercontrol.EditItem(objectv);

            Edit(true);
            CurrentSelected = objectv;
        }

        private void briCancel_Click(object sender, EventArgs e)
        {
            DefaultControl();
            briRefresh.PerformClick();
        }

        #endregion

        private void briTitle_Selected(object sender, EventArgs e)
        {

        }

        private void briSearchEnter_Click(object sender, EventArgs e)
        {

            objlViewMgr.ModelFilter = TextMatchFilter.Contains(objlViewMgr, brtxtSearch.Value.ToString());
        }

        private void brtxtSearch_Click(object sender, EventArgs e)
        {

        }

        private void xpToolBar1_Click(object sender, EventArgs e)
        {

        }

        private void briRefresh_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            DefaultControl();
            transType = EnumTypes.TransactionType.Refresh;
            objlViewMgr.SetObjects(mUsercontrol.ListItem());
        }

    }
}
