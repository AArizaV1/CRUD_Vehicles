using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Week7CodeAssessment.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Claims = new HashSet<Claim>();
        }

        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Vin { get; set; }
        public string? Color { get; set; }

        [Range(1886, 2100, ErrorMessage = "Enter a year between 1886 and 2100.")]
        public int? Year { get; set; }

        public int? OwnerId { get; set; }

    

        public virtual Owner? Owner { get; set; }
        public virtual ICollection<Claim> Claims { get; set; }
    }
}
