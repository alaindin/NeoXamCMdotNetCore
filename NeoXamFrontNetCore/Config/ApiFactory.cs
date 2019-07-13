using NeoXamFrontNetCore.Serivces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Config
{
    public  class ApiClientFactory
    {

        private static Uri apiUri;

        private readonly ApiClient apiClient; 

        public ApiClientFactory()
        {
            apiUri = new Uri(ApiUrls.serverRootPath);
            apiClient = new ApiClient(apiUri);
            
        }

        public  ApiClient ApiClient
        {
            get
            {
                return apiClient;
            }
        }


    }
}
