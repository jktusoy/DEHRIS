using DEHRIS.MODEL.Data;
using DEHRIS.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEHRIS.CONTROLLER.Helper
{
    

    public static class PromotionNavigation
    {
        
        public static List<object> DataObjectList;
        public static ViewManager currentViewManager;
        public static void TrainingView(Panel gpMain)
        {
            TrainingController perf = new TrainingController();      
            VIEW.Promotion.ucTraining uctrn = new VIEW.Promotion.ucTraining(perf);
            ViewManager vmTrn = new ViewManager(uctrn, "DEHRIS.MODEL.Data.Training", "Training");
            vmTrn.LayoutOrientation = VIEW.Structure.EnumTypes.LayoutType.ManageMainVertical;
            vmTrn.UpdateLayout();

            gpMain.Controls.Clear();
            gpMain.Controls.Add(vmTrn);
            vmTrn.Dock = DockStyle.Fill;
        }


        public static void ApplicantsView(Panel gpMain)
        {
            ApplicantController perf = new ApplicantController();
           
            VIEW.Promotion.ucApplicants uctrn = new VIEW.Promotion.ucApplicants(perf);
            currentViewManager = new ViewManager(uctrn, "DEHRIS.MODEL.Data.Applicants", "Applicants");

            
            

            currentViewManager.LayoutOrientation = VIEW.Structure.EnumTypes.LayoutType.ManageMainVertical;
            currentViewManager.UpdateLayout();

            gpMain.Controls.Clear();
            gpMain.Controls.Add(currentViewManager);
            currentViewManager.Dock = DockStyle.Fill;
        }

        public static void UpdateDataList()
        {
            if (currentViewManager != null)
            {
                DataObjectList = currentViewManager.GetDataList().ToList();
            }
        }
        public static void TrainingView2(Panel gpMain)
        {
            //TrainingController perf = new TrainingController();
            //List<object> objlist = new List<object>();
            //objlist = perf.GetList().Cast<object>().ToList();
            //VIEW.Promotion.ucTraining uctrn = new VIEW.Promotion.ucTraining(perf);

            //ViewManager ucTrn = new ViewManager(objlist);
            //gpMain.Controls.Clear();
            //gpMain.Controls.Add(ucTrn);
            //ucTrn.Dock = DockStyle.Fill;
        }


        

    }
}
