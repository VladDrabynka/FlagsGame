﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagsGame
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            cbGameMode.SelectedIndex = cbGameMode.FindString("Классика");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(cbGameMode.SelectedIndex == 0)
            {
                Classic mCh = new Classic(false);
                mCh.Show();
            }
            if (cbGameMode.SelectedIndex == 1)
            {
                Classic mCh = new Classic(true);
                mCh.Show();
            }
            if(cbGameMode.SelectedIndex == 2)
            {
                MultipleFlags mFlg = new MultipleFlags();
                mFlg.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
