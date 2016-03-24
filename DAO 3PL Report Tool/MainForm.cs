using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace DAO_3PL_Report_Tool
{
    public partial class MainForm : Form
    {
        public static BackgroundWorker backgroundworker = new BackgroundWorker();
        private UserSelectedValue userselectedvalue = new UserSelectedValue();

        public MainForm()
        {
            InitializeComponent();
            
            tab1_sourceFolderTextBox.Text = ConfigFileUtility.GetValue("SourceFolder");
            tab1_outputFolderTextBox.Text = ConfigFileUtility.GetValue("OutputFolder");
        }

        #region ----- Tab Page - 3PL Report Consolidation -----
        private void sourceFolderButton_Click(object sender, EventArgs e)
        {
            tab1_sourceFolderTextBox.Text = SelectFolder();
        }

        private void outputFolderButton_Click(object sender, EventArgs e)
        {
            tab1_outputFolderTextBox.Text = SelectFolder();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DateTime beginDate = tab1_beginDateTimePicker.Value.Date;
            DateTime endDate = tab1_endDateTimePicker.Value.Date;
            DateTime snapshotDate = tab1_snapShotDateTimePicker.Value.Date;

            string sourceFolder = tab1_sourceFolderTextBox.Text.Trim();
            string outputFolder = tab1_outputFolderTextBox.Text.Trim();

            toolStripStatusLabel.Text = "";

            if (tab1_beginDateTimePicker.Value.Date.CompareTo(DateTime.Now.Date) == 0)
            {
                if (MessageBox.Show("Do you want to select current day as Begin Date?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            }

            if (tab1_endDateTimePicker.Value.Date.CompareTo(DateTime.Now.Date) == 0)
            {
                if (MessageBox.Show("Do you want to select current day as End Date?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
            }

            if (tab1_snapShotDateTimePicker.Value.Date.CompareTo(DateTime.Now.Date) == 0)
            {
                if (MessageBox.Show("Do you want to select current day as Snapshot Date?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
            }

            if (tab1_beginDateTimePicker.Value.Date.CompareTo(DateTime.Now.Date) > 0)
            {
                MessageBox.Show("The Begin Date is later than today!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tab1_beginDateTimePicker.Value.Date.CompareTo(tab1_endDateTimePicker.Value.Date) > 0)
            {
                MessageBox.Show("The Begin Date is later than End Date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tab1_endDateTimePicker.Value.Date.CompareTo(DateTime.Now.Date) > 0)
            {
                MessageBox.Show("The End Date is later than today!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tab1_endDateTimePicker.Value.Date.CompareTo(tab1_beginDateTimePicker.Value.Date) < 0)
            {
                MessageBox.Show("The End Date is earlier than Begin Date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tab1_snapShotDateTimePicker.Value.Date.CompareTo(DateTime.Now.Date) > 0)
            {
                MessageBox.Show("The Snapshot Date is later than today!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sourceFolder.Length == 0)
            {
                MessageBox.Show("Please select a source folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (outputFolder.Length == 0)
            {
                MessageBox.Show("Please select an output folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userselectedvalue.BeginDate = beginDate;
            userselectedvalue.EndDate = endDate;
            userselectedvalue.SnapshotDate = snapshotDate;
            userselectedvalue.SourceFolder = sourceFolder;
            userselectedvalue.OutputFolder = outputFolder;

            StartSynchronizedJob("Consolidate3PLReports");

            toolStripStatusLabel.Text = "Completed!";
        }
        #endregion

        #region ----- Tab page - Aging Report -----
        private void tab2_agingReportButton_Click(object sender, EventArgs e)
        {
            tab2_aginReportFileTextBox.Text = SelectFile();
        }

        private void tab2_profileButton_Click(object sender, EventArgs e)
        {
            tab2_profileReportFileTextBox.Text = SelectFile();
        }

        private void tab2_onhandReportFileButton_Click(object sender, EventArgs e)
        {
            tab2_onhandReportFileTextBox.Text = SelectFile();
        }

        private void tab2_outputFolderButton_Click(object sender, EventArgs e)
        {
            tab2_outputFolderTextBox.Text = SelectFolder();
        }

        private void tab2_startButton_Click(object sender, EventArgs e)
        {
            string agingReportFile = tab2_aginReportFileTextBox.Text.Trim();
            string profileReportFile = tab2_profileReportFileTextBox.Text.Trim();
            string onhandReportFile = tab2_onhandReportFileTextBox.Text.Trim();
            string agingreportoutputFolder = tab2_outputFolderTextBox.Text.Trim();

            if (agingReportFile.Length == 0)
            {
                MessageBox.Show("Please select an DAO Aging Report File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (profileReportFile.Length == 0)
            {
                MessageBox.Show("Please select DAO Profile Report File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (onhandReportFile.Length == 0)
            {
                MessageBox.Show("Please select Consolidation On-hand Report File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (agingreportoutputFolder.Length == 0)
            {
                MessageBox.Show("Please select Output Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userselectedvalue.AgingReportFile = agingReportFile;
            userselectedvalue.ProfileReportFile = profileReportFile;
            userselectedvalue.OnhandReportFile = onhandReportFile;
            userselectedvalue.AgingReportOutputFolder = agingreportoutputFolder;

            StartSynchronizedJob("BuildAgingReport");
        }
        #endregion

        private void Consolidate3PLReports()
        {
            ReportFileHandler handler = new ReportFileHandler(userselectedvalue);
            handler.Process();
        }

        private void BuildAgingReport()
        {
            AgingReportHandler handler = new AgingReportHandler(userselectedvalue);
            handler.Process();
        }

        #region ----- Backgroundworker -----        
        ProgessForm progressform = null;

        public void StartSynchronizedJob(object instance)
        {
            backgroundworker.WorkerReportsProgress = true;
            backgroundworker.WorkerSupportsCancellation = true;
            backgroundworker.DoWork += new DoWorkEventHandler(DoWork);
            backgroundworker.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged);
            backgroundworker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompletedWork);

            progressform = new ProgessForm();
            backgroundworker.RunWorkerAsync(instance);

            progressform.ShowDialog(this);
            progressform = null;
        }

        public void DoWork(object sender, DoWorkEventArgs e)
        {
            string functionName = (string)e.Argument;

            switch (functionName)
            {
                case "Consolidate3PLReports":
                    Consolidate3PLReports();
                    break;

                case "BuildAgingReport":
                    BuildAgingReport();
                    break;
            }
        }

        public void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel.Text = e.UserState.ToString();
        }

        public void CompletedWork(object sender, RunWorkerCompletedEventArgs e)
        {
            if (progressform != null)
            {
                progressform.Hide();                
                progressform = null;

                MessageBox.Show("The processing has been completed successful!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Check to see if an error occured in the 
            // background process.
            if (e.Error != null)
            {
                //IsError = true;
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(e.Error.Message);
                return;
            }

            // Check to see if the background process was cancelled.
            if (e.Cancelled)
            {
                MessageBox.Show("Processing cancelled!", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        #endregion

        #region ----- Common functions -----
        private string SelectFolder()
        {
            FolderBrowserDialog folderbrowser = new FolderBrowserDialog();
            folderbrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            folderbrowser.SelectedPath = @"C:\";
            folderbrowser.ShowNewFolderButton = true;

            if (folderbrowser.ShowDialog() == DialogResult.OK)
            {
                return folderbrowser.SelectedPath;
            }

            return String.Empty;
        }

        private string SelectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Excel file (*.xls, *.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }

            return String.Empty;
        }
        #endregion

    }
}
