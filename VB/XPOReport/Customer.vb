Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace XPOReport
	Public Class Customer
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _name As String
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _name, value)
			End Set
		End Property

		Private _age As Integer
		Public Property Age() As Integer
			Get
				Return _age
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("Age", _age, value)
			End Set
		End Property
	End Class
End Namespace