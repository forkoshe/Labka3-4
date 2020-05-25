using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Labka3.Models;

namespace Labka3.Controllers
{
    public class specialdoctorController : ApiController
    {
        Database1Entities3 db = new Database1Entities3();
        public IHttpActionResult GetSpecialdoctor([FromUri] string special)
        {
            return Ok(db.special_doctor.Where(dok => (dok.specialization==special)));
        }

    }
}
