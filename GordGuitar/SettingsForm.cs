using System;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class SettingsForm : Form
    {
        private const string oldURL = "sounds/";
        private const string proURL = "sounds/";

        public string soundsURL { get; private set; }

        public SettingsForm(string soundsURL)
        {
            InitializeComponent();

            this.soundsURL = soundsURL;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (proButton.Checked)
                soundsURL = proURL;
            else
                soundsURL = oldURL;

            Close();
        }
    }
}
