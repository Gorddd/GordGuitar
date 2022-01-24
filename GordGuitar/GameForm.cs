﻿using System;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class GameForm : Form
    {
        private OptionsForm optionsForm = new OptionsForm();

        /// <summary>
        /// Variable for user interface
        /// </summary>
        private Designer<ChordButton> buttonDesigner;

        /// <summary>
        /// Currently used chord
        /// </summary>
        private Chord activeChord;

        public GameForm()
        {
            InitializeComponent();
            InitializeChords();
            InitializeDesigner();

            activeChord = buttonChord1.chord;
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            optionsForm.ShowDialog();
        }

        /// <summary>
        /// Initialize buttonDesigner
        /// </summary>
        private void InitializeDesigner()
        {
            ChordButton[] buttons = new ChordButton[]
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

            buttonDesigner = new Designer<ChordButton>(buttons, ColorMode.Border);
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
            activeChord = ((ChordButton)sender).chord;

            #region Scripts for user interface
            buttonDesigner.MakeStandardAll();
            buttonDesigner.SetState(((ChordButton)sender).TabIndex, ButtonState.Chosen);
            #endregion
        }
    }
}
