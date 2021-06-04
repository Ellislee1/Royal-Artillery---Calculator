using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Artillery___Calculator
{
    class Result
    {
        public Result(int charge, float elevation, double flightTime)
        {
            this.charge = charge;
            this.elevation = elevation;
            this.flightTime = flightTime;
        }
        public int charge { get; set; }
        public float elevation { get; set; }
        public double flightTime { get; set; }
    }
}
