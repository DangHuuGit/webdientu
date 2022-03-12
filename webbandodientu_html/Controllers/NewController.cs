using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webbandodientu_html.Context;

namespace webbandodientu_html.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        OnlineShopEntitiess objModel = new OnlineShopEntitiess();
        public ActionResult Index()
        {
            var lstNews = objModel.News.ToList();
            return View(lstNews);
        }
    }
}