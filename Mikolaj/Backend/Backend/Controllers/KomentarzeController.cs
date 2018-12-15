using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Backend.Models; //import modeli
using System.Web.Http.Cors; //dla akceptowania żadań przez witrynę o innym adresie

namespace Backend.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class KomentarzeController : ApiController
    {
        // GET api/komentarze
        public IEnumerable<Comment> Get() // ["aa", "bb"]
        {
            var db = new MikolajEntities(); //uchwyt do bazy danych
            return db.Comments.ToArray();
        }

        // GET api/komentarze/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/komentarze
        public void Post([FromBody]string value)
        {
        }

        // PUT api/komentarze/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/komentarze/5
        public void Delete(int id)
        {
        }
    }
}
