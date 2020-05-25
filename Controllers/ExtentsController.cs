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
    public class ExtentsController : ApiController
    {
        Database1Entities3 db = new Database1Entities3();
        public IHttpActionResult PostAnalyzes([FromBody] Result_analyzes analiz)
        {
            db.Result_analyzes.Add(analiz);
            db.SaveChanges();
            return Ok(analiz);
        }
        public IHttpActionResult PostRecipe([FromBody] Recipe recipe)
        {
            db.Recipe.Add(recipe);
            db.SaveChanges();
            return Ok(recipe);
        }
        public IHttpActionResult PostReference([FromBody] Reference reference)
        {
            db.Reference.Add(reference);
            db.SaveChanges();
            return Ok(reference);
        }
    }
}
