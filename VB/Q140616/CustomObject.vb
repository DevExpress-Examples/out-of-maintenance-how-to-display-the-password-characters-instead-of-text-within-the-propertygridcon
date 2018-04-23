Imports Microsoft.VisualBasic
Imports System.ComponentModel
Namespace DXSample
	Public Class CustomObject
		Public Sub New(ByVal name As String, ByVal password As String)
			Me.Name = name
			Me.password_Renamed = password
		End Sub
		Private name_Renamed As String
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
		Private password_Renamed As String
		<PasswordPropertyTextAttribute(True)> _
		Public Property Password() As String
			Get
				Return password_Renamed
			End Get
			Set(ByVal value As String)
				password_Renamed = value
			End Set
		End Property
	End Class
End Namespace