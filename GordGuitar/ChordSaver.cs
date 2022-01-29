using System.IO;

namespace GordGuitar
{
    public class ChordSaver
    {
        private string folderURL;
        private string tempFolderURL;
        private string URL;
        private Chord chord;
        public ChordSaver(Chord chord, string URL = "ChordBase.txt", string folderURL = "data\\", string tempFolderURL = "temp\\")
        {
            this.chord = chord;
            this.URL = URL;
            this.folderURL = folderURL;
            this.tempFolderURL = tempFolderURL;
        }

        private void MoveFile()
        {
            var oldFileInfo = new FileInfo(folderURL + URL);
            oldFileInfo.Delete();

            var newFileInfo = new FileInfo(tempFolderURL + URL);
            newFileInfo.MoveTo(folderURL + URL);
        }

        /// <summary>
        /// Set new name to the chord in file
        /// </summary>
        /// <param name="newName">new name</param>
        public void ChangeName(string newName)
        {
            var streamReader = new StreamReader(folderURL + URL);
            var streamWriter = new StreamWriter(tempFolderURL + URL);

            string str;
            while (!string.IsNullOrEmpty(str = streamReader.ReadLine()))
            {
                if (str == chord.Name)
                    streamWriter.WriteLine(newName);
                else
                    streamWriter.WriteLine(str);
            }

            streamWriter.Close();
            streamReader.Close();

            MoveFile();
        }

        /// <summary>
        /// Delete the chord from the file
        /// </summary>
        public void Delete()
        {
            var streamReader = new StreamReader(folderURL + URL);
            var streamWriter = new StreamWriter(tempFolderURL + URL);

            string str;
            while (!string.IsNullOrEmpty(str = streamReader.ReadLine()))
            {
                if (str == chord.Name)
                {
                    while ((str = streamReader.ReadLine()) != ";")
                        ;
                }
                else
                    streamWriter.WriteLine(str);
            }

            streamWriter.Close();
            streamReader.Close();

            MoveFile();
        }

        /// <summary>
        /// Save the chord to the file
        /// </summary>
        public void Save()
        {
            Delete();

            var streamWriter = new StreamWriter(folderURL + URL, append: true);
            streamWriter.WriteLine(chord.Name);

            for (int i = 0; i < chord.guitarStrings.Length; i++)
            {
                if (!string.IsNullOrEmpty(chord.guitarStrings[i].URL))
                {
                    string stringURL = chord.guitarStrings[i].URL;
                    stringURL = stringURL.Substring(stringURL.LastIndexOf('\\') + 1);

                    streamWriter.WriteLine($"{i} = {stringURL}");
                }
            }
            streamWriter.WriteLine(";");

            streamWriter.Close();
        }

        /// <summary>
        /// Get chord from the file
        /// </summary>
        /// <param name="chordName">searched chord name</param>
        /// <returns></returns>
        public static Chord GetChordFromFile(string chordName, string soundsURL, string URL = "ChordBase.txt", string folderURL = "data\\")
        {
            Chord chord = new Chord() { Name = chordName };

            var streamReader = new StreamReader(folderURL + URL);

            string str;
            while ((str = streamReader.ReadLine()) != chordName && !string.IsNullOrEmpty(str)) ; //Find chord in the file

            if (string.IsNullOrEmpty(str)) //The chord wasn't found
                return chord;

            while ((str = streamReader.ReadLine()) != ";")
            {
                chord.guitarStrings[str[0] - '0'].URL = soundsURL + str.Substring(str.IndexOf('l'));
            }

            streamReader.Close();

            return chord;
        }

        /// <summary>
        /// Check is name taken
        /// </summary>
        /// <param name="chordName">name of the chord</param>
        /// <returns></returns>
        public static bool isNameTaken(string chordName, string URL = "ChordBase.txt", string folderURL = "data\\")
        {
            var streamReader = new StreamReader(folderURL + URL);

            string str;
            while(!string.IsNullOrEmpty(str = streamReader.ReadLine()))
            {
                if (str == chordName)
                {
                    streamReader.Close();
                    return true;
                }
            }

            streamReader.Close();
            return false;
        }
    }
}
