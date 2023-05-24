using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Models
{
    public class InsuredPerson
    {
        public int InsuredPersonId { get; set; }
        public int PersonName { get; set; }
        public int Age { get; set; }
        public int DateofBirth { get; set; }
        
        //Reference from Occupation
        public int OccupationID { get; set; }

        public float SumInsured { get; set; }
    }
}
