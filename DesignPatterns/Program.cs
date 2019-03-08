using DesignPatterns.MediatorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MediatorPatternClient();
            Console.ReadLine();
        }

        public static void MediatorPatternClient()
        {
            var aTCMediator = new AirTrafficControlMediator();
            var flight93 = new Flight(aTCMediator);
            var runway = new Runway(aTCMediator);
            aTCMediator.SetFlight(flight93);
            aTCMediator.SetRunway(runway);
            flight93.FlightReadyToLand();
            runway.Land();
            flight93.Land();
        }
    }
}
