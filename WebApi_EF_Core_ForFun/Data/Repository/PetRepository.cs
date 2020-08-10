using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_EF_Core_ForFun.Data.Context;
using WebApi_EF_Core_ForFun.Models;

namespace WebApi_EF_Core_ForFun.Data.Repository
{
    public class PetRepository : IRepository<Pet>
    {
        private readonly PetContext _petContext;
        public PetRepository(PetContext petContext)
        {
            _petContext = petContext;
        }
        public void Create(Pet item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));

            _petContext.Pets.Add(item);
        }

        public void Delete(int id)
        {
            var pet = _petContext.Pets.FirstOrDefault(x => x.Id == id);
            if (pet != null)
                _petContext.Pets.Remove(pet);
        }

        public Pet Get(int id)
        {
            return _petContext.Pets.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Pet> GetList()
        {
            return _petContext.Pets.ToList();
        }

        public void SaveChanges()
        {
            _petContext.SaveChanges();
        }

        public void Update(Pet item)
        {
            _petContext.Pets.Update(item);
        }
    }
}
