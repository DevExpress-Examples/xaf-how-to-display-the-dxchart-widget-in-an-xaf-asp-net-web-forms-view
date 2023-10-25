using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System.ComponentModel;
using System;

namespace DxSample.Module.BusinessObjects {
    [DefaultClassOptions]
    [DefaultProperty(nameof(Customer))]
    public class Order : BaseObject {
        public Order(Session session) : base(session) { }

        public DateTime OrderDate {
            get { return GetPropertyValue<DateTime>(nameof(OrderDate)); }
            set { SetPropertyValue<DateTime>(nameof(OrderDate), value); }
        }

        public decimal UnitPrice {
            get { return GetPropertyValue<decimal>(nameof(UnitPrice)); }
            set { SetPropertyValue<decimal>(nameof(UnitPrice), value); }
        }

        public Customer Customer {
            get { return GetPropertyValue<Customer>(nameof(Customer)); }
            set { SetPropertyValue<Customer>(nameof(Customer), value); }
        }
    }
}