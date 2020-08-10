using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_EF_Core_ForFun.Models;

namespace WebApi_EF_Core_ForFun.Dtos
{
    public class PetReadDto : PetBaseDto
    {
        public int Id { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
