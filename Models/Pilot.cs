using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DroneBusiness.Models
{
    public class Pilot
    {
        [Key]
        public int ID { get; set; }
        public decimal Wage { get; set; }
        public int age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CellNumber { get; set; }
    }
}
