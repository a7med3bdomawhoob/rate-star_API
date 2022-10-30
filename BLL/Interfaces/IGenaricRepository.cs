using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGenaricRepository<T>
    {

        Task<IEnumerable<T>> getall();
       
        Task <T>GetById(int id);
  

        Task Add(T entity);
         void Delete(T entity);
         void Update(T entity);


    }
}
