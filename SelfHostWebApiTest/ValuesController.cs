
using Daenet.SecurityManager.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApplication1
{
   // [ScmAuthorizeAttribute]
    public class ValuesController : ApiController 
    { 
        // GET api/values 

        [ScmAuthorizeAttribute("Toolmanagement")]//See RoleProvider.
        public IEnumerable<string> Get() 
        {
            return new string[] { "value1", "value2", Thread.CurrentPrincipal.Identity.Name, Thread.CurrentPrincipal.IsInRole("Toolmanagement").ToString() }; 
        } 

        // GET api/values/5 
        public string Get(int id) 
        { 
            return "value"; 
        } 

        // POST api/values 
        public void Post(string value) 
        { 
        } 

        // PUT api/values/5 
        public void Put(int id, string value) 
        { 
        } 

        // DELETE api/values/5 
        public void Delete(int id) 
        { 
        } 
    } 
} 

