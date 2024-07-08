using Demo.Strategy.Routenplaner.Interfaces;
using Demo.Strategy.Routenplaner.Models;

namespace Demo.Strategy.Routenplaner
{
    /// <summary>
    /// Context of the strategy pattern.
    /// </summary>
    public class RoutePlaning
    {
        private IRoutingStrategy routingStrategy;

        public RoutePlaning(IRoutingStrategy routingStrategy)
        {
            this.routingStrategy = routingStrategy;
        }

        public void SetRoutingStrategy(IRoutingStrategy routingStrategy)
        {
            this.routingStrategy = routingStrategy;
        }

        public List<PointOnMapp> CalculateRoute(string from, string to)
        {
            return routingStrategy.CalculateRoute(from, to);
        }
    }
}
