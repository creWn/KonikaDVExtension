using System;

using DocsVision.Platform.ObjectModel;
using DocsVision.Platform.ObjectModel.Mapping;

namespace WebApplication.ObjectModel
{
    public class MyTypeMainSectionMapper : CardRowMapper<MyTypeMainSection>
    {
        private static ObjectMap map;

        static MyTypeMainSectionMapper()
        {
            InitializeObjectMap();
        }

        public MyTypeMainSectionMapper(ObjectContext context) : base(context)
        {
        }

        protected override ObjectMap GetObjectMap()
        {
            return map;
        }

        protected override MyTypeMainSection CreateObject(ObjectInitializationData data)
        {
            return new MyTypeMainSection(data);
        }

        private static void InitializeObjectMap()
        {
            map = new ObjectMap();
            map.ObjectTypeId = new Guid("E639044E-C46B-47E0-AF26-945FA6512587");
            map.Field(MyTypeMainSection.DocKindProperty, "DocKind");
            map.Field(MyTypeMainSection.DocNumberProperty, "DocNumber");
            map.Field(MyTypeMainSection.ExtraInfoProperty, "ExtraInfo");
            map.Field(MyTypeMainSection.MainAccountProperty, "MainAccount");
            map.Field(MyTypeMainSection.LoadDateProperty, "LoadDate");
            map.Field(MyTypeMainSection.AttachmentProperty, "Attachment");
            map.Field(MyTypeMainSection.CorrespondentAccountProperty, "CorrespondentAccount");
            map.Field(MyTypeMainSection.CreationDateProperty, "CreationDate");
            map.Field(MyTypeMainSection.OrderNumberProperty, "OrderNumber");
            map.Field(MyTypeMainSection.WarehouseProperty, "Warehouse");
            map.Field(MyTypeMainSection.ShortContentProperty, "ShortContent");
            map.Field(MyTypeMainSection.ProvidingNumberProperty, "ProvideingNumber");
            map.Field(MyTypeMainSection.PartnerCodeProperty, "PartnerCode");
        }
    }
}