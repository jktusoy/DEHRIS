using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPPlus;
using OfficeOpenXml;
namespace EXCELPARSER
{
    class EPPLUSHelper
    {





        //private bool WriteOnCellRange(string rangeFrom, string rangeTo)
        //{
        //    int progress = 0;
        //    string currentCell;
        //    ExcelWorksheet worksheet1;
        //    ExcelWorksheet worksheet2;
        //    ExcelRange actualCell;

        //    //if (!ValidateDirectoryFrom(txtimportpdsDirectorypath.Text))
        //    //{
        //    //    listBox1.Items.Add("Not valid directory: " + txtimportpdsDirectorypath.Text);
        //    //    return;
        //    //}
        //    //common_importtransaction transac = new common_importtransaction();
        //    //transac.transactiondate = DateTime.Now;
        //    //transac.transactionname = "IMPORT PDS";

        //    //string[] files = Directory.GetFiles(txtimportpdsDirectorypath.Text, "*.xlsx",
        //    //        SearchOption.AllDirectories).Where(s => Path.GetFileName(s).Substring(0, 2) != "._").ToArray();
        //    //pbimportpdsLoading.Maximum = files.Count();
        //    //using (HRISDALPriorEntities dbcontext = new HRISDALPriorEntities())
        //    //{
        //    //    List<common_importtemplatedetail> detailList = dbcontext.common_importtemplatedetail.Where(a => a.common_importtemplate_id == 1).ToList();

        //    //    hris_personnel personnel = new hris_personnel();
        //    //    List<hris_employment> employmentList = new List<hris_employment>();
        //    //    hris_employment employment = new hris_employment();
        //    //    foreach (string file in files)
        //    //    {
        //    //        progress++;
        //    //        pbimportpdsLoading.Value = progress;
        //    //        try
        //    //        {
        //    //            FileInfo eachfile = new FileInfo(file);
        //    //            common_importtransactiondetail transacitem = new common_importtransactiondetail();
        //    //            using (ExcelPackage package = new ExcelPackage(eachfile))
        //    //            {
        //    //                transacitem.common_importtransaction_id = transac.common_importtransaction_id;
        //    //                transacitem.directory = Path.GetDirectoryName(txtimportpdsDirectorypath.Text);
        //    //                transacitem.filename = file;
        //    //                foreach (common_importtemplatedetail detail in detailList.Where(a => a.worksheetno == 1))
        //    //                {


        //    //                    worksheet1 = package.Workbook.Worksheets[1];
        //    //                    if (detail.worksheetno == 1)
        //    //                    {
        //    //                        AssignPersonnelAttributes(personnel, worksheet1, detail);
        //    //                    }



        //    //                }

        //    //                dbcontext.hris_personnel.Add(personnel);
        //    //                dbcontext.SaveChanges();




        //    //                worksheet2 = package.Workbook.Worksheets[2];
        //    //                actualCell = worksheet2.Cells["A1"];

        //    //                int iterate = 0;
        //    //                do
        //    //                {
        //    //                    employment = new hris_employment();
        //    //                    bool hasvalue = false;

        //    //                    foreach (common_importtemplatedetail detail in detailList.Where(a => a.worksheetno == 2))
        //    //                    {

        //    //                        if (package.Workbook.Worksheets.Count <= 1)
        //    //                            break;


        //    //                        currentCell = detail.value1;
        //    //                        actualCell = worksheet2.Cells[currentCell];
        //    //                        actualCell = CellIncrementer(true, actualCell, iterate);

        //    //                        if (AssignWorkHistoryAttributes(employment, worksheet2, actualCell.Value.ToString(), detail.title.ToString()))
        //    //                        {
        //    //                            employment.hris_personnel_id = personnel.hris_personnel_id;
        //    //                            hasvalue = true;
        //    //                        }
        //    //                    }


        //    //                    iterate++;

        //    //                    if (hasvalue)
        //    //                    {
        //    //                        dbcontext.hris_employment.Add(employment);
        //    //                        dbcontext.SaveChanges();
        //    //                    }

        //    //                } while (iterate < maxiterationAssign);


        //    //                transacitem.tableid = personnel.hris_personnel_id;
        //    //                transacitem.tablename = "hris_personnel";
        //    //                dbcontext.common_importtransaction.Add(transac);
        //    //                dbcontext.common_importtransactiondetail.Add(transacitem);
        //    //                dbcontext.SaveChanges();
        //    //            }
        //    //        }
        //    //        catch (DbEntityValidationException ex)
        //    //        {

        //    //            StringBuilder sb = new StringBuilder();

        //    //            foreach (var failure in ex.EntityValidationErrors)
        //    //            {
        //    //                sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
        //    //                foreach (var error in failure.ValidationErrors)
        //    //                {
        //    //                    sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
        //    //                    sb.AppendLine();
        //    //                }
        //    //            }

        //    //            listBox1.Items.Add("Entity Validation Failed - errors follow:\n" + sb.ToString());
        //    //        }
        //    //        catch (Exception ex)
        //    //        {
        //    //            listBox1.Items.Add(ex.Message);
        //    //        }
        //    //    }
        //    //}
        //}




    }

    

}
