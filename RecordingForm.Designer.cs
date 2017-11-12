using System.Windows.Forms;

namespace Sound_Recorder_Project
{
    partial class RecordingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.storageSpaceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputFolderBrowseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFolderTB = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recordLogBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.recordRateTB = new System.Windows.Forms.TextBox();
            this.recordTimeTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.LinkLabel();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.terminateBtn = new System.Windows.Forms.Button();
            this.runOnStartupCB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.storageSpaceTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.outputFolderBrowseBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.outputFolderTB);
            this.groupBox1.Controls.Add(this.pathLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Settings";
            // 
            // storageSpaceTB
            // 
            this.storageSpaceTB.Location = new System.Drawing.Point(15, 134);
            this.storageSpaceTB.Name = "storageSpaceTB";
            this.storageSpaceTB.Size = new System.Drawing.Size(119, 20);
            this.storageSpaceTB.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(155, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "* in mb";
            // 
            // outputFolderBrowseBtn
            // 
            this.outputFolderBrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderBrowseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputFolderBrowseBtn.Location = new System.Drawing.Point(305, 66);
            this.outputFolderBrowseBtn.Name = "outputFolderBrowseBtn";
            this.outputFolderBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.outputFolderBrowseBtn.TabIndex = 8;
            this.outputFolderBrowseBtn.Text = "Browse...";
            this.outputFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.outputFolderBrowseBtn.Click += new System.EventHandler(this.outputFolderBrowseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Storage allocated space";
            // 
            // outputFolderTB
            // 
            this.outputFolderTB.AllowDrop = true;
            this.outputFolderTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderTB.Location = new System.Drawing.Point(15, 68);
            this.outputFolderTB.Name = "outputFolderTB";
            this.outputFolderTB.Size = new System.Drawing.Size(274, 20);
            this.outputFolderTB.TabIndex = 6;
            this.outputFolderTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutputTBDropHandler);
            this.outputFolderTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pathLabel.Location = new System.Drawing.Point(12, 37);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(68, 13);
            this.pathLabel.TabIndex = 7;
            this.pathLabel.Text = "Output folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(107, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "* in minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(15, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Record time";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.runOnStartupCB);
            this.groupBox2.Controls.Add(this.recordLogBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.recordRateTB);
            this.groupBox2.Controls.Add(this.recordTimeTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 211);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Record Settings";
            // 
            // recordLogBtn
            // 
            this.recordLogBtn.BackColor = System.Drawing.SystemColors.Control;
            this.recordLogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLogBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.recordLogBtn.Location = new System.Drawing.Point(277, 65);
            this.recordLogBtn.Name = "recordLogBtn";
            this.recordLogBtn.Size = new System.Drawing.Size(100, 62);
            this.recordLogBtn.TabIndex = 23;
            this.recordLogBtn.Text = "Record Log";
            this.recordLogBtn.UseVisualStyleBackColor = false;
            this.recordLogBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(107, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "* 8000 - 44000";
            // 
            // recordRateTB
            // 
            this.recordRateTB.Location = new System.Drawing.Point(18, 138);
            this.recordRateTB.Name = "recordRateTB";
            this.recordRateTB.Size = new System.Drawing.Size(71, 20);
            this.recordRateTB.TabIndex = 19;
            // 
            // recordTimeTB
            // 
            this.recordTimeTB.Location = new System.Drawing.Point(19, 65);
            this.recordTimeTB.Name = "recordTimeTB";
            this.recordTimeTB.Size = new System.Drawing.Size(71, 20);
            this.recordTimeTB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Record rate";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Location = new System.Drawing.Point(348, 447);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 51);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save and restart";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.AutoSize = true;
            this.logBtn.Location = new System.Drawing.Point(12, 494);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(29, 13);
            this.logBtn.TabIndex = 22;
            this.logBtn.TabStop = true;
            this.logBtn.Text = "LOG";
            this.logBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logBtn_LinkClicked);
            // 
            // outputFolderDialog
            // 
            this.outputFolderDialog.HelpRequest += new System.EventHandler(this.outputFolderDialog_HelpRequest);
            // 
            // terminateBtn
            // 
            this.terminateBtn.BackColor = System.Drawing.Color.Red;
            this.terminateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminateBtn.ForeColor = System.Drawing.Color.White;
            this.terminateBtn.Location = new System.Drawing.Point(15, 447);
            this.terminateBtn.Name = "terminateBtn";
            this.terminateBtn.Size = new System.Drawing.Size(77, 32);
            this.terminateBtn.TabIndex = 23;
            this.terminateBtn.Text = "Terminate";
            this.terminateBtn.UseVisualStyleBackColor = false;
            this.terminateBtn.Click += new System.EventHandler(this.Terminate_Click);
            // 
            // runOnStartupCB
            // 
            this.runOnStartupCB.AutoSize = true;
            this.runOnStartupCB.Location = new System.Drawing.Point(19, 180);
            this.runOnStartupCB.Name = "runOnStartupCB";
            this.runOnStartupCB.Size = new System.Drawing.Size(96, 17);
            this.runOnStartupCB.TabIndex = 24;
            this.runOnStartupCB.Text = "Run on startup";
            this.runOnStartupCB.UseVisualStyleBackColor = true;
            // 
            // RecordingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(460, 516);
            this.Controls.Add(this.terminateBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveBtn);
            this.Name = "RecordingForm";
            this.Text = "General Settings - Sound Recorder ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button outputFolderBrowseBtn;
        private TextBox outputFolderTB;
        private Label pathLabel;
        private TextBox storageSpaceTB;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox recordRateTB;
        private TextBox recordTimeTB;
        private Label label3;
        private Button saveBtn;
        private LinkLabel logBtn;
        private FolderBrowserDialog outputFolderDialog;
        private Button recordLogBtn;
        private Button terminateBtn;
        private CheckBox runOnStartupCB;
    }
}

