namespace DndApi.Api.Modules
{
    using Authentication;
    using Nancy;
    using Nancy.Security;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            this.RequiresAuthentication();
            this.Get("/", args => this.Response.AsText($"Welcome to the Api {this.Context.CurrentUser.AsAppPrincipal().AppName}"));
        }
    }
}
