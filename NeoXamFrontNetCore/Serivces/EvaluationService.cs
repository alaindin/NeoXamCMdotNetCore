using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Serivces
{
    public class EvaluationService : IGenericCrud<Evaluation>
    {
        private readonly ApiClientFactory _apiClientFactory;
        public EvaluationService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }
        public async Task<bool> AddAsync(Evaluation t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.AddEvaluation));
            return await _apiClientFactory.ApiClient.PostAsync<Evaluation>(requestUrl, t);
        }

        public async Task<bool> Delete(long id,long id2)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.DeleteEvaluation+id +"/"));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id2);
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Evaluation> Get(long id, long id2)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.FindEvaluation + id + "/"));
            return await _apiClientFactory.ApiClient.GetAsync<Evaluation>(requestUrl);
        }

        public Task<Evaluation> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Evaluation>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetAllEvaluation));
            return await _apiClientFactory.ApiClient.GetAsync<List<Evaluation>>(requestUrl);
        }

        public async Task<bool> Update(long id, long id2, Evaluation t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.UpdateEvaluation + id + "/"));
            return await _apiClientFactory.ApiClient.PutAsync<Evaluation>(requestUrl, t);
        }

        public Task<bool> Update(long id, Evaluation t)
        {
            throw new NotImplementedException();
        }
    }
}
