﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class StopWatchForm : Form
    {
        public StopWatchForm()
        {
            InitializeComponent();

            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized; // or Manual + custom size
        }

        public void UpdateDisplay(string text)
        {
            timerText.Text = text;
        }
    }
}
