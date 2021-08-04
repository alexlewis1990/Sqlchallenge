using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    public class Challenge_4
    {
        public int Useridpk { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime JoinedOn { get; set; }

        public int Useridfk { get; set; }

        public int MessageThreadidfk { get; set; }

        public int MessageThreadidpk { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }
    }
}
