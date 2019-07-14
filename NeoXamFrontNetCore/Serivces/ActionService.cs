using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NeoXamFrontNetCore.Serivces
{
    public class ActionService : IGenericCrud<Entities.Action>
    {

        private readonly ApiClientFactory _apiClientFactory;
        public ActionService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }
        public async Task<bool> AddAsync(Entities.Action t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.AddAction));
            return await _apiClientFactory.ApiClient.PostAsync<Entities.Action>(requestUrl, t);
        }


        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteAction));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }



        public async Task<bool> Update(long id, Entities.Action t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.UpdateAction));
            return await _apiClientFactory.ApiClient.PutAsync<Entities.Action>(requestUrl, t);
        }

       public async Task<Entities.Action> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.DeleteAction));
            return await _apiClientFactory.ApiClient.GetAsync<Entities.Action>(requestUrl);
        }

      public  async Task<List<Entities.Action>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.DeleteAction));
            return await _apiClientFactory.ApiClient.GetAsync<List<Entities.Action>>(requestUrl);
        }
    }
}
