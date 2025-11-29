using Core.Abstracts.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concretes.Entities
{
    public class User:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        public string PasswordHash { get; set; }
        
        public DateTime? LastLoginDate { get; set; } 

        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();  
        public virtual ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();
        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

    }
}
