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
    public partial class NewChordForm : Form
    {
        private Chord initialChord;

        public Chord ResultChord { get; private set; }

        public NewChordForm(Chord chord)
        {
            InitializeComponent();

            initialChord = chord;
            ResultChord = chord;
        }


        private void applyButton_Click(object sender, EventArgs e)
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
                ResultChord.Name = nameBox.Text; //Save new name in the memory
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ResultChord = initialChord;
            Close();
        }
    }
}
