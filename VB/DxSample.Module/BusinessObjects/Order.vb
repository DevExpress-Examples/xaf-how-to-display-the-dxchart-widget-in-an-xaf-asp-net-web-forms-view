Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports System

Namespace DxSample.Module.BusinessObjects
	<NavigationItem, DefaultProperty("Customer")>
	Public Class Order
		Inherits BaseObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Property OrderDate() As Date
			Get
				Return GetPropertyValue(Of Date)("OrderDate")
			End Get
			Set(ByVal value As Date)
				SetPropertyValue(Of Date)("OrderDate", value)
			End Set
		End Property

		Public Property UnitPrice() As Decimal
			Get
				Return GetPropertyValue(Of Decimal)("UnitPrice")
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(Of Decimal)("UnitPrice", value)
			End Set
		End Property

		Public Property Customer() As Customer
			Get
				Return GetPropertyValue(Of Customer)("Customer")
			End Get
			Set(ByVal value As Customer)
				SetPropertyValue(Of Customer)("Customer", value)
			End Set
		End Property
	End Class
End Namespace