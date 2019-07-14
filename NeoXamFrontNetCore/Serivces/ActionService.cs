using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ac = NeoXamFrontNetCore.Entities.Action;

namespace NeoXamFrontNetCore.Serivces
{
    public class ActionService : IGenericCrud<ac>
    {

        private readonly ApiClientFactory _apiClientFactory;
        public ActionService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }
        public async Task<bool> AddAsync(ac t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.AddAction));
            return await _apiClientFactory.ApiClient.PostAsync<ac>(requestUrl, t);
        }


        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteAction));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }



        public async Task<bool> Update(long id, ac t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.UpdateAction));
            return await _apiClientFactory.ApiClient.PutAsync<ac>(requestUrl, t);
        }

        async Task<ac> IGenericCrud<ac>.Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.DeleteAction));
            return await _apiClientFactory.ApiClient.GetAsync<ac>(requestUrl);
        }

        async Task<List<ac>> IGenericCrud<ac>.GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.DeleteAction));
            return await _apiClientFactory.ApiClient.GetAsync<List<ac>>(requestUrl);
        }
    }
}
