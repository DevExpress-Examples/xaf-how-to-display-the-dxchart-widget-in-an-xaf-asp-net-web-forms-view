Imports System
Imports System.Linq
Imports System.Web.UI
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Web
Imports DxSample.Module.BusinessObjects

Namespace DxSample.Web
	Partial Public Class OrdersChart
		Inherits UserControl
		Implements IComplexControl

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim url As String = Me.ResolveClientUrl("~/Scripts/Controls/orders-chart.js")
			WebWindow.CurrentRequestWindow.RegisterClientScriptInclude("orders-chart", url)
		End Sub

		Private Function GetChartData(ByVal objectSpace As IObjectSpace) As Object
			Dim countriesToDisplay() As String = { "Germany", "Mexico", "UK" }
			Return objectSpace.GetObjectsQuery(Of Order)().Where(Function(o) countriesToDisplay.Contains(o.Customer.Country)).ToArray().GroupBy(Function(o) New With {Key .date = New Date(o.OrderDate.Year, o.OrderDate.Month, 1), Key .country = o.Customer.Country}).Select(Function(og) New With {Key .arg = og.Key.date, Key .val = og.Sum(Function(o) o.UnitPrice), Key .series = og.Key.country}).ToArray()
		End Function

		#Region "IComplexControl Members"

		Private Sub IComplexControl_Refresh() Implements IComplexControl.Refresh
		End Sub

		Private Sub IComplexControl_Setup(ByVal objectSpace As IObjectSpace, ByVal application As XafApplication) Implements IComplexControl.Setup
			Me.ASPxPanel1.JSProperties.Add("cpChartData", Me.GetChartData(objectSpace))
		End Sub

		#End Region
	End Class
End Namespace