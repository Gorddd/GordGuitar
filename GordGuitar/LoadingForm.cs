using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();

            LoadGameForm();
        }

        private async void LoadGameForm()
        {
            await Task.Run(() =>
            {
                GameForm gameForm = new GameForm((m) =>
                {
                    progressBar.Value += 10;
                    message.Text = m;
                });
                Hide();
                gameForm.ShowDialog();
                Close();
            });
        }
    }
}
