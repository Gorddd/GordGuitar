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
            if (!string.IsNullOrEmpty(nameBox.Text))
            {
                ResultChord.Name = nameBox.Text; //Set new chord name
                Close(); //close the form
            }
            else
                MessageBox.Show("Name can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //++++ добавь проверку на повтор имен, те что в файле
        }
    }
}
