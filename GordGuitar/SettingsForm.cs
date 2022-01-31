using System;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class SettingsForm : Form
    {
        private const string oldURL = "oldsounds/";
        private const string proURL = "prosounds/";

        public string soundsURL { get; private set; }

        public SettingsForm(string soundsURL)
        {
            InitializeComponent();

            this.soundsURL = soundsURL;

            if (soundsURL == proURL)
                proButton.Checked = true;
            else
                oldButton.Checked = true;
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
