using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WasteManagement.Models
{
    public class Addresses
    {
        [Key]
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        
        public string City { get; set; }
        public string State { get; set; }
        public double ZipCode { get; set; }
        
    }
}
