using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Artillery___Calculator
{
    class Result
    {
        public Result(String gun, int charge, float elevation, double flightTime)
        {
            this.gun = gun;
            this.charge = charge;
            this.elevation = elevation;
            this.flightTime = flightTime;
        }
        public int charge { get; set; }
        public float elevation { get; set; }
        public double flightTime { get; set; }
        public String gun { get; set; }
    }
}
