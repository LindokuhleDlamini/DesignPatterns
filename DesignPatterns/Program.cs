using DesignPatterns.AdapterPattern;
using DesignPatterns.MediatorPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterPatternClient();
            Console.ReadLine();
        }

        public static void MediatorPatternClient()
        {
            var chatRoomOne = new Chatroom();
            var participantOne = new Participant(chatRoomOne, "Lindo");
            var participantTwo = new Participant(chatRoomOne, "John");
            var participantThree = new Participant(chatRoomOne, "Jane");
            var participantFour = new Participant(chatRoomOne, "Okuhle");

            chatRoomOne.RegisterParticipant(participantOne);
            chatRoomOne.RegisterParticipant(participantTwo);
            chatRoomOne.RegisterParticipant(participantThree);

            participantOne.SendMessage("what's up");

            chatRoomOne.RemoveParticipant(participantThree);

            participantTwo.SendMessage("Hey Dudes");

            chatRoomOne.RegisterParticipant(participantFour);

            participantFour.SendMessage("what Did I miss?");
        }

        public static void AdapterPatternClient()
        {
            var audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3", "Sicko Mode - La Flame");
            audioPlayer.Play("mp4", "Rick and Morty");
            audioPlayer.Play("VLC", "National Geo");
        }
    }
}
