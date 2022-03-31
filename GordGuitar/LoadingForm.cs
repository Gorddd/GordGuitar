using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();

            new Thread(() => 
            { 
                GameForm gameForm = new GameForm();
                Hide();
                gameForm.ShowDialog();
                Close();
            }).Start();
        }
    }
}
