using System;

using DocsVision.Platform.ObjectModel;

namespace WebApplication.ObjectModel
{
    public class MyTypeMainSection : ObjectBase
    {
        public static readonly ObjectProperty DocKindProperty;
        public static readonly ObjectProperty DocNumberProperty;
        public static readonly ObjectProperty CreationDateProperty;
        public static readonly ObjectProperty MainAccountProperty;
        public static readonly ObjectProperty CorrespondentAccountProperty;
        public static readonly ObjectProperty PartnerCodeProperty;
        public static readonly ObjectProperty OrderNumberProperty;
        public static readonly ObjectProperty ExtraInfoProperty;
        public static readonly ObjectProperty WarehouseProperty;
        public static readonly ObjectProperty ShortContentProperty;
        public static readonly ObjectProperty ProvidingNumberProperty;
        public static readonly ObjectProperty LoadDateProperty;
        public static readonly ObjectProperty AttachmentProperty;

        public string DocKind
        {
            set { SetValue(DocKindProperty, value); }
        }
        public string DocNumber
        {
            set { SetValue(DocNumberProperty, value); }
        }
        public DateTime? CreationDate
        {
            set { SetValue(CreationDateProperty, value); }
        }
        public int? MainAccount
        {
            set { SetValue(MainAccountProperty, value); }
        }
        public int? CorrespondentAccount
        {
            set { SetValue(CorrespondentAccountProperty, value); }
        }
        public string PartnerCode
        {
            set { SetValue(PartnerCodeProperty, value); }
        }
        public int? OrderNumber
        {
            set { SetValue(OrderNumberProperty, value); }
        }
        public string ExtraInfo
        {
            set { SetValue(ExtraInfoProperty, value); }
        }
        public int? Warehouse
        {
            set { SetValue(WarehouseProperty, value); }
        }
        public string ShortContent
        {
            set { SetValue(ShortContentProperty, value); }
        }
        public string ProvidingNumber
        {
            set { SetValue(ProvidingNumberProperty, value); }
        }
        public DateTime? LoadDate
        {
            set { SetValue(LoadDateProperty, value); }
        }
        public Guid Attachment
        {
            set { SetValue(AttachmentProperty, value); }
        }


        static MyTypeMainSection()
        {
            DocKindProperty = ObjectProperty.Register("DocKind", typeof(string), typeof(MyTypeMainSection));
            DocNumberProperty = ObjectProperty.Register("DocNumber", typeof(string), typeof(MyTypeMainSection));
            CreationDateProperty = ObjectProperty.Register("CreationDate", typeof(string), typeof(MyTypeMainSection));
            MainAccountProperty = ObjectProperty.Register("MainAccount", typeof(string), typeof(MyTypeMainSection));
            CorrespondentAccountProperty = ObjectProperty.Register("CorrespondentAccount", typeof(string), typeof(MyTypeMainSection));
            PartnerCodeProperty = ObjectProperty.Register("PartnerCode", typeof(string), typeof(MyTypeMainSection));
            OrderNumberProperty = ObjectProperty.Register("OrderNumber", typeof(string), typeof(MyTypeMainSection));
            ExtraInfoProperty = ObjectProperty.Register("ExtraInfo", typeof(string), typeof(MyTypeMainSection));
            WarehouseProperty = ObjectProperty.Register("Warehouse", typeof(string), typeof(MyTypeMainSection));
            ShortContentProperty = ObjectProperty.Register("ShortContent", typeof(string), typeof(MyTypeMainSection));
            ProvidingNumberProperty = ObjectProperty.Register("ProvideingNumber", typeof(string), typeof(MyTypeMainSection));
            LoadDateProperty = ObjectProperty.Register("LoadDate", typeof(string), typeof(MyTypeMainSection));
            AttachmentProperty = ObjectProperty.Register("Attachment", typeof(string), typeof(MyTypeMainSection));
    }

        internal MyTypeMainSection()
        {
        }

        internal MyTypeMainSection(ObjectInitializationData data) : base(data)
        {
        }
    }
}