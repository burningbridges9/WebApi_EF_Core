using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_EF_Core_ForFun.Data.Repository;
using WebApi_EF_Core_ForFun.Dtos;
using WebApi_EF_Core_ForFun.Models;

namespace WebApi_EF_Core_ForFun.Controllers
{
    [Route("api/pets")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IRepository<Pet> _petsRepo;
        private readonly IMapper _mapper;

        public PetsController(IRepository<Pet> repository, IMapper mapper)
        {
            _petsRepo = repository;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name ="Get")]
        public ActionResult<PetReadDto> Get(int id)
        {
            var pet = _petsRepo.Get(id);
            if (pet is null)
                return NotFound();

            return Ok(_mapper.Map<PetReadDto>(pet));
        }

        [HttpGet]
        public ActionResult<IEnumerable<PetReadDto>> GetList()
        {
            return Ok(_mapper.Map<IEnumerable<PetReadDto>>(_petsRepo.GetList().ToList()));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _petsRepo.Delete(id);
            _petsRepo.SaveChanges();
            return NoContent();
        }

        [HttpPost]
        public ActionResult<PetReadDto> Create(PetCreateDto pet)
        {
            var petToCreate = _mapper.Map<Pet>(pet);
            _petsRepo.Create(petToCreate);
            _petsRepo.SaveChanges();
            var created = _mapper.Map<PetReadDto>(petToCreate);
            return CreatedAtRoute(nameof(Get), new { Id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, PetUpdateDto pet)
        {
            var petToUpdate = _petsRepo.Get(id);
            if (petToUpdate is null)
                return NotFound();

            _mapper.Map(pet, petToUpdate);

            _petsRepo.Update(petToUpdate);
            _petsRepo.SaveChanges();
            return NoContent();
        }
    }
}
