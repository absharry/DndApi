using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndApi.Api.Authentication
{
    using System.Security.Claims;
    using System.Security.Principal;

    public class AppPrincipal : ClaimsPrincipal
    {
        public AppPrincipal(IPrincipal principal) : base(principal)
        {

        }

        public string AppName => FindFirst(ClaimTypes.Name).Value;
    }
}
