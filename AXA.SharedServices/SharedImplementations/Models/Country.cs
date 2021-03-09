using AXA.SharedServices.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AXA.SharedServices.SharedImplementations.Models
{
   public class Country : ICountries
    {
        [Key]
        public int Id { get; set;}

        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }
    }
}
