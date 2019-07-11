using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Infrasturcture
{

    public interface IGenericCrud<T> where T : class
    {

        void Add(T t);
        void Update(long id, T t);
        void Delete(long id);
        T FindById(long id);
        List<T> GetAll();

    }
}
