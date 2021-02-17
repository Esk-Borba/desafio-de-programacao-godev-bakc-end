﻿using desafioProg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace desafioProg.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class cafesController : ApiController
    {
        // GET: api/cafes
        public IEnumerable<dynamic> Get()
        {
            using (desafioProgEntities bd = new desafioProgEntities())
            {
                var cafes = from caf in bd.cafes
                            select new { caf.id, caf.nome, caf.lotacao };
                return cafes.ToList();
            }
        }

        // GET: api/cafes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/cafes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/cafes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/cafes/5
        public void Delete(int id)
        {
        }
    }
}
