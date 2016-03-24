using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO_3PL_Report_Tool
{
    public class ExcelAccessDAO : ExcelFileAccess
    {
        public ExcelAccessDAO()
        {
        }

        public ExcelAccessDAO(string filename)
            : base(filename)
        {
            try
            {
                if (base.connection.State == System.Data.ConnectionState.Closed)
                {
                    base.connection.Open();
                }
            }
            catch
            {
                throw;
            }
        }

        public ExcelAccessDAO(string filename, bool isfield)
            : base(filename, isfield)
        {
            try
            {
                if (base.connection.State == System.Data.ConnectionState.Closed)
                {
                    base.connection.Open();
                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetExcelSheetName()
        {
            DataTable schematable = base.connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "TABLE" });
            return schematable;
        }

        //public bool IsEqualSheetName(string sheetname)
        //{
        //    DataTable sheetNameList = GetExcelSheetName();

        //    for (int index = 0; index < sheetNameList.Rows.Count; index++)
        //    {
        //        if (sheetNameList.Rows[index]["TABLE_NAME"].ToString().ToUpper().Equals(sheetname.ToUpper()))
        //            return true;
        //    }

        //    return false;
        //}

        public string IsContainSheetName(string sheetname)
        {
            DataTable sheetNameList = GetExcelSheetName();

            for (int index = 0; index < sheetNameList.Rows.Count; index++)
            {
                if (sheetNameList.Rows[index]["TABLE_NAME"].ToString().ToUpper().Contains(sheetname.ToUpper()))
                    return sheetNameList.Rows[index]["TABLE_NAME"].ToString();
            }

            return string.Empty;
        }

        public DataSet ReadExcelFile(string sheetname)
        {
            string sqlString = string.Empty;

            if (sheetname.Contains("$"))
                sqlString = String.Format("SELECT * FROM [{0}];", sheetname);
            else
                sqlString = String.Format("SELECT * FROM [{0}$];", sheetname);

            return this.ExecuteQuery(sqlString);
        }

        public DataSet ReadExcelFile(string sheetname, string fieldname)
        {
            string sqlString = string.Empty;

            if (sheetname.Contains("$"))
                sqlString = String.Format("SELECT {0} FROM [{1}];", fieldname, sheetname);
            else
                sqlString = String.Format("SELECT {0} FROM [{1}$];", fieldname, sheetname);

            return this.ExecuteQuery(sqlString);
        }

        public DataTable ReadAgingReportFile(string sheetname)
        {
            return ReadExcelFile(sheetname, "FGA, Age, Pcs").Tables[0];
        }

        public DataTable ReadProfileReportFile(string sheetname)
        {
            return ReadExcelFile(sheetname).Tables[0];
        }

        public DataTable ReadOnhandReportFile(string sheetname)
        {
            return ReadExcelFile(sheetname, "FGAID, Total_Qty").Tables[0];
        }
    }
}
