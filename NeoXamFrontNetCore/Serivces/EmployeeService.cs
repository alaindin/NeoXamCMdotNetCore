using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Serivces
{
    public class EmployeeService : IGenericCrud<Employee>
    {
        private readonly ApiClientFactory _apiClientFactory;
        public EmployeeService(ApiClientFactory apiClientFactory)
        {
       
                this._apiClientFactory= apiClientFactory;
        }
        public Task<bool> AddAsync(Employee t)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                    ApiUrls.GetEmps));
            return await _apiClientFactory.ApiClient.GetAsync<List<Employee>>(requestUrl);
        }

        public Task<bool> Update(long id, Employee t)
        {
            throw new NotImplementedException();
        }
    }
}
