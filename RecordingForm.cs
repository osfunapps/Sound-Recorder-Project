using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.project;
using Sound_Recorder_Project.program;
using Sound_Recorder_Project.program.tools;
using Sound_Recorder_Project.Properties;

namespace Sound_Recorder_Project
{
    public partial class RecordingForm : Form
    {
        private String RECORDING_ON = " (recording)";
        private String RECORDING_OFF = " (not recording)";

        public RecordingForm()
        {
            InitializeComponent();
            CheckRecording();
            LoadSettings();
        }

        private void CheckRecording()
        {
            if (SoundManager.Recording)
                this.Text = this.Text + RECORDING_ON;
            else
                this.Text = this.Text + RECORDING_OFF;
        }

        private void LoadSettings()
        {

            outputFolderTB.Text = Settings.Default.recordsPath;
            storageSpaceTB.Text = Settings.Default.memoryAllocation.ToString();
            recordRateTB.Text = Settings.Default.waveRate.ToString();
            recordTimeTB.Text = Settings.Default.recordingCycleTime.ToString();
            runOnStartupCB.Checked = Settings.Default.runOnStartup;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveSettings();
            MyUtils.RunOnStartup(runOnStartupCB.Checked);
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            MyUtils.ExitProgram(); //to turn off current app
        }

        private void SaveSettings()
        {
            Settings.Default.Upgrade();
            Settings.Default.recordsPath = outputFolderTB.Text;
            Settings.Default.memoryAllocation = int.Parse(storageSpaceTB.Text);
            Settings.Default.waveRate= int.Parse(recordRateTB.Text);
            Settings.Default.recordingCycleTime = int.Parse(recordTimeTB.Text);
            Settings.Default.runOnStartup = runOnStartupCB.Checked;
            Settings.Default.Save();
        }

        private void outputFolderDialog_FileOk(object sender, CancelEventArgs e)
        {
            outputFolderTB.Text = TitleExporter(sender.ToString());
        }

        private string TitleExporter(string fileLongStr) { return fileLongStr.ToString().Substring(fileLongStr.ToString().IndexOf("FileName: ") + 10); }

        private void OutputTBDropHandler(object sender, DragEventArgs e)
        {
            outputFolderTB.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
        }

        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void outputFolderBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();
            if (result == DialogResult.OK && outputFolderDialog.SelectedPath.Length > 0)
            {
                outputFolderTB.Text = outputFolderDialog.SelectedPath;
            }
        }

        private void outputFolderDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            new HistoryForm().ShowDialog();
        }

        private void Terminate_Click(object sender, EventArgs e)
        {
            MyUtils.ExitProgram();
        }

        private void logBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Logger.GetTxt(), Logger.TITLE);
        }
    }

}
