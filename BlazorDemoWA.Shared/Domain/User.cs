using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemoWA.Shared.Domain
{
    public class User
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(20, ErrorMessage = "Name is too long.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        public string WebSite { get; set; }

        public Address? Address { get; set; }

    }
}
