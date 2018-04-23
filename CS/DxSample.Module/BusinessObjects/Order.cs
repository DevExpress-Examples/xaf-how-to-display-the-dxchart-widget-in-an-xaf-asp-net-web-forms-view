using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.ComponentModel;
using System;

namespace DxSample.Module.BusinessObjects {
    [NavigationItem]
    [DefaultProperty("Customer")]
    public class Order : BaseObject {
        public Order(Session session) : base(session) { }

        public DateTime OrderDate {
            get { return GetPropertyValue<DateTime>("OrderDate"); }
            set { SetPropertyValue<DateTime>("OrderDate", value); }
        }

        public decimal UnitPrice {
            get { return GetPropertyValue<decimal>("UnitPrice"); }
            set { SetPropertyValue<decimal>("UnitPrice", value); }
        }

        public Customer Customer {
            get { return GetPropertyValue<Customer>("Customer"); }
            set { SetPropertyValue<Customer>("Customer", value); }
        }
    }
}