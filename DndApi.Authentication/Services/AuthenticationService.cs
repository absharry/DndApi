using System;

namespace DndApi.Authentication.Services
{
    using Models;

    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService()
        {

        }

        public Application ValidateApiKey(Guid apiKey)
        {
            return new Application("example Application");
        }
    }
}
