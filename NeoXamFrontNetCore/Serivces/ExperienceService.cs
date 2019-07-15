using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;

namespace NeoXamFrontNetCore.Serivces
{
    public class ExperienceService : IGenericCrud<Experience>
    {
        private readonly ApiClientFactory _apiClientFactory;
        public ExperienceService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }

        public async Task<bool> AddAsync(Experience t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.AddDepartement));
            return await _apiClientFactory.ApiClient.PostAsync<Experience>(requestUrl, t);
        }

        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteDepartement));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }

        public async Task<Experience> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<Experience>(requestUrl);
        }

        public async Task<List<Experience>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<List<Experience>>(requestUrl);
        }

        public async Task<bool> Update(long id, Experience d)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                     ApiUrls.UpdateDepartement + id));
            return await _apiClientFactory.ApiClient.PutAsync<Experience>(requestUrl, d);
        }
    }
}
