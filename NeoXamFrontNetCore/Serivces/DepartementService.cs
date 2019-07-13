using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Serivces
{
    public class DepartementService : IGenericCrud<Departement>
    {
        private ApiClient _apiClient;
        public DepartementService(ApiClient apiClient)
        {
            _apiClient = apiClient;
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
            var requestUrl = _apiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                ApiUrls.GetDepartements));
            return await _apiClient.GetAsync<List<Departement>>(requestUrl);
        }

        public async Task Update(long id, Departement t)
        {
           //
        }
    }
}
