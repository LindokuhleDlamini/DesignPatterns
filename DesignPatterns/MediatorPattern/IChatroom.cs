using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern
{
    public interface IChatroom
    {
        void RegisterParticipant(Participant participant);

        void SendMessage(Participant participant, string message);
    }
}
