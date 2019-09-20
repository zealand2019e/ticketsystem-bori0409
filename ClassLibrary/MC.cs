using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class MC : Vehicle
    {
       
        /// <summary>
        ///  method Price(), overriden
        /// </summary>
        /// <returns> returns 125</returns>
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// VehicleType()
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        {
           return "MC";
        }
    }
}
