using Demo.Strategy.Routenplaner;
using Demo.Strategy.Routenplaner.Strategies;

namespace Demo.StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Strategy Pattern - Navigation");

            Console.WriteLine("Route by car");
            RoutePlaning routePlaning = new RoutePlaning(new CarStrategy());
            var routingPoints = routePlaning.CalculateRoute("A", "K");
            foreach (var point in routingPoints)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("");
            Console.WriteLine("Route by bike");
            routePlaning.SetRoutingStrategy(new BikeStrategy());
            routingPoints = routePlaning.CalculateRoute("A", "K");
            foreach (var point in routingPoints)
            {
                Console.WriteLine(point);
            }

        }
    }
}
