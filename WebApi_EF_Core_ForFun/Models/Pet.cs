using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_EF_Core_ForFun.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        [Required]
        public PetType PetType { get; set; }
    }
    public enum PetType
    {
        Dog,
        Cat,
    }
}
