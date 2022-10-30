using BLL.Interfaces;
using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : class
    {
        private readonly RatingContext context;

        public GenaricRepository(RatingContext context)
        {
            this.context = context;
        }
        public async Task Add(T entity)
        {
            await context.Set<T>().AddAsync(entity);
             context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

     

        public async Task<IEnumerable<T>> getall()
        {
            if (typeof(T) == typeof(Rating))
            {
                return (IEnumerable<T>)await context.Set<Rating>().Include(c => c.CustomerId).ToListAsync();
            }
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
           return await context.Set<T>().FindAsync(id);
        }

     
        public void Update(T entity)
        {
             context.Update(entity);
            context.SaveChanges();
        }
    }
}
