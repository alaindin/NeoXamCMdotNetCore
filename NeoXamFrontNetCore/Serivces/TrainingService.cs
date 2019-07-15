using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;

namespace NeoXamFrontNetCore.Serivces
{
    public class TrainingService  : IGenericCrud<Trainning>
    {
        private readonly ApiClientFactory _apiClientFactory;
        public TrainingService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }

        public async Task<bool> AddAsync(Trainning t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.AddDepartement));
            return await _apiClientFactory.ApiClient.PostAsync<Trainning>(requestUrl, t);
        }

        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteDepartement));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }

        public async Task<Trainning> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<Trainning>(requestUrl);
        }

        public async Task<List<Trainning>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.GetAsync<List<Trainning>>(requestUrl);
        }

        public async Task<bool> Update(long id, Trainning d)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                     ApiUrls.UpdateDepartement + id));
            return await _apiClientFactory.ApiClient.PutAsync<Trainning>(requestUrl, d);
        }
    }
}
