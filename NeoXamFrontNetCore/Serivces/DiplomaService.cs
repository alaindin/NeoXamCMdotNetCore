using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;

namespace NeoXamFrontNetCore.Serivces
{
    public class DiplomaService : IGenericCrud<Diploma>
    {
        private readonly ApiClientFactory _apiClientFactory;
        public DiplomaService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }

        public async Task<bool> AddAsync(Diploma t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.AddDepartement));
            return await _apiClientFactory.ApiClient.PostAsync<Diploma>(requestUrl, t);
        }

        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteDepartement));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }

        public async Task<Diploma> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<Diploma>(requestUrl);
        }

        public async Task<List<Diploma>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<List<Diploma>>(requestUrl);
        }

        public async Task<bool> Update(long id, Diploma d)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                     ApiUrls.UpdateDepartement + id));
            return await _apiClientFactory.ApiClient.PutAsync<Diploma>(requestUrl, d);
        }
    }
}
