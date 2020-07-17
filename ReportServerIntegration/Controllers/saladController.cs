using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReportServerIntegration.Controllers
{
    public class saladController : ApiController
    {
        // GET: api/salad
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/salad/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/salad
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/salad/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/salad/5
        public void Delete(int id)
        {
        }
    }
}
