using Daenet.SecurityManager.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    /// <summary>
    /// This mocks security manager
    /// </summary>
    public class MockRoleProvider : IRoleProvider
    {
        public System.Collections.Generic.ICollection<string> GetRoles(System.Security.Claims.ClaimsIdentity identity,
            string secManIdentityName)
        {
            List<string> roles = new List<string>();

            switch (secManIdentityName)
            {
                case "schleifer@daenet.com":
                    roles.Add("Schleifer");
                    break;

                case "dreher@daenet.com":
                    roles.Add("Dreher");
                    break;

                case "manager@daenet.com":
                    roles.Add("Schleifer");
                    roles.Add("Dreher");
                    roles.Add("Toolmanagement");
                    roles.Add("Admin");
                    break;

                default:
                    // No permission!
                    break;
            }

            return roles;
        }
    }
}
