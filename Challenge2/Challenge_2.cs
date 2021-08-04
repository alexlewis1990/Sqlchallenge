using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class Challenge_2
    {
        public Guid Technicianid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal CustomerRating { get; set; }

        public Guid Vehicleidfk { get; set; }


    }
    public class ChallengeCont
    {
        public Guid Vehicleidpk { get; set; }

        public string LicensePlate { get; set; }
        
        public string Vin { get; set; }

        public decimal Miles { get; set; }
    }
}
