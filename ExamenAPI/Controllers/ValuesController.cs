using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ExamenAPI.Controllers
{
    [EnableCors(origins: "https://localhost:44396", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        public Dictionary<string, List<string>> estados = new Dictionary<string, List<string>>();

        public ValuesController()
        {
            estados.Add("Estado 1", new List<string>()
            {
                "ciudad 1 Estado 1",
                "ciudad 2 Estado 1",
                "ciudad 3 Estado 1"
            });
            estados.Add("Estado 2", new List<string>()
            {
                "ciudad 1 Estado 2",
                "ciudad 2 Estado 2",
                "ciudad 3 Estado 2"
            });
            estados.Add("Estado 3", new List<string>()
            {
                "ciudad 1 Estado 3",
                "ciudad 2 Estado 3",
                "ciudad 3 Estado 3"
            });
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        
        public IEnumerable<string> Post([FromBody] string Estado)
        {
            var ciudades = estados.Where(x => x.Key == Estado).SelectMany(x=>x.Value);
            return ciudades;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
