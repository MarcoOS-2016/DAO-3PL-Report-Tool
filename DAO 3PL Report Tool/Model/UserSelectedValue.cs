using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO_3PL_Report_Tool
{
    public class UserSelectedValue
    {
        private DateTime begindate;
        private DateTime enddate;
        private DateTime snapshotdate;
        private string sourcefolder;
        private string outputfolder;
        private string agingreportfile;
        private string profilereportfile;
        private string onhandreportfile;
        private string agingreportoutputfolder;

        public DateTime BeginDate
        {
            get { return begindate; }
            set { begindate = value; }
        }

        public DateTime EndDate
        {
            get { return enddate; }
            set { enddate = value; }
        }

        public DateTime SnapshotDate
        {
            get { return snapshotdate; }
            set { snapshotdate = value; }
        }

        public string SourceFolder
        {
            get { return sourcefolder; }
            set { sourcefolder = value; }
        }

        public string OutputFolder
        {
            get { return outputfolder; }
            set { outputfolder = value; }
        }

        public string AgingReportFile
        {
            get { return agingreportfile; }
            set { agingreportfile = value; }
        }

        public string ProfileReportFile
        {
            get { return profilereportfile; }
            set { profilereportfile = value; }
        }

        public string OnhandReportFile
        {
            get { return onhandreportfile; }
            set { onhandreportfile = value; }
        }

        public string AgingReportOutputFolder
        {
            get { return agingreportoutputfolder; }
            set { agingreportoutputfolder = value; }
        }
    }
}
