using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndApi.Api.Authentication
{
    using System.Security.Principal;

    public static class PrincipalExtensions
    {
        public static AppPrincipal AsAppPrincipal(this IPrincipal principal)
        {
            if (principal != null)
            {
                return principal as AppPrincipal ?? new AppPrincipal(principal);
            }

            return null;
        }
    }
}
