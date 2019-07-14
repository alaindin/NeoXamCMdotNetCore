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
                   ApiUrls.GetAllAction));
            return await _apiClientFactory.ApiClient.PostAsync<ac>(requestUrl, t);
        }


        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.GetDepartements));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }



        public async Task<bool> Update(long id, ac t)
        {
            throw new NotImplementedException();
        }

        Task<ac> IGenericCrud<ac>.Get(long id)
        {
            throw new NotImplementedException();
        }

        Task<List<ac>> IGenericCrud<ac>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
