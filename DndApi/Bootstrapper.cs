namespace DndApi.Api
{
    using System.Security.Claims;
    using System.Security.Principal;
    using Nancy;
    using Nancy.Authentication.Stateless;
    using Nancy.Bootstrapper;
    using Nancy.TinyIoc;
    using Services.Authentication;

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
            // At request startup we modify the request pipelines to
            // include stateless authentication
            //
            // Configuring stateless authentication is simple. Just use the
            // NancyContext to get the apiKey. Then, use the apiKey to get
            // your user's identity.
            var configuration =
                new StatelessAuthenticationConfiguration(nancyContext =>
                {
                    if (!nancyContext.Request.Query.apikey.HasValue)
                    {
                        return null;
                    }

                    // This would where you authenticated the request. IUserApiMapper is
                    // not a Nancy type.
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
