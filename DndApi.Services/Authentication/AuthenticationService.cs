using System;

namespace DndApi.Services.Authentication
{
    using DndApi.Domain;

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
