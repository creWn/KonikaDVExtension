using DocsVision.BackOffice.ObjectModel;
using DocsVision.BackOffice.ObjectModel.Mapping;
using DocsVision.BackOffice.ObjectModel.Services;
using DocsVision.Platform.Data.Metadata;
using DocsVision.Platform.ObjectManager;
using DocsVision.Platform.ObjectModel;
using DocsVision.Platform.ObjectModel.Mapping;
using DocsVision.Platform.ObjectModel.Persistence;
using DocsVision.Platform.SystemCards.ObjectModel.Mapping;
using DocsVision.Platform.SystemCards.ObjectModel.Services;

using WebApplication.Models;
using WebApplication.ObjectModel;

namespace WebApplication.Services
{
    public class SessionService
    {
        public UserSession CreateSession(AuthorizationModel authorization)
        {
             return CreateSession($"ConnectAddress={authorization.Address};Username={authorization.UserName};Password={authorization.Password}");
        }

        private UserSession CreateSession(string address)
        {
            SessionManager sessionManager = SessionManager.CreateInstance();
            sessionManager.Connect(address);
            return sessionManager.CreateSession();
        }

        public ObjectContext GetObjectContext(UserSession userSession)
        {                          
            var sessionContainer = new System.ComponentModel.Design.ServiceContainer();
            sessionContainer.AddService(typeof(UserSession), userSession);

            var objectContext = new ObjectContext(sessionContainer);

            IObjectMapperFactoryRegistry mapperFactoryRegistry = objectContext.GetService<IObjectMapperFactoryRegistry>();
            mapperFactoryRegistry.RegisterFactory(typeof(SystemCardsMapperFactory));
            mapperFactoryRegistry.RegisterFactory(typeof(BackOfficeMapperFactory));
            mapperFactoryRegistry.RegisterFactory(typeof(MyTypeMapperFactory));

            IServiceFactoryRegistry serviceFactoryRegistry = objectContext.GetService<IServiceFactoryRegistry>();
            serviceFactoryRegistry.RegisterFactory(typeof(SystemCardsServiceFactory));
            serviceFactoryRegistry.RegisterFactory(typeof(BackOfficeServiceFactory));

            objectContext.AddService(DocsVisionObjectFactory.CreatePersistentStore(new SessionProvider(userSession), null));

            IMetadataProvider metadataProvider = DocsVisionObjectFactory.CreateMetadataProvider(userSession);
            objectContext.AddService(DocsVisionObjectFactory.CreateMetadataManager(metadataProvider, userSession));
            objectContext.AddService(metadataProvider);

            return objectContext;
        }
    }
}