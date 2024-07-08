using Demo.Strategy.Routenplaner.Interfaces;
using Demo.Strategy.Routenplaner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Strategy.Routenplaner.Strategies
{
    public class BikeStrategy : IRoutingStrategy
    {
        public List<PointOnMapp> CalculateRoute(string from, string to)
        {
            char start = (from[0]);
            start++;
            char end = to[0];

            List<PointOnMapp> route = new List<PointOnMapp>();
            route.Add(new PointOnMapp { Address = from });

            for (char i = start; i < end; i++)
            {
                route.Add(new PointOnMapp { Address = $"Bike path {i}" });
            }

            route.Add(new PointOnMapp { Address = to });

            return route;
        }
    }
}
