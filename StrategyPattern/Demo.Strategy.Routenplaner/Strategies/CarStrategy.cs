using Demo.Strategy.Routenplaner.Interfaces;
using Demo.Strategy.Routenplaner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Strategy.Routenplaner.Strategies
{
    public class CarStrategy : IRoutingStrategy
    {
        public List<PointOnMapp> CalculateRoute(string from, string to)
        {
            List<PointOnMapp> route = new List<PointOnMapp>();
            route.Add(new PointOnMapp { Address = from });
            route.Add(new PointOnMapp { Address = $"Highway A1 {from}" });
            route.Add(new PointOnMapp { Address = $"Highway A1 exit {to}" });
            route.Add(new PointOnMapp { Address = to });

            return route;

        }
    }
}
