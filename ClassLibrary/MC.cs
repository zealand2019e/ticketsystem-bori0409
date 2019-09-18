using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class MC : Vehicle
    {
       
        public override double Price()
        {
            return 125;
        }

        public override string VehicleType()
        {
           return "MC";
        }
    }
}
