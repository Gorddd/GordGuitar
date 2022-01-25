using WMPLib;

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
        /// Stop sound
        /// </summary>
        public void Stop()
        {
            mediaPlayer.controls.stop();
        }

        /// <summary>
        /// Set source path
        /// </summary>
        public string URL
        {
            get { return mediaPlayer.URL; }
            set 
            { 
                mediaPlayer.URL = value;
                Stop();
            }
        }

        /// <summary>
        /// Media player to play the sound
        /// </summary>
        private WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
    }
}
