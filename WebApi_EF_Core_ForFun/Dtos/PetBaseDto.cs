using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApi_EF_Core_ForFun.Models;

namespace WebApi_EF_Core_ForFun.Dtos
{
    public class PetBaseDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public PetType PetType { get; set; }
    }
}
