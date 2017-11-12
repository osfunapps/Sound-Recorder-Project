namespace Sound_Recorder_Project
{
    partial class HistoryForm
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
            this.historyRTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // historyRTB
            // 
            this.historyRTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historyRTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.historyRTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.historyRTB.Location = new System.Drawing.Point(13, 13);
            this.historyRTB.Name = "historyRTB";
            this.historyRTB.ReadOnly = true;
            this.historyRTB.Size = new System.Drawing.Size(692, 320);
            this.historyRTB.TabIndex = 0;
            this.historyRTB.Text = "";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 345);
            this.Controls.Add(this.historyRTB);
            this.Name = "HistoryForm";
            this.Text = "Record log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox historyRTB;
    }
}