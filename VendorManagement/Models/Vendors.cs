using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendorManagement.Models
{
    public class Vendors
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Vendor Name"), Required]
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? Position { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int ZipCode { get; set; }
        public List<string> Notes { get; set; } = [];
    }
}
