using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant.Models
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }
        
        public Adress()
        {

        }

        public Adress(string Street, string Locality, string ZipCode, string City)
        {
            this.Street = Street;
            this.Locality = Locality;
            this.ZipCode = ZipCode;
            this.City = City;
        }
    }
}
