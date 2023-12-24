using System;

using DocsVision.Platform.ObjectModel;
using DocsVision.Platform.ObjectModel.Mapping;

namespace WebApplication.ObjectModel
{
    public class MyTypeCardMapper : CardMapper<MyTypeCard>
    {
        private static ObjectMap map;
        static MyTypeCardMapper()
        {
            InitializeObjectMap();
        }
        public MyTypeCardMapper(ObjectContext context) : base(context)
        {
        }
        protected override ObjectMap GetObjectMap()
        {
            return map;
        }
        protected override MyTypeCard CreateObject(ObjectInitializationData data)
        {
            return new MyTypeCard(data);
        }
        private static void InitializeObjectMap()
        {
            map = new ObjectMap();
            map.ObjectTypeId = new Guid("B130D3AD-182A-4B3B-B259-2C33AAF5BEAA");
            map.Collection(MyTypeCard.MainSectionProperty, new Guid("E639044E-C46B-47E0-AF26-945FA6512587"));
        }
    }
}