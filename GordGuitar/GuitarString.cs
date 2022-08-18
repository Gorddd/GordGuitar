using ManagedBass;

namespace GordGuitar
{
    public class GuitarString
    {

        /// <summary>
        /// Initializing when first used
        /// </summary>
        static GuitarString() => Bass.Init();

        /// <summary>
        /// Play sound
        /// </summary>
        public void Play() => Bass.ChannelPlay(stream, true);

        /// <summary>
        /// Stop sound
        /// </summary>
        public void Stop() => Bass.ChannelStop(stream);

        /// <summary>
        /// Source name
        /// </summary>
        private string url;

        /// <summary>
        /// Stream to play
        /// </summary>
        private int stream;

        /// <summary>
        /// Set source path
        /// </summary>
        public string URL
        {
            get => url;
            set 
            {
                url = value;

                Bass.StreamFree(stream); //clean previous stream

                stream = Bass.CreateStream(value);
            }
        }
    }
}
