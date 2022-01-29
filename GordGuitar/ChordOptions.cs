using System;
using System.Windows.Forms;

namespace GordGuitar
{
    public partial class ChordOptions : Form
    {
        private Chord initialChord;

        public Chord ResultChord { get; private set; }

        public ChordOptions(Chord chord)
        {
            InitializeComponent();

            initialChord = chord;
            ResultChord = chord;

            nameBox.Text = chord.Name;
        }

        /// <summary>
        /// Set initial values and close
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ResultChord = initialChord; //Set initial chord
            Close(); //close the form
        }

        /// <summary>
        /// Set new values and close
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text)) //Check empty string
            { 
                MessageBox.Show("Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (initialChord.Name != nameBox.Text && ChordSaver.isNameTaken(nameBox.Text)) //Check is name taken
            {
                MessageBox.Show("This name is alredy taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (initialChord.Name != nameBox.Text) //Check is it a new name
            {
                var chordSaver = new ChordSaver(ResultChord);
                chordSaver.ChangeName(nameBox.Text); //Save new name in the file

                ResultChord.Name = nameBox.Text; //Save new name in the memory
            }

            Close();
        }
    }
}
