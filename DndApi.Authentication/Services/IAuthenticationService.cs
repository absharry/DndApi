namespace DndApi.Authentication.Services
{
    using System;
    using Models;

    public interface IAuthenticationService
    {
        Application ValidateApiKey(Guid apiKey);
    }
}