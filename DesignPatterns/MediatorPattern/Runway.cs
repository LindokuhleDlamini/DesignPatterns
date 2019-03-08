

using System;

namespace DesignPatterns.MediatorPattern
{
    public class Runway: IAirTrafficControlInstructions
    {
        private IAirTrafficControlMediator _airTrafficControlMediator;

        public Runway(IAirTrafficControlMediator airTrafficControlMediator)
        {
            _airTrafficControlMediator = airTrafficControlMediator;
        }

        public void Land()
        {
            Console.WriteLine("Runway is available");
            _airTrafficControlMediator.SetRunwayStatus(true);
        }
    }
}
