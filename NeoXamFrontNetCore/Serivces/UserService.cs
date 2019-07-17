using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Entities;
using NeoXamFrontNetCore.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NeoXamFrontNetCore.Serivces
{
    public class UserService : IGenericCrud<User>
    {

        private readonly ApiClientFactory _apiClientFactory;
        public UserService(ApiClientFactory apiClientFactory)
        {
            _apiClientFactory = apiClientFactory;
        }
        public async Task<bool> AddAsync(User t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.userAddUser));
            return await _apiClientFactory.ApiClient.PostAsync<User>(requestUrl, t);
        }


        public async Task<bool> Delete(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.userDeleteUser));
            return await _apiClientFactory.ApiClient.DeleteAsync(requestUrl, id);
        }



        public async Task<bool> Update(long id, User t)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                  ApiUrls.userUpdateUser+id));
            return await _apiClientFactory.ApiClient.PutAsync<User>(requestUrl, t);
        }

       public async Task<User> Get(long id)
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.userGetUser+id));
            return await _apiClientFactory.ApiClient.GetAsync<User>(requestUrl);
        }

       public  async Task<List<User>> GetAll()
        {
            var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                   ApiUrls.userGetAll));
            return await _apiClientFactory.ApiClient.GetAsync<List<User>>(requestUrl);
        }

        public async Task<User> Login(string login, string password)
        {
            try
            {
                var requestUrl = _apiClientFactory.ApiClient.CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                 ApiUrls.userLogin + login + "/" + password));
                return await _apiClientFactory.ApiClient.LoginAsync<User>(requestUrl);
            }
            catch (Exception)
            {

                return null;
            }
          
        }
    }
}
