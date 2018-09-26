namespace DndApi.Api
{
    using System.Security.Claims;
    using System.Security.Principal;
    using DndApi.Authentication.Services;
    using Nancy;
    using Nancy.Authentication.Stateless;
    using Nancy.Bootstrapper;
    using Nancy.TinyIoc;

    public class Bootstrapper : DefaultNancyBootstrapper

    {
        private readonly IAppConfiguration appConfig;

        public Bootstrapper()
        {
        }

        public Bootstrapper(IAppConfiguration appConfig)
        {
            this.appConfig = appConfig;
        }

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            var configuration =
                new StatelessAuthenticationConfiguration(nancyContext =>
                {
                    if (!nancyContext.Request.Query.apikey.HasValue)
                    {
                        return null;
                    }
                    var apiValidator =
                        container.Resolve<AuthenticationService>();

                    var application = apiValidator.ValidateApiKey(nancyContext.Request.Query.apikey);

                    return new ClaimsPrincipal(new GenericIdentity(application.AppName));
                });

            AllowAccessToConsumingSite(pipelines);

            StatelessAuthentication.Enable(pipelines, configuration);
        }

        static void AllowAccessToConsumingSite(IPipelines pipelines)
        {
            pipelines.AfterRequest.AddItemToEndOfPipeline(x =>
            {
                x.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                x.Response.Headers.Add("Access-Control-Allow-Methods", "POST,GET,DELETE,PUT,OPTIONS");
            });
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register(appConfig);
        }
    }
}
