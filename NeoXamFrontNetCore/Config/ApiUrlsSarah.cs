﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Config
{
    public static partial class ApiUrls
    {
       

        // Employee 
        public static string AddEmp = "";
        public static string UpdateEmp = "";
        public static string GetEmps = "employee/all";
        public static string DeleteEmp= "";
        public static string GetEmployeById = "employee/find/";

        //Projet
        public static string AddProj = "projet/add";
        public static string UpdateProj = "projet/update/";
        public static string GetAllProj = "projet/all";
        public static string DeleteProj = "projet/delete/";
        public static string GetProjById = "projet/find/";

    }
}
