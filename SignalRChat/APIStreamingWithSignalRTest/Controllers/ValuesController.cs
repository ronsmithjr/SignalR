using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIStreamingWithSignalRTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
       
        public IEnumerable<string> Get()
        {
            Global.LogMessage("Data from Controller");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
       
        public string Get(int id)
        {
            var random = new Random();
            int num = random.Next(1000);
            Global.LogMessage("Request param : " + num);
            return "value" + num;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
