using Sitecore.WFFM.Analytics.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Web.Http.Filters;
using Sitecore.Diagnostics;
using Sitecore.Configuration;

namespace Sitecore.Support.WFFM.Services.Requests.Controllers
{
    public class FormReportsExController : Sitecore.WFFM.Services.Requests.Controllers.FormReportsController
    {
       

        public FormReportsExController() : base()
        {

        }

        public FormReportsExController(IWfmDataProvider formsDataProvider) : base(formsDataProvider)
        {
           
        }

        [ValidateHttpAntiForgeryToken]
        public ActionResult GetFormFieldsStatisticsEx(Guid id)
        {
            JsonResult result = base.GetFormFieldsStatistics(id) as JsonResult;
            result.MaxJsonLength = Settings.GetIntSetting("WFFM.MaxJsonLength", 2097152);
            return result;
        }
    }
}