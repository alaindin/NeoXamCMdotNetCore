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
            _apiClientFactory = apiClientFactory;
        }

        public async Task<bool> AddAsync(Employee t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.AddDepartement));
            return await _apiClientFactory.ApiClient.PostAsync<Employee>(requestUrl, t);
        }

        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteDepartement));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }

        public async Task<Employee> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<Employee>(requestUrl);
        }

        public async Task<List<Employee>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<List<Employee>>(requestUrl);
        }

        public async Task<bool> Update(long id, Employee d)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                     ApiUrls.UpdateDepartement + id));
            return await _apiClientFactory.ApiClient.PutAsync<Employee>(requestUrl, d);
        }
    }
}
