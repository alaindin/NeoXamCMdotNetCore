using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Serivces
{
    public partial class DepartementService 
    {
        private readonly ApiClientFactory _apiClientFactory;
        public DepartementService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }
        public async Task AddAsync(Departement t)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Departement> FindById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Departement>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<List<Departement>>(requestUrl);
        }

        public async Task Update(long id, Departement t)
        {
           //
        }
    }
}
