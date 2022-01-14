using System;
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

            InitializeChords();
        }

        private void InitializeChords()
        {
            buttonChord1.chord = optionsForm.buttonChord1.chord;
            buttonChord2.chord = optionsForm.buttonChord2.chord;
            buttonChord3.chord = optionsForm.buttonChord3.chord;
            buttonChord4.chord = optionsForm.buttonChord4.chord;
            buttonChord5.chord = optionsForm.buttonChord5.chord;
            buttonChord6.chord = optionsForm.buttonChord6.chord;
            buttonChord7.chord = optionsForm.buttonChord7.chord;
            buttonChord8.chord = optionsForm.buttonChord8.chord;
            buttonChord9.chord = optionsForm.buttonChord9.chord;
            buttonChord10.chord = optionsForm.buttonChord10.chord;
        }
    }
}
