using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern
{
    public interface IAirTrafficControlMediator
    {
        void SetFlight(Flight flight);

        void SetRunway(Runway runway);

        void SetRunwayStatus(bool runwayStatus);

        bool IsRunwayAvailable();
    }
}
