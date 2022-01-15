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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            TempInitializeChords();
        }

        public void TempInitializeChords()
        {
            buttonChord1.chord.guitarStrings[0].URL = "sounds/0l1s.wav";
            buttonChord1.chord.guitarStrings[1].URL = "sounds/1l2s.wav";
            buttonChord1.chord.guitarStrings[2].URL = "sounds/2l3s.wav";
            buttonChord1.chord.guitarStrings[3].URL = "sounds/2l4s.wav";
            buttonChord1.chord.guitarStrings[4].URL = "sounds/0l5s.wav";
            //buttonChord1.chord.guitarStrings[5].URL = "mute.wav";
        }
    }
}
