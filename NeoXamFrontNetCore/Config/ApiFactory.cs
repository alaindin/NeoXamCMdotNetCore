using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Config
{
    internal  class ApiClientFactory
    {
        private static Uri apiUri;

        private  Lazy<ApiClient> restClient = new Lazy<ApiClient>(
          () => new ApiClient(apiUri),
          LazyThreadSafetyMode.ExecutionAndPublication);

        public ApiClient ApiClient
        {
            get
            {
                return restClient.Value;
            }
        }
        public ApiClientFactory()
        {
            apiUri = new Uri(ApiUrls.serverRootPath);
        }

       
    }
}
