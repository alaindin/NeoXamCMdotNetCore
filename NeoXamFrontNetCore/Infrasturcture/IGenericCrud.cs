using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Infrasturcture
{

    public interface IGenericCrud<T> where T : class
    {

        Task AddAsync(T t);
        Task Update(long id, T t);
        Task Delete(long id);
        Task<T> FindById(long id);
        Task<List<T>> GetAll();


    }
}
