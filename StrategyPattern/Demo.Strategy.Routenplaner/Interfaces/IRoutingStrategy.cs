using Demo.Strategy.Routenplaner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Strategy.Routenplaner.Interfaces
{
    public interface IRoutingStrategy
    {
        List<PointOnMapp> CalculateRoute(string from, string to);
    }
}
