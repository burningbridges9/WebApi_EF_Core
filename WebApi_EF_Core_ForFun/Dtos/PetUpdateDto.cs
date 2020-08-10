using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_EF_Core_ForFun.Dtos
{
    public class PetUpdateDto : PetBaseDto
    {
        public DateTime? ReleaseDate { get; set; }
    }
}
