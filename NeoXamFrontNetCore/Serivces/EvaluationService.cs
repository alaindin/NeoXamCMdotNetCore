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

        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.DeleteEvaluation));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }

        public async Task<Evaluation> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.FindEvaluation));
            return await _apiClientFactory.ApiClient.GetAsync<Evaluation>(requestUrl);
        }

        public async Task<List<Evaluation>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetAllEvaluation));
            return await _apiClientFactory.ApiClient.GetAsync<List<Evaluation>>(requestUrl);
        }

        public async Task<bool> Update(long id, Evaluation t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.UpdateEvaluation));
            return await _apiClientFactory.ApiClient.PutAsync<Evaluation>(requestUrl, t);
        }
    }
}
