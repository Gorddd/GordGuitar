﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class GameForm : Form
    {
        private OptionsForm optionsForm = new OptionsForm();

        public GameForm()
        {
            InitializeComponent();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            optionsForm.ShowDialog();
        }
    }
}
