﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimeTracker
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            copyrightLabel.Text = copyrightLabel.Text.Replace("@year", DateTime.Now.Year.ToString());

            Version? version = Assembly.GetExecutingAssembly().GetName().Version;

            versionLabel.Text = versionLabel.Text.Replace("@version", version?.ToString() ?? "");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
