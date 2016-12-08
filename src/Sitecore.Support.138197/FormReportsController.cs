using Sitecore.WFFM.Analytics.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Web.Http.Filters;

namespace Sitecore.Support.WFFM.Services.Requests.Controllers
{
    public class FormReportsExController : Sitecore.WFFM.Services.Requests.Controllers.FormReportsController
    {
        int maxJsonLength = 2097152;

        public FormReportsExController() : base()
        {

        }

        public FormReportsExController(IWfmDataProvider formsDataProvider, int MaxJsonLength) : base(formsDataProvider)
        {
            if (MaxJsonLength > 0)
            {
                this.maxJsonLength = MaxJsonLength;
            }
        }

        [ValidateHttpAntiForgeryToken]
        public new ActionResult GetFormFieldsStatistics(Guid id)
        {
            JsonResult result = base.GetFormFieldsStatistics(id) as JsonResult;
            result.MaxJsonLength = this.maxJsonLength;
            return result;
        }
    }
}