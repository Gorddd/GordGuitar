﻿namespace GordGuitar
{
    public class Chord
    {
        public Chord()
        {
            for (int i = 0; i < guitarStrings.Length; i++)
            {
                guitarStrings[i] = new GuitarString();
            }
        }

        /// <summary>
        /// Chord name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 6 strings of the chord
        /// </summary>
        public GuitarString[] guitarStrings { get; private set; } = new GuitarString[6];
    }
}
