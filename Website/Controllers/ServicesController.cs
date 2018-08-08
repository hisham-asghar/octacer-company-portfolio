using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Website.Models.ViewModels;

namespace Website.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
        // GET: Services
        public ActionResult Detail(string id)
        {
            if (!id.IsNullOrWhiteSpace() && id.ToLower() == ServiceViewConstants.UiUxDesign)
            {
                return View("Details", Models.ServiceModels.GetUiUxDesignViewModel());
            }
            if (!id.IsNullOrWhiteSpace() && id.ToLower() == ServiceViewConstants.WebDev)
            {
                return View("Details", Models.ServiceModels.GetWebDevViewModel());
            }
            return new EmptyResult();
        }
    }
}