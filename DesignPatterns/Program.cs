using DesignPatterns.AdapterPattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.MediatorPattern;
using DesignPatterns.ObserverPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPatternClient();
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

        public static void ObserverPatternClient()
        {
            ISubject subject = new Subject();

            IObserver octal = new OctalObserver(subject);
            IObserver hexa = new HexaObserver(subject);
            IObserver binary = new BinaryObserver(subject);

            Console.WriteLine("State chage, value: 15");
            subject.SetState(15);
            Console.WriteLine("State chage, value: 10");
            subject.SetState(10);
        }

        public static void CommandPatternClient()
        {
            Stock nikeStock = new Stock("Nike inc", 50000);
            Stock dellStock = new Stock("Dell", 10983);

            IOrder nikeBuyOrder = new BuyStock(nikeStock);
            IOrder dellSellOrder = new SellStock(dellStock);
            IOrder dellBuyOrder = new BuyStock(dellStock);

            Broker broker = new Broker();

            broker.TakeOrder(nikeBuyOrder);
            broker.TakeOrder(dellBuyOrder);
            broker.PlaceOrders();

            broker.TakeOrder(dellSellOrder);
            broker.PlaceOrders();
        }
    }
}
