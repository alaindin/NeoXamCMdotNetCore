using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Serivces
{
    public class ActionService : IGenericCrud<Action>
    {
        public Task<bool> AddAsync(Action t)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Action> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Action>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(long id, Action t)
        {
            throw new NotImplementedException();
        }
    }
}
