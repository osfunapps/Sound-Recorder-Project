﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sound_Recorder_Project
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            SetHistory();
        }

        private void SetHistory()
        {
            historyRTB.Text = AppCoordinator.RecordLog;
        }
    }
}
