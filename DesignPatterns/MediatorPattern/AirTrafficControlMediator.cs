using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern
{
    public class AirTrafficControlMediator : IAirTrafficControlMediator
    {
        private Flight _flight;
        private Runway _runway;
        private bool _runwayStatus;

        public bool IsRunwayAvailable()
        {
            return _runwayStatus;
        }

        public void SetFlight(Flight flight)
        {
            _flight = flight;
        }

        public void SetRunwayStatus(bool runwayStatus)
        {
            _runwayStatus = runwayStatus;
        }

        public void SetRunway(Runway runway)
        {
            _runway = runway;
        }
    }
}
