using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class Car : Vehicle
    {
       
        /// <summary>
        /// the method Price() 
        /// </summary>
        /// <returns> if the brobizz is true it returns "228" or brobiz false "240"</returns>
        public override double Price()
        {
            if (brobizz)
            { return 240 * 0.95; }
            else
            {
                return 240;
            }
        }
        /// <summary>
        ///VechicleType is overriden here
        /// </summary>
        /// <returns> "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
        
    }
}
