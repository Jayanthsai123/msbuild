using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevOpsSolution.Controllers
{
    public class DevOpsController : Controller
    {
        [Authorize]
        public string Hello()
        {
            return "Hello " + User.Identity.Name;
        }
    }
}