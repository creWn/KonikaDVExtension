using System.Linq;

using DocsVision.Platform.ObjectModel;

namespace WebApplication.ObjectModel
{
    public class MyTypeCard : ObjectBase
    {
        public static readonly ObjectProperty MainSectionProperty;

        public MyTypeMainSection MainSection
        {
            get
            {
                if (((ObjectCollection<MyTypeMainSection>)base.GetValue(MainSectionProperty)).Count == 0)
                {
                    ((ObjectCollection<MyTypeMainSection>)base.GetValue(MainSectionProperty)).Add(new MyTypeMainSection());
                }
                return ((ObjectCollection<MyTypeMainSection>)base.GetValue(MainSectionProperty)).First<MyTypeMainSection>();
            }
        }


        static MyTypeCard()
        {
            MainSectionProperty = ObjectProperty.Register("MainSection", typeof(ObjectCollection<MyTypeMainSection>), typeof(MyTypeCard));
        }

        protected internal MyTypeCard()
        {
        }
        protected internal MyTypeCard(ObjectInitializationData data) : base(data)
        {
        }
    }
}