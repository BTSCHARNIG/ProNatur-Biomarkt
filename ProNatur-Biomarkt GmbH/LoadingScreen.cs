﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();

        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            if (loadingprogressBar.Value< loadingprogressBar.Maximum)
            {
                loadingBarValue += 1;
                loadingprogressBar.Value = loadingBarValue;
                lblLoadingValue.Text = loadingBarValue.ToString() + "%";
            }
            else
            {
                loadingbarTimer.Stop();
            }
            
        }

        
    }
}
