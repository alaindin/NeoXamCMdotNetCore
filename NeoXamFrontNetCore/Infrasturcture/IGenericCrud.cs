using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Infrasturcture
{

    public interface IGenericCrud<T> where T : class
    {

        Task<bool> AddAsync(T t);
        Task<bool> Update(long id, T t);
        Task<bool> Delete(long id);
        Task<T> Get(long id);
        Task<List<T>> GetAll();


    }
}
