using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;
using System.Windows;
using System.Windows.Forms;
namespace DEHRIS.MODEL.Data
{
    public class Training
    {
    
        [OLVColumn("Title", DisplayIndex = 1, Width = 200, TextAlign = HorizontalAlignment.Center)]
        public string Title { get; set; }


        [OLVColumn("Duration", DisplayIndex = 2, Width = 75, TextAlign = HorizontalAlignment.Center)]
        public Nullable<int> Duration { get; set; }


        [OLVColumn("ConductedBy", DisplayIndex = 3, Width = 75, TextAlign = HorizontalAlignment.Center)]
        public string ConductedBy { get; set; }


        [OLVColumn("IsActive", IsVisible=false)]
        public Nullable<bool> IsActive { get; set; }


        [OLVColumn("Date From", DisplayIndex = 5, Width = 75, TextAlign = HorizontalAlignment.Center)]
        public Nullable<DateTime> DateFrom { get; set; }


        [OLVColumn("Date To", DisplayIndex = 6, Width = 75, TextAlign = HorizontalAlignment.Center)]
        public Nullable<DateTime> DateTo { get; set; }


       [OLVColumn(IsVisible = false)]
        public Nullable<long> PersonnelID { get; set; }


        [OLVColumn("Remarks", DisplayIndex = 3, Width = 100, TextAlign = HorizontalAlignment.Center)]
        public string Remarks { get; set; }

        [OLVColumn("Type", DisplayIndex = 3, Width = 75, TextAlign = HorizontalAlignment.Center)]
        public string Type { get; set; }

        [OLVColumn("Method", DisplayIndex = 3, Width = 75, TextAlign = HorizontalAlignment.Center)]
        public string Method { get; set; }


        [OLVColumn("IsMandatory", IsVisible = false)]
        public bool? IsMandatory { get; set; }

        [OLVColumn("Schedule", IsVisible = false)]
        public string Schedule { get; set; }

        [OLVColumn("TranslatedDuration", IsVisible = false)]
        public string TranslatedDuration { get; set; }


        [OLVColumn("TrainingID", IsVisible = false, Width = 0)]
        public long TrainingID { get; set; }



    }
}
