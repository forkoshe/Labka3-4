using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Labka3.Models;

namespace Labka3.Controllers
{

    public class familydoctorController : ApiController
    {
        Database1Entities3 db=new Database1Entities3();
        public IHttpActionResult Getfamily_doctor([FromUri] string namefamilydoctor)
        {
            return Ok(db.family_doctor.Where(e => e.name == namefamilydoctor));
        }
    }
}
