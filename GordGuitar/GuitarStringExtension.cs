using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GordGuitar
{
    public static class GuitarStringExtension
    {
        public static int GetTag(this GuitarString guitarString)
        {
            if (string.IsNullOrEmpty(guitarString.URL)) //guitar string is muted
                return -1;

            int fret = Convert.ToInt32(guitarString.URL.Substring(0, guitarString.URL.IndexOf('l')));
            if (fret == 0) //Open guitar string
                return -1;

            int stringNumber = Convert.ToInt32(guitarString.URL.Substring(guitarString.URL.IndexOf('l') + 1, 1));

            return 6 * (fret - 1) + stringNumber - 1; //Tag (index)
            
        }
    }
}
