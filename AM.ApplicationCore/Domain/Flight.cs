using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime EffectivrArrival { get; set; }
        public float EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlighId { get; set; }

        public ICollection<Passenger> Passengers { get; set; }  

        public int PlaneFK { get; set; }
        public System.Numerics.Plane Plane { get; set; }

        public override string ToString()
        {
            return "Deparature :" + Departure + "Destination :" + Destination + "EffectiveArrival :" + EffectivrArrival +
                " EstimationDuration : " +EstimatedDuration+ "FlightDate : " +FlightDate;
        }

    }
}
