using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Labka3.Models;

namespace Labka3.Controllers
{
    [Authorize]
    public class RegistationController : ApiController
    {
        Database1Entities3 db=new Database1Entities3();
        public bool check_declaration(int Id)
        {
            patient patient = db.patient.Find(Id);
            if (patient.declaration == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool check_name(int Id)
        {
            patient patient = db.patient.Find(Id);
            if (patient == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Crate_declaration(int Id)
        {
            patient patient = db.patient.Find(Id);
            if (patient.declaration == "false")
            {
                patient.declaration = "true";
            }
        }
    }
}
