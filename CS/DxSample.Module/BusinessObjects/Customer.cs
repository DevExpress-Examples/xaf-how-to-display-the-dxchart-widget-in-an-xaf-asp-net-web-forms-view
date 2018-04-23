using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.ComponentModel;

namespace DxSample.Module.BusinessObjects {
    [NavigationItem]
    [DefaultProperty("FullName")]
    public class Customer : BaseObject {
        public Customer(Session session) : base(session) { }

        public string FirstName {
            get { return GetPropertyValue<string>("FirstName"); }
            set { SetPropertyValue<string>("FirstName", value); }
        }

        public string LastName {
            get { return GetPropertyValue<string>("LastName"); }
            set { SetPropertyValue<string>("LastName", value); }
        }

        public string Country {
            get { return GetPropertyValue<string>("Country"); }
            set { SetPropertyValue<string>("Country", value); }
        }

        [PersistentAlias("concat(FirstName, ' ', LastName)")]
        public string FullName {
            get { return (string)EvaluateAlias("FullName"); }
        }
    }
}