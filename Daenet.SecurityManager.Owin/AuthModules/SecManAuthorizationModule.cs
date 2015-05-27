using Daenet.SecurityManager.Client;
using Daenet.SecurityManager.Client.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daenet.SecurityManager.Owin
{
    internal class SecManAuthorizationModule : IRoleProvider
    {
        public Guid ApplicationId { get; set; }

        public ICollection<string> GetRoles(System.Security.Claims.ClaimsIdentity identity, string secManIdentityName)
        {
            SecurityManagerClient secManClient = new SecurityManagerClient();
            var response = secManClient.ResolveIdentity(secManIdentityName, ApplicationId, UserInclude.None);
            return response.Roles.ToArray();
        }
    }
}
