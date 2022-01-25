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
    public partial class OptionsForm : Form
    {
        private string soundsURL = "sounds/";

        /// <summary>
        /// Variable for user interface (string buttons)
        /// </summary>
        private Designer<Button> stringButtonDesigner;

        /// <summary>
        /// Variable for user interface (mute buttons)
        /// </summary>
        private Designer<Button> muteButtonDesigner;

        /// <summary>
        /// Variable for user interface (Chord buttons)
        /// </summary>
        private Designer<ChordButton> buttonDesigner;

        /// <summary>
        /// Currently used chord
        /// </summary>
        private Chord activeChord;

        public OptionsForm()
        {
            InitializeComponent();
                    TempInitializeChords();
            InitializeDesigners();

            activeChord = buttonChord1.chord;
            #region Scripts for user interface

            ShowChord();

            buttonDesigner.SetState(0, ButtonState.Chosen);
            #endregion
        }

        /// <summary>
        /// Initialize designers for UI
        /// </summary>
        private void InitializeDesigners()
        {
            Button[] stringButtons = new Button[120]
            {
                l1s1,l1s2,l1s3,l1s4,l1s5,l1s6,
                l2s1,l2s2,l2s3,l2s4,l2s5,l2s6,
                l3s1,l3s2,l3s3,l3s4,l3s5,l3s6,
                l4s1,l4s2,l4s3,l4s4,l4s5,l4s6,
                l5s1,l5s2,l5s3,l5s4,l5s5,l5s6,
                l6s1,l6s2,l6s3,l6s4,l6s5,l6s6,
                l7s1,l7s2,l7s3,l7s4,l7s5,l7s6,
                l8s1,l8s2,l8s3,l8s4,l8s5,l8s6,
                l9s1,l9s2,l9s3,l9s4,l9s5,l9s6,
                l10s1,l10s2,l10s3,l10s4,l10s5,l10s6,
                l11s1,l11s2,l11s3,l11s4,l11s5,l11s6,
                l12s1,l12s2,l12s3,l12s4,l12s5,l12s6,
                l13s1,l13s2,l13s3,l13s4,l13s5,l13s6,
                l14s1,l14s2,l14s3,l14s4,l14s5,l14s6,
                l15s1,l15s2,l15s3,l15s4,l15s5,l15s6,
                l16s1,l16s2,l16s3,l16s4,l16s5,l16s6,
                l17s1,l17s2,l17s3,l17s4,l17s5,l17s6,
                l18s1,l18s2,l18s3,l18s4,l18s5,l18s6,
                l19s1,l19s2,l19s3,l19s4,l19s5,l19s6,
                l20s1,l20s2,l20s3,l20s4,l20s5,l20s6,
            };
            stringButtonDesigner = new Designer<Button>(stringButtons, ColorMode.Back, Color.Cornsilk, Color.DarkRed, Color.Gray);

            Button[] muteButtons = new Button[6]
            {
                btnString1Mute,
                btnString2Mute,
                btnString3Mute,
                btnString4Mute,
                btnString5Mute,
                btnString6Mute,
            };
            muteButtonDesigner = new Designer<Button>(muteButtons, ColorMode.Back, Color.White, Color.DarkRed, Color.Gray);

            ChordButton[] chordButtons = new ChordButton[10]
            {
                buttonChord1,
                buttonChord2,
                buttonChord3,
                buttonChord4,
                buttonChord5,
                buttonChord6,
                buttonChord7,
                buttonChord8,
                buttonChord9,
                buttonChord10
            };
            buttonDesigner = new Designer<ChordButton>(chordButtons, ColorMode.Border);
        }

        public void TempInitializeChords()
        {
            buttonChord1.chord.guitarStrings[0].URL = "sounds/l0s1.wav";
            buttonChord1.chord.guitarStrings[1].URL = "sounds/l1s2.wav";
            buttonChord1.chord.guitarStrings[2].URL = "sounds/l2s3.wav";
            buttonChord1.chord.guitarStrings[3].URL = "sounds/l2s4.wav";
            buttonChord1.chord.guitarStrings[4].URL = "sounds/l0s5.wav";

            buttonChord2.chord.guitarStrings[0].URL = "sounds/l0s1.wav";
            buttonChord2.chord.guitarStrings[1].URL = "sounds/l0s2.wav";
            buttonChord2.chord.guitarStrings[2].URL = "sounds/l1s3.wav";
            buttonChord2.chord.guitarStrings[3].URL = "sounds/l2s4.wav";
            buttonChord2.chord.guitarStrings[4].URL = "sounds/l2s5.wav";
            buttonChord2.chord.guitarStrings[5].URL = "sounds/l0s6.wav";
        }

        /// <summary>
        /// Set new activeChord
        /// </summary>
        private void ChangeActiveChord(object sender, EventArgs e)
        {
            activeChord = ((ChordButton)sender).chord;

            #region Scripts for user interface

            ShowChord();

            buttonDesigner.MakeStandardAll();
            buttonDesigner.SetState(((ChordButton)sender).TabIndex, ButtonState.Chosen);
            #endregion
        }

        /// <summary>
        /// Show active string and muted buttons
        /// </summary>
        private void ShowChord()
        {
            muteButtonDesigner.MakeStandardAll();
            stringButtonDesigner.MakeStandardAll();
            for (int i = 0; i < activeChord.guitarStrings.Length; i++)
            {
                if (string.IsNullOrEmpty(activeChord.guitarStrings[i].URL)) //Find muted string
                    muteButtonDesigner.SetState(i, ButtonState.Muted);

                stringButtonDesigner.SetState(activeChord.guitarStrings[i].GetTag(), ButtonState.Chosen);
            }
        }

        private void ClickStringButton(object sender, EventArgs e)
        {
            Button stringButton = (Button)sender; //cast from object to button
            int numOfGuitarString = stringButton.Name[stringButton.Name.Length - 1] - '0'; //get number of string

            string currentURL = activeChord.guitarStrings[numOfGuitarString - 1].URL; //get current URL
            currentURL = currentURL.Substring(currentURL.LastIndexOf('\\') + 1); //delete useless info
            string newURL = stringButton.Name + ".wav"; //get new URL
            string baseURL = $"l0s{numOfGuitarString}" + ".wav"; //get standard URL

            if (currentURL != newURL) //Check state
                activeChord.guitarStrings[numOfGuitarString - 1].URL = soundsURL + newURL; //Set URL
            else
                activeChord.guitarStrings[numOfGuitarString - 1].URL = soundsURL + baseURL;


            #region Scripts for user interface
            int indexOfBtn = Convert.ToInt32(((Button)sender).Tag);

            stringButtonDesigner.SwitchBetweenStdand(indexOfBtn, ButtonState.Chosen);
            #endregion
        }
    }
}
