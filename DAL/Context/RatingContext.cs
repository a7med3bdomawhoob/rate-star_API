using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class RatingContext:DbContext
    {
        public RatingContext(DbContextOptions<RatingContext> options):base(options)
        {

        }

       public DbSet<Customer> customers { get; set; }
       public DbSet<Rating> rates { get; set; }
       public DbSet<Address> address { get; set; }
    }
}
