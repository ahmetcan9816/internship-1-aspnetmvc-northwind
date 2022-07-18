﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Northwind.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "İsim girilmesi zorunludur.")]
        public string Name { get; set; }
        [Required()]
        [MinLength(10)]
        [MaxLength(50)]
        public string Address1 { get; set; }
        [MaxLength(50)]
        public string Address2 { get; set; }
        [MaxLength(50)]
        public string Address3 { get; set; }
        [Required()]
        public string City { get; set; }
        public string Country { get; set; }
        public bool IsGift { get; set; }
        
    }
}