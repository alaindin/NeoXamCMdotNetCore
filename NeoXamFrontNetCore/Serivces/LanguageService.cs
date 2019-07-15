using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Serivces
{

    public class LanguageService : IGenericCrud<Language>
    {
        private readonly ApiClientFactory _apiClientFactory;
        public LanguageService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }

        public async Task<bool> AddAsync(Language t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.AddDepartement));
            return await _apiClientFactory.ApiClient.PostAsync<Language>(requestUrl, t);
        }

        public async Task<bool> Delete(long id)
        {

            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteDepartement));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }

        public async Task<Language> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<Language>(requestUrl);
        }

        public async Task<List<Language>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<List<Language>>(requestUrl);
        }

        public async Task<bool> Update(long id, Language d)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                     ApiUrls.UpdateDepartement + id));
            return await _apiClientFactory.ApiClient.PutAsync<Language>(requestUrl, d);
        }

        
    }
}
