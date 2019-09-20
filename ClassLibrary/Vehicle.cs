using System;

namespace TicketLibrary
{
    public abstract class Vehicle
    {  
        /// <summary>
        /// Vehicle is th base class
        /// 
        /// </summary>

        private string _licens;
        /// <summary>
        /// we have property brobizz which is bool ( brobizz = true means 5% disscount )
        /// </summary>
        public bool brobizz = true;

        //properrties 
        /// <summary>
        /// Licenseplate is the prop fot the GegNumber
        /// </summary>
        public string Licenseplate
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
        /// <summary>
        /// 2 abstract methods Price and VehicleType that are overriden in the spec class
        /// </summary>
        /// <returns></returns>
        public abstract double Price();


        abstract public string VehicleType();

       


    }
}
