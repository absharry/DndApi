namespace DndApi.Services.Authentication
{
    using System;
    using Domain;

    public interface IAuthenticationService
    {
        Application ValidateApiKey(Guid apiKey);
    }
}