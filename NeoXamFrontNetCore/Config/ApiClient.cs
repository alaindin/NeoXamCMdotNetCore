using NeoXamFrontNetCore.Config;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Serivces
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ApiClient
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        private Uri BaseEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseEndpoint"></param>
        public ApiClient(Uri baseEndpoint)
        {
            if (baseEndpoint == null)
            {
                throw new ArgumentNullException("baseEndpoint");
            }
            BaseEndpoint = baseEndpoint;
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUrl"></param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(Uri requestUrl)
        {
            addHeaders();
            var response = await _httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUrl"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<bool> PostAsync<T>(Uri requestUrl, T content)
        {
            try
            {
                addHeaders();
                var response = await _httpClient.PostAsync(requestUrl.ToString(), CreateHttpContent<T>(content));
                response.EnsureSuccessStatusCode();
              
                return true;
            }
            catch (Exception)
            {

                return false;
            }
         
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUrl"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task<bool> PutAsync<T>(Uri requestUrl, T content)
        {
            try
            {
                addHeaders();
                var response = await _httpClient.PutAsync(requestUrl.ToString(), CreateHttpContent<T>(content));
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUrl"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(Uri requestUrl, long id)
        {
            try
            {
                addHeaders();
                var response = await _httpClient.DeleteAsync(requestUrl.ToString() + id);
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
         
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public Uri CreateRequestUri(string relativePath, string queryString = "")
        {
            var endpoint = new Uri(BaseEndpoint, relativePath);
            var uriBuilder = new UriBuilder(endpoint);
            uriBuilder.Query = queryString;
            return uriBuilder.Uri;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        public HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content, MicrosoftDateFormatSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        /// <summary>
        /// 
        /// </summary>
        private static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void addHeaders()
        {

            // _httpClient.DefaultRequestHeaders.Add("Basic", "xxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        }
    }
}
