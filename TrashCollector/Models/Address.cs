using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Street With Number")]
        public string Street { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public int Zip { get; set; }
    }
}
