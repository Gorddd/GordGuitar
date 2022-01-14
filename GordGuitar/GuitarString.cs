﻿using WMPLib;

namespace GordGuitar
{
    public class GuitarString
    {
        /// <summary>
        /// Play sound
        /// </summary>
        public void Play()
        {
            mediaPlayer.controls.stop();
            mediaPlayer.controls.play();
        }

        /// <summary>
        /// Set source path
        /// </summary>
        public string URL
        {
            set { mediaPlayer.URL = value; }
        }

        /// <summary>
        /// Media player to play the sound
        /// </summary>
        private WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
    }
}
