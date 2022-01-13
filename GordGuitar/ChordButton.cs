using System.Windows.Forms;

namespace GordGuitar
{
    public class ChordButton : Button
    {
        public Chord chord { get; set; } = new Chord();
    }
}
