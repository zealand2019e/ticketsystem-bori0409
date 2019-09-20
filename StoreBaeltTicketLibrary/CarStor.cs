using System;
using TicketLibrary;

namespace StoreBaeltTicketLibrary
{
    public class CarStor :Car
    {
        public bool IsWeekend;
        //  Car newcar = new Car();

        
        public double calprice;

        public override double Price()

        {
            if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)
            {
                return (240 * 0.80)*0.95;
                
            }
            if (brobizz)
            { return 240 * 0.95; }
            else
            {
                return 240;
            }
        }






    }
}
