using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReportServerIntegration.Controllers
{
    public class MLBBController : ApiController
    {
        // GET: api/MLBB
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MLBB/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MLBB
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MLBB/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MLBB/5
        public void Delete(int id)
        {
        }
    }
}
