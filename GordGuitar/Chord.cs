namespace GordGuitar
{
    class Chord
    {
        public Chord()
        {
            for (int i = 0; i < guitarStrings.Length; i++)
            {
                guitarStrings[i] = new GuitarString();
            }
        }

        /// <summary>
        /// 6 strings of the chord
        /// </summary>
        public GuitarString[] guitarStrings { get; set; } = new GuitarString[6];
    }
}
