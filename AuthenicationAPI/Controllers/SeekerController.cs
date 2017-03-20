using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;

namespace AuthenicationAPI.Controllers
{
    [RoutePrefix("api/seekers")]
    public class SeekerController : ApiController
    {
        //
        // GET: /Seeker/
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(seeker.CreateOrders());
        }
	}

    #region Helpers

    public class seeker
    {
        public int SeekerID { get; set; }
        public string seekerName { get; set; }
        public string seekerCity { get; set; }
        public Boolean IsProfileComplete { get; set; }

        public static List<seeker> CreateOrders()
        {
            List<seeker> OrderList = new List<seeker> 
            {
                new seeker {SeekerID = 10248, seekerName = "Taiseer Joudeh", seekerCity = "Amman", IsProfileComplete = true },
                new seeker {SeekerID = 10249, seekerName = "Ahmad Hasan", seekerCity = "Dubai", IsProfileComplete = false},
                new seeker {SeekerID = 10250,seekerName = "Tamer Yaser", seekerCity = "Jeddah", IsProfileComplete = false },
                new seeker {SeekerID = 10251,seekerName = "Lina Majed", seekerCity = "Abu Dhabi", IsProfileComplete = false},
                new seeker {SeekerID = 10252,seekerName = "Yasmeen Rami", seekerCity = "Kuwait", IsProfileComplete = true}
            };

            return OrderList;
        }
    }

    #endregion
}