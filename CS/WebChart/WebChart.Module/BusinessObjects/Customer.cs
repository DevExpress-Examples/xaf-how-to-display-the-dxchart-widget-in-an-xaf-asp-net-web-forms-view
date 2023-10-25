using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.ComponentModel;

namespace DxSample.Module.BusinessObjects {
  [DefaultClassOptions]
    [DefaultProperty(nameof(FullName))]
    public class Customer : BaseObject {
        public Customer(Session session) : base(session) { }

        public string FirstName {
            get { return GetPropertyValue<string>(nameof(FirstName)); }
            set { SetPropertyValue<string>(nameof(FirstName), value); }
        }

        public string LastName {
            get { return GetPropertyValue<string>(nameof(LastName)); }
            set { SetPropertyValue<string>(nameof(LastName), value); }
        }

        public string Country {
            get { return GetPropertyValue<string>(nameof(Country)); }
            set { SetPropertyValue<string>(nameof(Country), value); }
        }

        [PersistentAlias("concat(FirstName, ' ', LastName)")]
        public string FullName {
            get { return (string)EvaluateAlias(nameof(FullName)); }
        }
    }
}