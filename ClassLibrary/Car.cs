using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class Car : Vehicle
    {
       

        public override double Price()
        {
            if (brobizz)
            { return 240 * 0.95; }
            else
            {
                return 240;
            }
        }

        public override string VehicleType()
        {
            return "Car";
        }
        
    }
}
