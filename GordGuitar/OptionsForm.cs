using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class OptionsForm : Form
    {
        private string soundsURL = "sounds/";

        /// <summary>
        /// Array of chordbuttons
        /// </summary>
        private ChordButton[] chordButtons;

        private ChordOptions chordOptionsForm;

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
            InitializeArrays();
            ReadChordsFromFile();
            InitializeDesigners();

            activeChord = buttonChord1.chord;
            #region Scripts for user interface
            currentChordName.Text = activeChord.Name;

            ShowChord();

            buttonDesigner.SetState(0, ButtonState.Chosen);
            #endregion
        }

        /// <summary>
        /// Initialize arrays (chordButtons)
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

            
            buttonDesigner = new Designer<ChordButton>(chordButtons, ColorMode.Border);
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
        /// Read saved chords from file
        /// </summary>
        private void ReadChordsFromFile()
        {
            try
            {
                var streamReader = new StreamReader("data\\ChordBase.txt");

                for (int i = 0; i < chordButtons.Length; i++)
                {
                    string str = streamReader.ReadLine();

                    if (string.IsNullOrEmpty(str))
                        break;

                    chordButtons[i].chord.Name = str; //get chord name
 
                    while((str = streamReader.ReadLine()) != ";")
                    { //get URL
                        chordButtons[i].chord.guitarStrings[str[0] - '0'].URL = soundsURL + str.Substring(str.IndexOf('l'));
                    }
                }

                streamReader.Close();
            }
            catch
            {   //Create new File if it is missing
                var streamWriter = new StreamWriter("data\\ChordBase.txt");
                streamWriter.Close();
            }
        }

        /// <summary>
        /// Set new activeChord
        /// </summary>
        private void ChangeActiveChord(object sender, EventArgs e)
        {
            activeChord = ((ChordButton)sender).chord;

            #region Scripts for user interface

            ShowChord();

            currentChordName.Text = activeChord.Name;

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

        /// <summary>
        /// Set guitar string sound
        /// </summary>
        private void ClickStringButton(object sender, EventArgs e)
        {
            #region Scripts for user interface
            Button stringButtonUI = (Button)sender; //cast from object to button

            int indexOfBtn = Convert.ToInt32(stringButtonUI.Tag);
            stringButtonDesigner.SwitchBetweenStdand(indexOfBtn, ButtonState.Chosen);

            int numOfGuitarStringUI = stringButtonUI.Name[stringButtonUI.Name.Length - 1] - '0'; //get number of prev string
            stringButtonDesigner.SetState(activeChord.guitarStrings[numOfGuitarStringUI - 1].GetTag(), ButtonState.Standart); //Erase prev string button on this string

            muteButtonDesigner.SetState(numOfGuitarStringUI - 1, ButtonState.Standart); // Erase mute button
            #endregion

            Button stringButton = (Button)sender; //cast from object to button
            int numOfGuitarString = stringButton.Name[stringButton.Name.Length - 1] - '0'; //get number of string

            string currentURL = activeChord.guitarStrings[numOfGuitarString - 1].URL; //get current URL
            currentURL = currentURL.Substring(currentURL.LastIndexOf('\\') + 1); //delete useless info
            string newURL = stringButton.Name + ".wav"; //get new URL
            string baseURL = $"l0s{numOfGuitarString}" + ".wav"; //get URL of opened string

            if (currentURL != newURL) //Check state
                activeChord.guitarStrings[numOfGuitarString - 1].URL = soundsURL + newURL; //Set new sound
            else
                activeChord.guitarStrings[numOfGuitarString - 1].URL = soundsURL + baseURL; //Set sound of opened string
        }

        /// <summary>
        /// Mute or unmute guitar string
        /// </summary>
        private void ClickMuteButton(object sender, EventArgs e)
        {
            #region Scripts for user interface
            Button muteButtonUI = (Button)sender; //cast from object to button

            int indexOfBtn = Convert.ToInt32(muteButtonUI.Tag);
            muteButtonDesigner.SwitchBetweenStdand(indexOfBtn, ButtonState.Muted);

            int indexOfGuitarStringUI = Convert.ToInt32(muteButtonUI.Tag); //Get number of prev string
            stringButtonDesigner.SetState(activeChord.guitarStrings[indexOfGuitarStringUI].GetTag(), ButtonState.Standart); //Erase prev string button on this string
            #endregion


            Button muteButton = (Button)sender; //cast from object to button
            int indexOfGuitarString = Convert.ToInt32(muteButton.Tag); //get number of string

            string currentURL = activeChord.guitarStrings[indexOfGuitarString].URL; //get current URL
            string baseURL = $"l0s{indexOfGuitarString + 1}" + ".wav"; //get URL of opened string

            if (!string.IsNullOrEmpty(currentURL)) //Check state
                activeChord.guitarStrings[indexOfGuitarString].URL = string.Empty; //Set empty to URL
            else
                activeChord.guitarStrings[indexOfGuitarString].URL = soundsURL + baseURL; //Set URL of opened string
        }

        /// <summary>
        /// Call chord options
        /// </summary>
        private void ClickOptButton(object sender, EventArgs e)
        {
            int indexOfChordButton = Convert.ToInt32(((Button)sender).Tag);
            Chord chordToSetting = chordButtons[indexOfChordButton].chord; //Get chord to setting

            bool flag = false;
            if (chordToSetting.Name == activeChord.Name)
                flag = true;

            chordOptionsForm = new ChordOptions(chordToSetting, soundsURL); //Create form
            chordOptionsForm.ShowDialog(); //Show form

            chordButtons[indexOfChordButton].chord = chordOptionsForm.ResultChord; //Set new chord

            chordButtons[indexOfChordButton].Text = chordOptionsForm.ResultChord.Name; //Write name on the button

            if (flag)
            {
                activeChord = chordOptionsForm.ResultChord;
                currentChordName.Text = activeChord.Name;
                ShowChord();
            }
        }

        private void OptionsForm_Shown(object sender, EventArgs e)
        {
            ShowChordNames();
        }

        /// <summary>
        /// Delete current chord from file and clear chord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteChordButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this chord?", "Delete current chord",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.No)
                return;

            for (int i = 0; i < activeChord.guitarStrings.Length; i++) //Do all strings muted
            {
                activeChord.guitarStrings[i].URL = string.Empty;
            }

            var chordSaver = new ChordSaver(activeChord);
            chordSaver.Delete(); //Delete the chord from the file

            activeChord.Name = string.Empty;
            ShowChordNames();

            #region Scripts for user interface
            stringButtonDesigner.MakeStandardAll();

            for (int i = 0; i < 6; i++) //Set muted state
            {
                muteButtonDesigner.SetState(i, ButtonState.Muted);
            }
            #endregion
        }

        /// <summary>
        /// Clear current chord (Erase)
        /// </summary>
        private void clearChordButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < activeChord.guitarStrings.Length; i++) //Do all strings opened
            {
                activeChord.guitarStrings[i].URL = soundsURL + $"l0s{i + 1}.wav";
            }

            #region Scripts for user interface
            stringButtonDesigner.MakeStandardAll();
            muteButtonDesigner.MakeStandardAll();
            #endregion
        }

        /// <summary>
        /// Save current chord to the file
        /// </summary>
        private void saveChordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(activeChord.Name)) //Check empty
            {
                MessageBox.Show("You can't save the chord without name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var chordSaver = new ChordSaver(activeChord);
            chordSaver.Save();

            MessageBox.Show("The chord has been saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Create new chord and choose the name
        /// </summary>
        private void newChordButton_Click(object sender, EventArgs e)
        {
            NewChordForm newChordForm = new NewChordForm(new Chord());
            newChordForm.ShowDialog();

            if (string.IsNullOrEmpty(newChordForm.ResultChord.Name)) //User pressed cancel
            {
                ChangeActiveChord(buttonChord1, null);
                return;
            }


            activeChord = newChordForm.ResultChord;

            for (int i = 0; i < activeChord.guitarStrings.Length; i++) //Do all strings opened
            {
                activeChord.guitarStrings[i].URL = soundsURL + $"l0s{i + 1}.wav";
            }

            ShowChord();

            #region Scripts for user interface
            currentChordName.Text = activeChord.Name;

            buttonDesigner.MakeStandardAll();
            #endregion
        }

        private void frontBackButton_MouseLeave(object sender, EventArgs e)
        {
            frontBackButton.Visible = false;
        }

        private void backBackButton_MouseEnter(object sender, EventArgs e)
        {
            frontBackButton.Visible = true;
        }

        private void frontBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frontSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            frontSettingsButton.Visible = false;
        }

        private void backSettingsButton_MouseEnter(object sender, EventArgs e)
        {
            frontSettingsButton.Visible = true;
        }
    }
}
