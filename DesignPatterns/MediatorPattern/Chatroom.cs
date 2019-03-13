using System;
using System.Collections.Generic;

namespace DesignPatterns.MediatorPattern
{
    public class Chatroom : IChatroom
    {
        private IList<Participant> participants = new List<Participant>();

        public void RegisterParticipant(Participant participant)
        {
            participants.Add(participant);
            Console.WriteLine(participant._userName + " has joined the group");
        }

        public void RemoveParticipant(Participant participant)
        {
            participants.Remove(participant);
            Console.WriteLine(participant._userName + " has Left the group");
        }

        public void SendMessage(Participant participant, string message)
        {
            foreach (var reciever in participants)
            {
                if (participant._userName != reciever._userName)
                {
                    reciever.RecieveMessage(message);
                }
            }
        }
    }
}
