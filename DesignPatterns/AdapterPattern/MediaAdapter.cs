namespace DesignPatterns.AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer _advancedMediaPlayer;

        public void Play(string mediaType, string fileName)
        {
            if (mediaType.ToLower() == "vlc")
            {
                _advancedMediaPlayer = new VlcPlayer();
                _advancedMediaPlayer.PlayVlc(fileName);
            }
            else if (mediaType.ToLower() == "mp4")
            {
                _advancedMediaPlayer = new Mp4Player();
                _advancedMediaPlayer.PlayMp4(fileName);
            }
        }
    }
}
