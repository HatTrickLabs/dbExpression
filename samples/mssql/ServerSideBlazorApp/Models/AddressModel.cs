﻿using ServerSideBlazorApp.Data;
using ServerSideBlazorApp.Validation;
using System.ComponentModel.DataAnnotations;

namespace ServerSideBlazorApp.Models
{
    public class AddressModel
    {
        public AddressType Type { get; set; }

        [Required]
        [StringLength(100)]
        public string Line1 { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string? Line2 { get; set; }
        
        [Required]
        [StringLength(60)]
        public string City { get; set; } = string.Empty;

        [Required]
        [USState]
        public string State { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "The ZIP field does not appear to be a valid US ZIP Code.")]
        public string ZIP { get; set; } = string.Empty;
    }
}
