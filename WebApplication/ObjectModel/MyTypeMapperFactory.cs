using DocsVision.Platform.ObjectModel;
using DocsVision.Platform.ObjectModel.Mapping;

namespace WebApplication.ObjectModel
{
    public class MyTypeMapperFactory : ObjectMapperFactory
    {
        public MyTypeMapperFactory(ObjectContext context) : base(context)
        {
            RegisterObjectMapper(typeof(MyTypeMainSection), typeof(MyTypeMainSectionMapper));
            RegisterObjectMapper(typeof(MyTypeCard), typeof(MyTypeCardMapper));
        }
    }
}