using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Config
{
    public static partial class ApiUrls
    {
        public static string serverRootPath = "http://127.0.0.1:8080/NeoXamHR-web/api/";

        public static string userAddUser = "user/add";
        public static string userGetUser = "user/find/";
        public static string userDeleteUser = "user/delete/";
        public static string userUpdateUser = "user/update/";
        public static string userLogin = "user/loginUser/";
        public static string userGetAll = "user/all";

    }
}
