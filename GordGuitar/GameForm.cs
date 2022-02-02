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
                case (char)Keys.F1:
                    activeChord.guitarStrings[0].Stop();
                    previousChord.guitarStrings[0].Stop();
                    break;
                case (char)Keys.F2:
                    activeChord.guitarStrings[1].Stop();
                    previousChord.guitarStrings[1].Stop();
                    break;
                case (char)Keys.F3:
                    activeChord.guitarStrings[2].Stop();
                    previousChord.guitarStrings[2].Stop();
                    break;
                case (char)Keys.F4:
                    activeChord.guitarStrings[3].Stop();
                    previousChord.guitarStrings[3].Stop();
                    break;
                case (char)Keys.F5:
                    activeChord.guitarStrings[4].Stop();
                    previousChord.guitarStrings[4].Stop();
                    break;
                case (char)Keys.F6:
                    activeChord.guitarStrings[5].Stop();
                    previousChord.guitarStrings[5].Stop();
                    break;
                case (char)Keys.Q:
                    activeChord.guitarStrings[0].Play();
                    Cursor.Position = new System.Drawing.Point(Location.X + 267, Location.Y + buttonString0.Location.Y + 35);
                    break;
                case (char)Keys.W:
                    activeChord.guitarStrings[1].Play();
                    Cursor.Position = new System.Drawing.Point(Location.X + 267, Location.Y + buttonString1.Location.Y + 35);
                    break;
                case (char)Keys.E:
                    activeChord.guitarStrings[2].Play();
                    Cursor.Position = new System.Drawing.Point(Location.X + 267, Location.Y + buttonString2.Location.Y + 35);
                    break;
                case (char)Keys.R:
                    activeChord.guitarStrings[3].Play();
                    Cursor.Position = new System.Drawing.Point(Location.X + 267, Location.Y + buttonString3.Location.Y + 35);
                    break;
                case (char)Keys.T:
                    activeChord.guitarStrings[4].Play();
                    Cursor.Position = new System.Drawing.Point(Location.X + 267, Location.Y + buttonString4.Location.Y + 35);
                    break;
                case (char)Keys.Y:
                    activeChord.guitarStrings[5].Play();
                    Cursor.Position = new System.Drawing.Point(Location.X + 267, Location.Y + buttonString5.Location.Y + 35);
                    break;
                default:
                    break;
            }
        }
        
        /// <summary>
        /// mute all guitar strings
        /// </summary>
        private void MuteAllStrings()
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

        #region UI buttons

        private void frontOptionsButton_MouseLeave(object sender, EventArgs e)
        {
            frontOptionsButton.Visible = false;
        }

        private void backOptionsButton_MouseEnter(object sender, EventArgs e)
        {
            frontOptionsButton.Visible = true;
        }

        private void backMuteButton_MouseEnter(object sender, EventArgs e)
        {
            MuteAllStrings();

            frontMuteButton.Visible = true;
        }

        private void frontMuteButton_MouseLeave(object sender, EventArgs e)
        {
            frontMuteButton.Visible = false;
        }

        private void frontHelpButton_MouseLeave(object sender, EventArgs e)
        {
            frontHelpButton.Visible = false;
        }

        private void backHelpButton_MouseEnter(object sender, EventArgs e)
        {
            frontHelpButton.Visible = true;
        }

        private void frontHelpButton_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        #endregion
    }
}
