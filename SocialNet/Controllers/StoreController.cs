using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocialNet.Models;

namespace SocialNet.Controllers
{
    public class StoreController : Controller
    {
        UsersContext storeDB = new UsersContext();
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var data = storeDB.UserData.ToList();
            return View(data);
        }
        //
        // GET: /Store/Browse
        //public ActionResult Browse(string genre)
        //{
            
        //}
        //
        // GET: /Store/Details
        public ActionResult Change(int id)
        {
            var album = new UsersDataModel { Title = "Album " + id };
            return View(album);
        }

    }
}
