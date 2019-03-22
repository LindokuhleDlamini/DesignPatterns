using System;

namespace DesignPatterns.AdapterPattern
{
    class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter mediaAdapter;

        public void Play(string mediaType, string fileName)
        {
            if (mediaType.ToLower() == "mp3")
            {
                Console.WriteLine("Playing MP3 file " + fileName);
            }
            else if (mediaType.ToLower() == "mp4" || mediaType.ToLower() == "vlc")
            {
                mediaAdapter = new MediaAdapter();
                mediaAdapter.Play(mediaType, fileName);
            }
        }
    }
}
