using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NeoXamFrontNetCore.Serivces
{
    public class ProjectService : IGenericCrud<Project>
    {

        private readonly ApiClientFactory _apiClientFactory;
        public ProjectService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }
        public async Task<bool> AddAsync(Project t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.AddProj));
            return await _apiClientFactory.ApiClient.PostAsync<Project>(requestUrl, t);
        }


        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteProj));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }



        public async Task<bool> Update(long id, Project t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.UpdateProj+id));
            return await _apiClientFactory.ApiClient.PutAsync<Project>(requestUrl, t);
        }

       public async Task<Project> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetProjById+id));
            return await _apiClientFactory.ApiClient.GetAsync<Project>(requestUrl);
        }

       public  async Task<List<Project>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetAllProj));
            return await _apiClientFactory.ApiClient.GetAsync<List<Project>>(requestUrl);
        }
    }
}
