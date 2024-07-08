using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Strategy.Routenplaner.Models
{
    public class PointOnMapp
    {
        public Geolocation.Coordinate Coordinate { get; set; }

        public string Address { get; set; } = "";

        public override string ToString()
        {
            return $"Address: {Address}";
        }

    }
}
