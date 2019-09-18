using System;

namespace TicketLibrary
{
    public abstract class Vehicle
    {

        private string _licens;

        //properrties 
         public  string Licenseplate
        {
            get => _licens;
            set
            {
                if (value.Length > 7)
                {
                    throw new Exception("Too long");
                }
                else
                {
                    _licens = value;
                }

            }
        }
        public DateTime Date
        {
            get; set;
        }

        //methods
        public abstract double Price();


        abstract public string VehicleType();

       


    }
}
