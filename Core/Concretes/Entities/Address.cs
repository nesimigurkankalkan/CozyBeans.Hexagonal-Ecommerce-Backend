using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concretes.Entities
{
    public class Address :BaseEntity
    {
        

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } // Ev, İş vb.

        [Required]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        public string AddressLine { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string District { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        public bool IsDefault { get; set; } = false;


        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }


    }
}
