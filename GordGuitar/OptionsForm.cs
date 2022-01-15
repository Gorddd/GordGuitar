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

        /// <summary>
        /// Variable for user interface (string buttons)
        /// </summary>
        private Designer<Button> stringButtonDesigner;

        /// <summary>
        /// Variable for user interface (Chord buttons)
        /// </summary>
        private Designer<ChordButton> buttonDesigner;



        public OptionsForm()
        {
            InitializeComponent();
            TempInitializeChords();

        }

        private void InitializeDesigners()
        {

        }

        public void TempInitializeChords()
        {
            buttonChord1.chord.guitarStrings[0].URL = "sounds/0l1s.wav";
            buttonChord1.chord.guitarStrings[1].URL = "sounds/1l2s.wav";
            buttonChord1.chord.guitarStrings[2].URL = "sounds/2l3s.wav";
            buttonChord1.chord.guitarStrings[3].URL = "sounds/2l4s.wav";
            buttonChord1.chord.guitarStrings[4].URL = "sounds/0l5s.wav";

            buttonChord2.chord.guitarStrings[0].URL = "sounds/0l1s.wav";
            buttonChord2.chord.guitarStrings[1].URL = "sounds/0l2s.wav";
            buttonChord2.chord.guitarStrings[2].URL = "sounds/1l3s.wav";
            buttonChord2.chord.guitarStrings[3].URL = "sounds/2l4s.wav";
            buttonChord2.chord.guitarStrings[4].URL = "sounds/2l5s.wav";
            buttonChord2.chord.guitarStrings[5].URL = "sounds/0l6s.wav";
        }
    }
}
