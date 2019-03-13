using System;

namespace DesignPatterns.MediatorPattern
{
    public class Participant
    {
        private IChatroom _chatroom;
        public string _userName;

        public Participant(IChatroom chatroom, string userName)
        {
            _chatroom = chatroom;
            _userName = userName;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(_userName + " sent message: " + message);
            _chatroom.SendMessage(this, message);
        }

        public void RecieveMessage(string message)
        {
            Console.WriteLine(_userName+" recieved message: "+ message);
        }
    }
}
