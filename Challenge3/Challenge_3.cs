using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public class Challenge_3
    {
        public Guid Listingid { get; set; }

        public DateTime DateListed { get; set; }

        public bool isRental { get; set; }

        public Guid Houseidfk { get; set; }
    }
    public class ChallengeCont3
    {
        public Guid Houseidpk { get; set; }

        public decimal NumberofBedrooms { get; set; }

        public decimal NumberofBaths { get; set; }

        public decimal EstimatedValue { get; set; }
    }
}
