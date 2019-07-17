using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoXamFrontNetCore.Config
{
    public static partial class ApiUrls
    {
        //Risk
        public static string GetAllRisk = "risk/all";
        public static string AddRisk = "risk";
        public static string DeleteRisk = "risk/";
        public static string UpdateRisk = "risk/";
        public static string FindRisk = "risk/";

        //Action
        public static string GetAllAction = "action/all";
        public static string AddAction = "action/add";
        public static string DeleteAction = "action/";
        public static string UpdateAction = "action/";
        public static string FindAction = "action/";

        //Evaluation
        public static string GetAllEvaluation = "evaluation/all";
        public static string AddEvaluation = "evaluation/add/";
        public static string DeleteEvaluation = "evaluation/";
        public static string UpdateEvaluation = "evaluation/";
        public static string FindEvaluation = "evaluation/";
        public static string FindEvaluationRis = "evaluation/rs/";
        public static string FindEvaluationEmp = "evaluation/emp/";

    }
}
