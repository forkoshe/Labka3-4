using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Labka3.Models;
using System.Data.Entity;


namespace Labka3.Controllers
{
    [Authorize]
    public class MedicalCardController : ApiController
    {
        Database1Entities3 db = new Database1Entities3();
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(db.medical_card.ToList());
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }
        public IHttpActionResult post([FromBody] medical_card medical)
        {
            try
            {
                db.medical_card.Add(medical);
                db.SaveChanges();
                return Ok(medical);
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }
        public IHttpActionResult Delete(int Id)
        {
            medical_card medical = db.medical_card.Find(Id);
            if (medical == null)
            {
                return NotFound();
            }
            else
            {
                db.medical_card.Remove(medical);
                db.SaveChanges();
                return Ok();
            }
        }
        public IHttpActionResult Patch(int Id,[FromBody] medical_card medical)
        {
            try
            {
                db.Entry(medical).State = EntityState.Modified;
                db.SaveChanges();
                return Ok(medical);
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }
    }
}
