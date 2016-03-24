using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAO_3PL_Report_Tool
{
    public class AgingReportHandler
    {
        private readonly UserSelectedValue userselectedvalue = null;
        private DataTable agingreportdatatable = null;
        private DataTable profilereportdatatable = null;
        private DataTable onhandreportdatatable = null;
        
        public AgingReportHandler(UserSelectedValue userSelectValue)
        {
            this.userselectedvalue = userSelectValue;
        }

        public void Process()
        {
            LoadReports();
            BuildAgingDataTable();
            ExportReport();
        }

        private void LoadReports()
        {
            LoadAgingReport();
            LoadProfileReport();
            LoadOnhandReport();
        }

        #region ----- Load source reports -----
        private void LoadAgingReport()
        {
            string sheetName = ConfigFileUtility.GetValue("AgingReportSheetName");
            MiscUtility.LogHistory(string.Format("Starting to load Aging report - {0}...", userselectedvalue.AgingReportFile));
            MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Starting to load Aging report - {1}...", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), userselectedvalue.AgingReportFile));

            try
            {
                using (ExcelAccessDAO dao = new ExcelAccessDAO(userselectedvalue.AgingReportFile))
                {
                    string fullSheetName = dao.IsContainSheetName(sheetName);
                    if (fullSheetName.Contains(sheetName))
                        agingreportdatatable = dao.ReadAgingReportFile(sheetName);
                    else
                    {
                        MiscUtility.LogHistory(string.Format("No found the sheet name - {0} from Aging report!", sheetName));
                        throw new Exception(string.Format("No found the sheet name - {0} from Aging report!", sheetName));
                    }
                }

                MiscUtility.LogHistory("Done!");
                MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Done!", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            }
            catch (Exception ex)
            {
                MiscUtility.LogHistory(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
                throw;
            }
        }

        private void LoadProfileReport()
        {
            string sheetName = ConfigFileUtility.GetValue("ProfileReportSheetName");
            MiscUtility.LogHistory(string.Format("Starting to load Profile report - {0}...", userselectedvalue.ProfileReportFile));
            MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Starting to load Profile report - {1}...", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), userselectedvalue.ProfileReportFile));

            try
            {
                using (ExcelAccessDAO dao = new ExcelAccessDAO(userselectedvalue.ProfileReportFile))
                {
                    string fullSheetName = dao.IsContainSheetName(sheetName);
                    if (fullSheetName.Contains(sheetName))
                        profilereportdatatable = dao.ReadProfileReportFile(sheetName);
                    else
                    {
                        MiscUtility.LogHistory(string.Format("No found the sheet name - {0} from Profile report!", sheetName));
                        throw new Exception(string.Format("No found the sheet name - {0} from Profile report!", sheetName));
                    }
                }

                MiscUtility.LogHistory("Done!");
                MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Done!", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            }
            catch (Exception ex)
            {
                MiscUtility.LogHistory(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
                throw;
            }
        }

        private void LoadOnhandReport()
        {
            string sheetName = ConfigFileUtility.GetValue("OnhandReportSheetName");
            MiscUtility.LogHistory(string.Format("Starting to load On-hand report - {0}...", userselectedvalue.OnhandReportFile));
            MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Starting to load On-hand report - {1}...", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), userselectedvalue.OnhandReportFile));

            try
            {
                using (ExcelAccessDAO dao = new ExcelAccessDAO(userselectedvalue.OnhandReportFile))
                {
                    string fullSheetName = dao.IsContainSheetName(sheetName);

                    if (fullSheetName.Contains(sheetName))
                        onhandreportdatatable = dao.ReadOnhandReportFile(fullSheetName);
                    else
                    {
                        MiscUtility.LogHistory(string.Format("No found the sheet name with the prefix - {0} from On-hand report!", sheetName));
                        throw new Exception(string.Format("No found the sheet name with the prefix - {0} from On-hand report!", sheetName));
                    }
                }

                MiscUtility.LogHistory("Done!");
                MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Done!", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            }
            catch (Exception ex)
            {
                MiscUtility.LogHistory(string.Format("{0}, {1}", ex.Message, ex.StackTrace));
                throw;
            }
        }
        #endregion

        private void BuildAgingDataTable()
        {
            MiscUtility.LogHistory("Starting to build Aging datatable ...");
            MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Starting to build Aging datatable ...", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));

            AddColumnsIntoDataTable();
            FillDataIntoDataTable();

            MiscUtility.LogHistory("Done!");
            MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Done!", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
        }

        private void AddColumnsIntoDataTable()
        {
            try
            {
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "On_hand", "System.Int32", 17);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "L5", "System.Int32", 18);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G5", "System.Int32", 19);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G10", "System.Int32", 20);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G15", "System.Int32", 21);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G30", "System.Int32", 22);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G45", "System.Int32", 23);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G60", "System.Int32", 24);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G90", "System.Int32", 25);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G120", "System.Int32", 26);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G150", "System.Int32", 27);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G200", "System.Int32", 28);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G250", "System.Int32", 29);
                MiscUtility.InsertNewColumn(ref profilereportdatatable, "G300", "System.Int32", 30);
            }
            catch (Exception ex)
            {
                MiscUtility.LogHistory(string.Format("Source:{0},  Error:{1}", ex.Source, ex.Message));
                throw;
            }
        }

        private void FillDataIntoDataTable()
        {
            string fgaId = string.Empty;

            for (int index = 0; index < profilereportdatatable.Rows.Count; index++)
            {
                // Assigne default value to each cell
                profilereportdatatable.Rows[index]["On_hand"] = 0;
                profilereportdatatable.Rows[index]["L5"] = 0;
                profilereportdatatable.Rows[index]["G5"] = 0;
                profilereportdatatable.Rows[index]["G10"] = 0;
                profilereportdatatable.Rows[index]["G15"] = 0;
                profilereportdatatable.Rows[index]["G30"] = 0;
                profilereportdatatable.Rows[index]["G45"] = 0;
                profilereportdatatable.Rows[index]["G60"] = 0;
                profilereportdatatable.Rows[index]["G90"] = 0;
                profilereportdatatable.Rows[index]["G120"] = 0;
                profilereportdatatable.Rows[index]["G150"] = 0;
                profilereportdatatable.Rows[index]["G200"] = 0;
                profilereportdatatable.Rows[index]["G250"] = 0;
                profilereportdatatable.Rows[index]["G300"] = 0;

                fgaId = profilereportdatatable.Rows[index]["fgaid"].ToString().Trim();

                // Fill on-hand data into Profile report datatable
                for (int indey = 0; indey < onhandreportdatatable.Rows.Count; indey++)
                {
                    if (fgaId.Equals(onhandreportdatatable.Rows[indey]["FGAID"]))
                    {
                        profilereportdatatable.Rows[index]["On_hand"] = onhandreportdatatable.Rows[indey]["Total_Qty"];
                        break;
                    }
                }

                // Fill aging data into Profile report datatable
                string partNum = string.Empty;
                int quantity = 0;
                int ageDays = 0;

                for (int indez = 0; indez < agingreportdatatable.Rows.Count; indez++)
                {
                    partNum = agingreportdatatable.Rows[indez]["FGA"].ToString().Trim();
                    quantity = Convert.ToInt32(agingreportdatatable.Rows[indez]["Pcs"]);
                    ageDays = Convert.ToInt32(agingreportdatatable.Rows[indez]["Age"]);

                    if (fgaId.Equals(partNum))
                    {
                        if (ageDays > 300)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                            profilereportdatatable.Rows[index]["G45"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G45"]) + quantity;
                            profilereportdatatable.Rows[index]["G60"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G60"]) + quantity;
                            profilereportdatatable.Rows[index]["G90"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G90"]) + quantity;
                            profilereportdatatable.Rows[index]["G120"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G120"]) + quantity;
                            profilereportdatatable.Rows[index]["G150"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G150"]) + quantity;
                            profilereportdatatable.Rows[index]["G200"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G200"]) + quantity;
                            profilereportdatatable.Rows[index]["G250"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G250"]) + quantity;
                            profilereportdatatable.Rows[index]["G300"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G300"]) + quantity;

                        }
                        else if (ageDays >= 251 && ageDays <= 300)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                            profilereportdatatable.Rows[index]["G45"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G45"]) + quantity;
                            profilereportdatatable.Rows[index]["G60"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G60"]) + quantity;
                            profilereportdatatable.Rows[index]["G90"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G90"]) + quantity;
                            profilereportdatatable.Rows[index]["G120"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G120"]) + quantity;
                            profilereportdatatable.Rows[index]["G150"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G150"]) + quantity;
                            profilereportdatatable.Rows[index]["G200"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G200"]) + quantity;
                            profilereportdatatable.Rows[index]["G250"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G250"]) + quantity;
                        }
                        else if (ageDays >= 201 && ageDays <= 250)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                            profilereportdatatable.Rows[index]["G45"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G45"]) + quantity;
                            profilereportdatatable.Rows[index]["G60"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G60"]) + quantity;
                            profilereportdatatable.Rows[index]["G90"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G90"]) + quantity;
                            profilereportdatatable.Rows[index]["G120"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G120"]) + quantity;
                            profilereportdatatable.Rows[index]["G150"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G150"]) + quantity;
                            profilereportdatatable.Rows[index]["G200"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G200"]) + quantity;
                        }
                        else if (ageDays >= 151 && ageDays <= 200)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                            profilereportdatatable.Rows[index]["G45"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G45"]) + quantity;
                            profilereportdatatable.Rows[index]["G60"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G60"]) + quantity;
                            profilereportdatatable.Rows[index]["G90"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G90"]) + quantity;
                            profilereportdatatable.Rows[index]["G120"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G120"]) + quantity;
                            profilereportdatatable.Rows[index]["G150"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G150"]) + quantity;
                        }
                        else if (ageDays >= 121 && ageDays <= 150)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                            profilereportdatatable.Rows[index]["G45"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G45"]) + quantity;
                            profilereportdatatable.Rows[index]["G60"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G60"]) + quantity;
                            profilereportdatatable.Rows[index]["G90"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G90"]) + quantity;
                            profilereportdatatable.Rows[index]["G120"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G120"]) + quantity;
                        }
                        else if (ageDays >= 91 && ageDays <= 120)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                            profilereportdatatable.Rows[index]["G45"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G45"]) + quantity;
                            profilereportdatatable.Rows[index]["G60"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G60"]) + quantity;
                            profilereportdatatable.Rows[index]["G90"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G90"]) + quantity;
                        }
                        else if (ageDays >= 61 && ageDays <= 90)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                            profilereportdatatable.Rows[index]["G45"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G45"]) + quantity;
                            profilereportdatatable.Rows[index]["G60"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G60"]) + quantity;
                        }
                        else if (ageDays >= 46 && ageDays <= 60)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                            profilereportdatatable.Rows[index]["G45"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G45"]) + quantity;
                        }
                        else if (ageDays >= 31 && ageDays <= 45)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                            profilereportdatatable.Rows[index]["G30"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G30"]) + quantity;
                        }
                        else if (ageDays >= 16 && ageDays <= 30)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                            profilereportdatatable.Rows[index]["G15"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G15"]) + quantity;
                        }
                        else if (ageDays >= 11 && ageDays <= 15)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                            profilereportdatatable.Rows[index]["G10"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G10"]) + quantity;
                        }
                        else if (ageDays >= 6 && ageDays <= 10)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                            profilereportdatatable.Rows[index]["G5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["G5"]) + quantity;
                        }
                        else if (ageDays <= 5)
                        {
                            profilereportdatatable.Rows[index]["L5"] = Convert.ToInt32(profilereportdatatable.Rows[index]["L5"]) + quantity;
                        }                        
                    }
                }
            }
        }

        private void ExportReport()
        {
            //string thirdFileName = ConfigFileUtility.GetValue("3PLFileNameListFileName");
            //string newFileName = string.Format("{0}.csv", filename.Remove(filename.Length - 4, 4));
            //string fullFileName = Path.Combine(ConfigFileUtility.GetValue("OutputFolder"), newFileName);

            string fileName = Path.Combine(userselectedvalue.AgingReportOutputFolder,
                string.Format("{0}_{1}.csv", "DAO_Aging", DateTime.Now.ToString("yyyy-MM-dd_HHmm")));

            MiscUtility.LogHistory(string.Format("Starting to export data into Excel file - {0}...", fileName));
            MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Starting to export data into Excel file - {1}...", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), fileName));

            try
            {
                ExcelFileUtility.ExportDataIntoCSVFile(fileName, profilereportdatatable);
                //MiscUtility.SaveFile(thirdFileName, filename);

                MiscUtility.LogHistory("Done!");
                MainForm.backgroundworker.ReportProgress(0, string.Format("[{0}] - Done!", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            }
            catch (Exception ex)
            {
                MiscUtility.LogHistory(string.Format("Function name: <ExportToExcelFile>, Source:{0},  Error:{1}", ex.Source, ex.Message));
                throw;
            }
        }
    }

}
