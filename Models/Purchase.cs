using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int purchaseId { get; set;}
        [BindNever]
        public ICollection<CartItem> Items { get; set; }
        [Required(ErrorMessage ="Please enter a name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an address:")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required(ErrorMessage = "Please enter city name:")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter state name:")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter zip code:")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter country name:")]
        public string Country { get; set; }
        [BindNever]
        public bool PurchaseShipped { get; set; }
        
    }
}
