Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports System.ComponentModel

Namespace DxSample.Module.BusinessObjects
	<NavigationItem, DefaultProperty("FullName")>
	Public Class Customer
		Inherits BaseObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Property FirstName() As String
			Get
				Return GetPropertyValue(Of String)("FirstName")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("FirstName", value)
			End Set
		End Property

		Public Property LastName() As String
			Get
				Return GetPropertyValue(Of String)("LastName")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("LastName", value)
			End Set
		End Property

		Public Property Country() As String
			Get
				Return GetPropertyValue(Of String)("Country")
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Country", value)
			End Set
		End Property

		<PersistentAlias("concat(FirstName, ' ', LastName)")>
		Public ReadOnly Property FullName() As String
			Get
				Return DirectCast(EvaluateAlias("FullName"), String)
			End Get
		End Property
	End Class
End Namespace