using System;

namespace DesignPatterns.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing VLC file " + fileName);
        }
    }
}
