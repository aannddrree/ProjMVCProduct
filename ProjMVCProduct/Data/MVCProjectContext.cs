using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjMVCProduct.Models;

namespace ProjMVCProduct.Data
{
    public class MVCProjectContext : DbContext
    {

        public MVCProjectContext(DbContextOptions<MVCProjectContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

    }
}
