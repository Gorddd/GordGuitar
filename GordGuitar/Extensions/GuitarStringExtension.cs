using System;

namespace GordGuitar
{
    public static class GuitarStringExtension
    {
        public static int GetTag(this GuitarString guitarString)
        {
            if (string.IsNullOrEmpty(guitarString.URL)) //guitar string is muted
                return -1;

            string URL = guitarString.URL.Substring(guitarString.URL.LastIndexOf('/') + 1); //Delete symbols '\'

            int fret = Convert.ToInt32(URL.Substring(1, URL.IndexOf('s') - 1)); //get fret
            if (fret == 0) //Open guitar string
                return -1;

            int stringNumber = URL[URL.IndexOf('s') + 1] - '0'; //get number of string

            return 6 * (fret - 1) + stringNumber - 1; //Tag (index)
        }
    }
}
