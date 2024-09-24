using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OrsaDemoModels.Entity
{
    public class Personnels
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        /*[Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone number is not valid")]*/
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }

        
    }
}
