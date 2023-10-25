using System;
using System.Linq;
using System.Web.UI;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Web;
using DxSample.Module.BusinessObjects;

namespace WebChart.Web {
    public partial class OrdersChart : UserControl, IComplexControl {
        protected void Page_Load(object sender, EventArgs e) {
            string url = this.ResolveClientUrl("~/Scripts/Controls/orders-chart.js");
            WebWindow.CurrentRequestWindow.RegisterClientScriptInclude("orders-chart", url); 
        }

        private object GetChartData(IObjectSpace objectSpace) {
            string[] countriesToDisplay = new string[] { "Germany", "Mexico", "UK" };
            return objectSpace.GetObjectsQuery<Order>()
                .Where(o => countriesToDisplay.Contains(o.Customer.Country))
                .ToArray()
                .GroupBy(o => new
                {
                    date = new DateTime(o.OrderDate.Year, o.OrderDate.Month, 1),
                    country = o.Customer.Country
                })
                .Select(og => new
                {
                    arg = og.Key.date,
                    val = og.Sum(o => o.UnitPrice),
                    series = og.Key.country
                })
                .ToArray();
        }

        #region IComplexControl Members

        void IComplexControl.Refresh() {
        }

        void IComplexControl.Setup(IObjectSpace objectSpace, XafApplication application) {
            this.ASPxPanel1.JSProperties.Add("cpChartData", this.GetChartData(objectSpace));
        }

        #endregion
    }
}