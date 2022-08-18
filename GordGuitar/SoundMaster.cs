using ManagedBass;

namespace GordGuitar
{
    public static class SoundMaster
    {
        /// <summary>
        /// Initializing the bass
        /// </summary>
        public static void Initialize() => Bass.Init();

        /// <summary>
        /// Stop playing the sounds
        /// </summary>
        public static void Mute()
        {
            Bass.Stop();
            Bass.Start();
        }
        
        /// <summary>
        /// Volume of the sounds
        /// </summary>
        public static int Volume
        {
            get => Bass.GlobalStreamVolume;
            set => Bass.GlobalStreamVolume = value;
        }
    }
}
