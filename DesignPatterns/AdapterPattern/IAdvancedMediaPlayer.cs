namespace DesignPatterns.AdapterPattern
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(string fileName);

        void PlayMp4(string fileName);
    }
}
