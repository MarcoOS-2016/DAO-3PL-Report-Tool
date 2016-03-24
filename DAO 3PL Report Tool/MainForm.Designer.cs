namespace DAO_3PL_Report_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab1_startButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab1_outputFolderButton = new System.Windows.Forms.Button();
            this.tab1_sourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.tab1_outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.tab1_sourceFolderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab1_beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tab1_snapShotDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tab1_endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab2_startButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tab2_outputFolderButton = new System.Windows.Forms.Button();
            this.tab2_outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tab2_onhandReportFileButton = new System.Windows.Forms.Button();
            this.tab2_onhandReportFileTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tab2_profileReportFileButton = new System.Windows.Forms.Button();
            this.tab2_aginReportFileTextBox = new System.Windows.Forms.TextBox();
            this.tab2_profileReportFileTextBox = new System.Windows.Forms.TextBox();
            this.tab2_agingReportFileButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1_startButton
            // 
            this.tab1_startButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab1_startButton.Location = new System.Drawing.Point(613, 247);
            this.tab1_startButton.Name = "tab1_startButton";
            this.tab1_startButton.Size = new System.Drawing.Size(100, 30);
            this.tab1_startButton.TabIndex = 59;
            this.tab1_startButton.Text = "Start";
            this.tab1_startButton.UseVisualStyleBackColor = true;
            this.tab1_startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 341);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(746, 22);
            this.statusStrip.TabIndex = 63;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(-1, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 332);
            this.tabControl1.TabIndex = 64;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tab1_startButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "3PL Report Consolidation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tab1_outputFolderButton);
            this.groupBox1.Controls.Add(this.tab1_sourceFolderTextBox);
            this.groupBox1.Controls.Add(this.tab1_outputFolderTextBox);
            this.groupBox1.Controls.Add(this.tab1_sourceFolderButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tab1_beginDateTimePicker);
            this.groupBox1.Controls.Add(this.tab1_snapShotDateTimePicker);
            this.groupBox1.Controls.Add(this.tab1_endDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 225);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(411, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "End Date of TRAN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Folder of Source Reports:";
            // 
            // tab1_outputFolderButton
            // 
            this.tab1_outputFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1_outputFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("tab1_outputFolderButton.Image")));
            this.tab1_outputFolderButton.Location = new System.Drawing.Point(676, 177);
            this.tab1_outputFolderButton.Name = "tab1_outputFolderButton";
            this.tab1_outputFolderButton.Size = new System.Drawing.Size(28, 25);
            this.tab1_outputFolderButton.TabIndex = 74;
            this.tab1_outputFolderButton.UseVisualStyleBackColor = true;
            // 
            // tab1_sourceFolderTextBox
            // 
            this.tab1_sourceFolderTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab1_sourceFolderTextBox.Location = new System.Drawing.Point(174, 136);
            this.tab1_sourceFolderTextBox.Name = "tab1_sourceFolderTextBox";
            this.tab1_sourceFolderTextBox.Size = new System.Drawing.Size(496, 23);
            this.tab1_sourceFolderTextBox.TabIndex = 64;
            // 
            // tab1_outputFolderTextBox
            // 
            this.tab1_outputFolderTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab1_outputFolderTextBox.Location = new System.Drawing.Point(174, 179);
            this.tab1_outputFolderTextBox.Name = "tab1_outputFolderTextBox";
            this.tab1_outputFolderTextBox.Size = new System.Drawing.Size(496, 23);
            this.tab1_outputFolderTextBox.TabIndex = 73;
            // 
            // tab1_sourceFolderButton
            // 
            this.tab1_sourceFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1_sourceFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("tab1_sourceFolderButton.Image")));
            this.tab1_sourceFolderButton.Location = new System.Drawing.Point(676, 135);
            this.tab1_sourceFolderButton.Name = "tab1_sourceFolderButton";
            this.tab1_sourceFolderButton.Size = new System.Drawing.Size(28, 25);
            this.tab1_sourceFolderButton.TabIndex = 65;
            this.tab1_sourceFolderButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(76, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Output Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Begin Date of TRAN:";
            // 
            // tab1_beginDateTimePicker
            // 
            this.tab1_beginDateTimePicker.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab1_beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tab1_beginDateTimePicker.Location = new System.Drawing.Point(174, 28);
            this.tab1_beginDateTimePicker.Name = "tab1_beginDateTimePicker";
            this.tab1_beginDateTimePicker.Size = new System.Drawing.Size(138, 23);
            this.tab1_beginDateTimePicker.TabIndex = 67;
            // 
            // tab1_snapShotDateTimePicker
            // 
            this.tab1_snapShotDateTimePicker.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab1_snapShotDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tab1_snapShotDateTimePicker.Location = new System.Drawing.Point(174, 69);
            this.tab1_snapShotDateTimePicker.Name = "tab1_snapShotDateTimePicker";
            this.tab1_snapShotDateTimePicker.Size = new System.Drawing.Size(138, 23);
            this.tab1_snapShotDateTimePicker.TabIndex = 71;
            // 
            // tab1_endDateTimePicker
            // 
            this.tab1_endDateTimePicker.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab1_endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tab1_endDateTimePicker.Location = new System.Drawing.Point(532, 28);
            this.tab1_endDateTimePicker.Name = "tab1_endDateTimePicker";
            this.tab1_endDateTimePicker.Size = new System.Drawing.Size(138, 23);
            this.tab1_endDateTimePicker.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Inventory SnapShot Date:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.tab2_startButton);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aging Report";
            // 
            // tab2_startButton
            // 
            this.tab2_startButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab2_startButton.Location = new System.Drawing.Point(615, 238);
            this.tab2_startButton.Name = "tab2_startButton";
            this.tab2_startButton.Size = new System.Drawing.Size(100, 30);
            this.tab2_startButton.TabIndex = 65;
            this.tab2_startButton.Text = "Start";
            this.tab2_startButton.UseVisualStyleBackColor = true;
            this.tab2_startButton.Click += new System.EventHandler(this.tab2_startButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tab2_outputFolderButton);
            this.groupBox2.Controls.Add(this.tab2_outputFolderTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tab2_onhandReportFileButton);
            this.groupBox2.Controls.Add(this.tab2_onhandReportFileTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tab2_profileReportFileButton);
            this.groupBox2.Controls.Add(this.tab2_aginReportFileTextBox);
            this.groupBox2.Controls.Add(this.tab2_profileReportFileTextBox);
            this.groupBox2.Controls.Add(this.tab2_agingReportFileButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 210);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // tab2_outputFolderButton
            // 
            this.tab2_outputFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2_outputFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("tab2_outputFolderButton.Image")));
            this.tab2_outputFolderButton.Location = new System.Drawing.Point(676, 161);
            this.tab2_outputFolderButton.Name = "tab2_outputFolderButton";
            this.tab2_outputFolderButton.Size = new System.Drawing.Size(28, 25);
            this.tab2_outputFolderButton.TabIndex = 80;
            this.tab2_outputFolderButton.UseVisualStyleBackColor = true;
            this.tab2_outputFolderButton.Click += new System.EventHandler(this.tab2_outputFolderButton_Click);
            // 
            // tab2_outputFolderTextBox
            // 
            this.tab2_outputFolderTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab2_outputFolderTextBox.Location = new System.Drawing.Point(171, 162);
            this.tab2_outputFolderTextBox.Name = "tab2_outputFolderTextBox";
            this.tab2_outputFolderTextBox.Size = new System.Drawing.Size(499, 23);
            this.tab2_outputFolderTextBox.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(74, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Output Folder:";
            // 
            // tab2_onhandReportFileButton
            // 
            this.tab2_onhandReportFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2_onhandReportFileButton.Image = ((System.Drawing.Image)(resources.GetObject("tab2_onhandReportFileButton.Image")));
            this.tab2_onhandReportFileButton.Location = new System.Drawing.Point(676, 116);
            this.tab2_onhandReportFileButton.Name = "tab2_onhandReportFileButton";
            this.tab2_onhandReportFileButton.Size = new System.Drawing.Size(28, 25);
            this.tab2_onhandReportFileButton.TabIndex = 77;
            this.tab2_onhandReportFileButton.UseVisualStyleBackColor = true;
            this.tab2_onhandReportFileButton.Click += new System.EventHandler(this.tab2_onhandReportFileButton_Click);
            // 
            // tab2_onhandReportFileTextBox
            // 
            this.tab2_onhandReportFileTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab2_onhandReportFileTextBox.Location = new System.Drawing.Point(171, 117);
            this.tab2_onhandReportFileTextBox.Name = "tab2_onhandReportFileTextBox";
            this.tab2_onhandReportFileTextBox.Size = new System.Drawing.Size(499, 23);
            this.tab2_onhandReportFileTextBox.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "On-hand Report File:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "DAO Aging Report File:";
            // 
            // tab2_profileReportFileButton
            // 
            this.tab2_profileReportFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2_profileReportFileButton.Image = ((System.Drawing.Image)(resources.GetObject("tab2_profileReportFileButton.Image")));
            this.tab2_profileReportFileButton.Location = new System.Drawing.Point(676, 72);
            this.tab2_profileReportFileButton.Name = "tab2_profileReportFileButton";
            this.tab2_profileReportFileButton.Size = new System.Drawing.Size(28, 25);
            this.tab2_profileReportFileButton.TabIndex = 74;
            this.tab2_profileReportFileButton.UseVisualStyleBackColor = true;
            this.tab2_profileReportFileButton.Click += new System.EventHandler(this.tab2_profileButton_Click);
            // 
            // tab2_aginReportFileTextBox
            // 
            this.tab2_aginReportFileTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab2_aginReportFileTextBox.Location = new System.Drawing.Point(171, 30);
            this.tab2_aginReportFileTextBox.Name = "tab2_aginReportFileTextBox";
            this.tab2_aginReportFileTextBox.Size = new System.Drawing.Size(499, 23);
            this.tab2_aginReportFileTextBox.TabIndex = 64;
            // 
            // tab2_profileReportFileTextBox
            // 
            this.tab2_profileReportFileTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tab2_profileReportFileTextBox.Location = new System.Drawing.Point(171, 73);
            this.tab2_profileReportFileTextBox.Name = "tab2_profileReportFileTextBox";
            this.tab2_profileReportFileTextBox.Size = new System.Drawing.Size(499, 23);
            this.tab2_profileReportFileTextBox.TabIndex = 73;
            // 
            // tab2_agingReportFileButton
            // 
            this.tab2_agingReportFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2_agingReportFileButton.Image = ((System.Drawing.Image)(resources.GetObject("tab2_agingReportFileButton.Image")));
            this.tab2_agingReportFileButton.Location = new System.Drawing.Point(676, 29);
            this.tab2_agingReportFileButton.Name = "tab2_agingReportFileButton";
            this.tab2_agingReportFileButton.Size = new System.Drawing.Size(28, 25);
            this.tab2_agingReportFileButton.TabIndex = 65;
            this.tab2_agingReportFileButton.UseVisualStyleBackColor = true;
            this.tab2_agingReportFileButton.Click += new System.EventHandler(this.tab2_agingReportButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 72;
            this.label8.Text = "DAO Profile Report File:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 363);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAO 3PL Report Consolidation Tool(Ver.10292015)";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tab1_startButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tab1_outputFolderButton;
        private System.Windows.Forms.TextBox tab1_sourceFolderTextBox;
        private System.Windows.Forms.TextBox tab1_outputFolderTextBox;
        private System.Windows.Forms.Button tab1_sourceFolderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tab1_beginDateTimePicker;
        private System.Windows.Forms.DateTimePicker tab1_snapShotDateTimePicker;
        private System.Windows.Forms.DateTimePicker tab1_endDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tab2_startButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tab2_profileReportFileButton;
        private System.Windows.Forms.TextBox tab2_aginReportFileTextBox;
        private System.Windows.Forms.TextBox tab2_profileReportFileTextBox;
        private System.Windows.Forms.Button tab2_agingReportFileButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button tab2_onhandReportFileButton;
        private System.Windows.Forms.TextBox tab2_onhandReportFileTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tab2_outputFolderButton;
        private System.Windows.Forms.TextBox tab2_outputFolderTextBox;
        private System.Windows.Forms.Label label9;
    }
}

