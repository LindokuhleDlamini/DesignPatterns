

using System;

namespace DesignPatterns.MediatorPattern
{
    public class Flight: IAirTrafficControlInstructions
    {
        private IAirTrafficControlMediator _airTrafficControlMediator;

        public Flight(IAirTrafficControlMediator airTrafficControlMediator)
        {
            _airTrafficControlMediator = airTrafficControlMediator;
        }

        public void Land()
        {
            if (_airTrafficControlMediator.IsRunwayAvailable())
            {
                Console.WriteLine("Flight is Landing");
                _airTrafficControlMediator.SetRunwayStatus(false);
            }
            else
            {
                Console.WriteLine("Flight waiting to Land");
            }
        }

        public void FlightReadyToLand()
        {
            Console.WriteLine("Flight is waiting for Runway availability");
        }
    }
}
