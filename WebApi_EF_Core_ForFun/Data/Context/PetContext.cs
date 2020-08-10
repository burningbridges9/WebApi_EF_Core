using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_EF_Core_ForFun.Models;

namespace WebApi_EF_Core_ForFun.Data.Context
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Pet> Pets { get; set; }
    }
}
