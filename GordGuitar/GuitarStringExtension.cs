using System;

namespace GordGuitar
{
    public static class GuitarStringExtension
    {
        public static int GetTag(this GuitarString guitarString)
        {
            if (string.IsNullOrEmpty(guitarString.URL)) //guitar string is muted
                return -1;

            string URL = guitarString.URL.Substring(guitarString.URL.LastIndexOf('\\') + 1); //Delete symbols '\'

            int fret = Convert.ToInt32(URL.Substring(0, URL.IndexOf('l')));
            if (fret == 0) //Open guitar string
                return -1;

            int stringNumber = Convert.ToInt32(URL.Substring(URL.IndexOf('l') + 1, 1));

            return 6 * (fret - 1) + stringNumber - 1; //Tag (index)
            
        }
    }
}
