using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class Car : Vehicle
    {
       

        public override double Price()
        {
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
        
    }
}
