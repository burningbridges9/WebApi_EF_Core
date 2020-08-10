using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_EF_Core_ForFun.Dtos;
using WebApi_EF_Core_ForFun.Models;

namespace WebApi_EF_Core_ForFun.Maps
{
    public class PetMap : Profile
    {
        public PetMap()
        {
            CreateMap<Pet, PetReadDto>();
            CreateMap<PetCreateDto, Pet>();
            CreateMap<PetUpdateDto, Pet>();
        }
    }
}
