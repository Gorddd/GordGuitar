using System;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class GameForm : Form
    {
        private OptionsForm optionsForm = new OptionsForm();

        /// <summary>
        /// Array of chordbuttons
        /// </summary>
        private ChordButton[] chordButtons;

        /// <summary>
        /// Variable for user interface
        /// </summary>
        private Designer<ChordButton> buttonDesigner;

        /// <summary>
        /// Currently used chord
        /// </summary>
        private Chord activeChord;

        /// <summary>
        /// recently used chord
        /// </summary>
        private Chord previousChord = new Chord();

        public GameForm()
        {
            InitializeComponent();
            InitializeChords();
            InitializeArrays();
            InitializeDesigner();

            activeChord = buttonChord1.chord;
            #region Scripts for user interface
            buttonDesigner.SetState(0, ButtonState.Chosen);
            #endregion
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            optionsForm.ShowDialog();

            InitializeChords();
            ShowChordNames();
        }

        /// <summary>
        /// Initialize arrays (chordbuttons)
        /// </summary>
        private void InitializeArrays()
        {
            chordButtons = new ChordButton[10]
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
        }

        /// <summary>
        /// Write chord names on chordbuttons
        /// </summary>
        private void ShowChordNames()
        {
            for (int i = 0; i < chordButtons.Length; i++)
            {
                chordButtons[i].ShowChordName();
            }
        }

        /// <summary>
        /// Initialize buttonDesigner
        /// </summary>
        private void InitializeDesigner()
        {
            buttonDesigner = new Designer<ChordButton>(chordButtons, ColorMode.Border);
        }

        /// <summary>
        /// Get chords from optionsForm
        /// </summary>
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

        /// <summary>
        /// Play the sound of the string
        /// </summary>
        private void PullGuitarString(object sender, EventArgs e)
        {
            int numOfString = Convert.ToInt32(((Button)sender).Tag) - 1; //Get the number of calling string

            activeChord.guitarStrings[numOfString].Play(); //Play the sound
        }

        /// <summary>
        /// Set new activeChord
        /// </summary>
        private void ChangeActiveChord(object sender, EventArgs e)
        {
            previousChord = activeChord;

            activeChord = ((ChordButton)sender).chord;

            #region Scripts for user interface
            buttonDesigner.MakeStandardAll();
            buttonDesigner.SetState(((ChordButton)sender).TabIndex, ButtonState.Chosen);
            #endregion
        }

        private void GameForm_Shown(object sender, EventArgs e)
        {
            ShowChordNames();
        }

        /// <summary>
        /// hot keys
        /// </summary>
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.D1:
                    buttonChord1.PerformClick();
                    break;
                case (char)Keys.D2:
                    buttonChord2.PerformClick();
                    break;
                case (char)Keys.D3:
                    buttonChord3.PerformClick();
                    break;
                case (char)Keys.D4:
                    buttonChord4.PerformClick();
                    break;
                case (char)Keys.D5:
                    buttonChord5.PerformClick();
                    break;
                case (char)Keys.D6:
                    buttonChord6.PerformClick();
                    break;
                case (char)Keys.D7:
                    buttonChord7.PerformClick();
                    break;
                case (char)Keys.D8:
                    buttonChord8.PerformClick();
                    break;
                case (char)Keys.D9:
                    buttonChord9.PerformClick();
                    break;
                case (char)Keys.D0:
                    buttonChord10.PerformClick();
                    break;
                default:
                    break;
            }
        }
        
        /// <summary>
        /// mute all guitar strings
        /// </summary>
        private void MuteAllStrings(object sender, EventArgs e)
        {
            foreach(var item in previousChord.guitarStrings)
            {
                item.Stop();
            }

            foreach(var item in activeChord.guitarStrings)
            {
                item.Stop();
            }
        }
    }
}
