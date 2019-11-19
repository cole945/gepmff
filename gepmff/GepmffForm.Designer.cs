﻿namespace gepmff
{
    partial class GepmffForm
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelConsole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBitrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVideo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAudio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNewsize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderResolution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNewBitrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderParameters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxScale = new System.Windows.Forms.ComboBox();
            this.trackBarBitrate = new System.Windows.Forms.TrackBar();
            this.checkBoxDeleteWhenDone = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCodec = new System.Windows.Forms.ComboBox();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOutdir = new System.Windows.Forms.TextBox();
            this.trackBarCRF = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCRF)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabelConsole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 37, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2555, 33);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(533, 17);
            // 
            // toolStripStatusLabelConsole
            // 
            this.toolStripStatusLabelConsole.Name = "toolStripStatusLabelConsole";
            this.toolStripStatusLabelConsole.Size = new System.Drawing.Size(0, 20);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2555, 1333);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(8, 410);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2539, 916);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewFiles);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(2519, 858);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewFiles
            // 
            this.listViewFiles.AllowDrop = true;
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderFolder,
            this.columnHeaderBitrate,
            this.columnHeaderDuration,
            this.columnHeaderVideo,
            this.columnHeaderAudio,
            this.columnHeaderSize,
            this.columnHeaderNewsize,
            this.columnHeaderResolution,
            this.columnHeaderNewBitrate,
            this.columnHeaderParameters});
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(8, 7);
            this.listViewFiles.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(2503, 844);
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewFiles_ColumnClick);
            this.listViewFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewFiles_DragDrop);
            this.listViewFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewFiles_DragEnter);
            this.listViewFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewFiles_KeyDown);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Filename";
            this.columnHeaderName.Width = 138;
            // 
            // columnHeaderFolder
            // 
            this.columnHeaderFolder.Text = "Folder";
            this.columnHeaderFolder.Width = 256;
            // 
            // columnHeaderBitrate
            // 
            this.columnHeaderBitrate.Text = "Bitrate";
            // 
            // columnHeaderDuration
            // 
            this.columnHeaderDuration.Text = "Duration";
            // 
            // columnHeaderVideo
            // 
            this.columnHeaderVideo.Text = "Video";
            // 
            // columnHeaderAudio
            // 
            this.columnHeaderAudio.Text = "Audio";
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeaderNewsize
            // 
            this.columnHeaderNewsize.Text = "New Size";
            this.columnHeaderNewsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeaderResolution
            // 
            this.columnHeaderResolution.Text = "Resolution";
            // 
            // columnHeaderNewBitrate
            // 
            this.columnHeaderNewBitrate.Text = "New bitrate";
            this.columnHeaderNewBitrate.Width = 72;
            // 
            // columnHeaderParameters
            // 
            this.columnHeaderParameters.Text = "Parameters";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxLog);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(2519, 858);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commands";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(8, 7);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(2503, 844);
            this.textBoxLog.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxScale);
            this.panel1.Controls.Add(this.trackBarBitrate);
            this.panel1.Controls.Add(this.checkBoxDeleteWhenDone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxCodec);
            this.panel1.Controls.Add(this.textBoxSuffix);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxOutdir);
            this.panel1.Controls.Add(this.trackBarCRF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2539, 389);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Scale:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Bitrate filter";
            // 
            // comboBoxScale
            // 
            this.comboBoxScale.FormattingEnabled = true;
            this.comboBoxScale.Items.AddRange(new object[] {
            "(none)",
            "720",
            "1080",
            "2160",
            "576",
            "480"});
            this.comboBoxScale.Location = new System.Drawing.Point(1027, 159);
            this.comboBoxScale.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxScale.Name = "comboBoxScale";
            this.comboBoxScale.Size = new System.Drawing.Size(316, 39);
            this.comboBoxScale.TabIndex = 20;
            this.comboBoxScale.Text = "(none)";
            // 
            // trackBarBitrate
            // 
            this.trackBarBitrate.LargeChange = 500;
            this.trackBarBitrate.Location = new System.Drawing.Point(1027, 21);
            this.trackBarBitrate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.trackBarBitrate.Maximum = 6000;
            this.trackBarBitrate.Name = "trackBarBitrate";
            this.trackBarBitrate.Size = new System.Drawing.Size(683, 114);
            this.trackBarBitrate.SmallChange = 100;
            this.trackBarBitrate.TabIndex = 19;
            this.trackBarBitrate.TickFrequency = 100;
            this.trackBarBitrate.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarBitrate.Value = 2500;
            this.trackBarBitrate.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // checkBoxDeleteWhenDone
            // 
            this.checkBoxDeleteWhenDone.AutoSize = true;
            this.checkBoxDeleteWhenDone.Location = new System.Drawing.Point(179, 315);
            this.checkBoxDeleteWhenDone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxDeleteWhenDone.Name = "checkBoxDeleteWhenDone";
            this.checkBoxDeleteWhenDone.Size = new System.Drawing.Size(335, 36);
            this.checkBoxDeleteWhenDone.TabIndex = 17;
            this.checkBoxDeleteWhenDone.Text = "Delete file when done.";
            this.checkBoxDeleteWhenDone.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Suffix";
            // 
            // comboBoxCodec
            // 
            this.comboBoxCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCodec.FormattingEnabled = true;
            this.comboBoxCodec.Items.AddRange(new object[] {
            "libx265",
            "nvenc_hevc",
            "hevc_qsv",
            "libx264",
            "nvenc_h264",
            "h264_qsv"});
            this.comboBoxCodec.Location = new System.Drawing.Point(419, 160);
            this.comboBoxCodec.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxCodec.Name = "comboBoxCodec";
            this.comboBoxCodec.Size = new System.Drawing.Size(412, 39);
            this.comboBoxCodec.TabIndex = 14;
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Location = new System.Drawing.Point(136, 155);
            this.textBoxSuffix.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(257, 38);
            this.textBoxSuffix.TabIndex = 13;
            this.textBoxSuffix.Text = "x265";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(560, 300);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(277, 69);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "CRF";
            // 
            // textBoxOutdir
            // 
            this.textBoxOutdir.Location = new System.Drawing.Point(136, 227);
            this.textBoxOutdir.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxOutdir.Name = "textBoxOutdir";
            this.textBoxOutdir.Size = new System.Drawing.Size(695, 38);
            this.textBoxOutdir.TabIndex = 10;
            // 
            // trackBarCRF
            // 
            this.trackBarCRF.Location = new System.Drawing.Point(136, 24);
            this.trackBarCRF.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.trackBarCRF.Maximum = 30;
            this.trackBarCRF.Name = "trackBarCRF";
            this.trackBarCRF.Size = new System.Drawing.Size(701, 114);
            this.trackBarCRF.TabIndex = 18;
            this.trackBarCRF.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarCRF.Value = 23;
            this.trackBarCRF.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // GepmffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2555, 1366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "GepmffForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCRF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConsole;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderFolder;
        private System.Windows.Forms.ColumnHeader columnHeaderBitrate;
        private System.Windows.Forms.ColumnHeader columnHeaderDuration;
        private System.Windows.Forms.ColumnHeader columnHeaderVideo;
        private System.Windows.Forms.ColumnHeader columnHeaderAudio;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderNewsize;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxDeleteWhenDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCodec;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOutdir;
        private System.Windows.Forms.TrackBar trackBarCRF;
        private System.Windows.Forms.TrackBar trackBarBitrate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader columnHeaderResolution;
        private System.Windows.Forms.ColumnHeader columnHeaderNewBitrate;
        private System.Windows.Forms.ColumnHeader columnHeaderParameters;
        private System.Windows.Forms.ComboBox comboBoxScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
