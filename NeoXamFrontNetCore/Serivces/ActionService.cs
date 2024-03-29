﻿using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NeoXamFrontNetCore.Serivces
{
    public class ActionService : IGenericCrud<ActionModel>
    {

        private readonly ApiClientFactory _apiClientFactory;
        public ActionService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }
        public async Task<bool> AddAsync(ActionModel t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.AddAction));
            return await _apiClientFactory.ApiClient.PostAsync<ActionModel>(requestUrl, t);
        }


        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.DeleteAction));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }



        public async Task<bool> Update(long id, Entities.ActionModel t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.UpdateAction));
            return await _apiClientFactory.ApiClient.PutAsync<Entities.ActionModel>(requestUrl, t);
        }

       public async Task<Entities.ActionModel> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.FindAction + id));
            return await _apiClientFactory.ApiClient.GetAsync<Entities.ActionModel>(requestUrl);
        }

       public  async Task<List<Entities.ActionModel>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.GetAllAction));
            return await _apiClientFactory.ApiClient.GetAsync<List<Entities.ActionModel>>(requestUrl);
        }
    }
}
