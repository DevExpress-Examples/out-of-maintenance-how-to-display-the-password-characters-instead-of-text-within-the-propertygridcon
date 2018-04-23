Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid.Events
Imports DevExpress.XtraVerticalGrid
Imports System.Reflection
Imports DXSample

Namespace Q140616
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			propertyGridControl1.SelectedObject = New CustomObject("My Custom Object", "myGOODpassword")
		End Sub

		Private Sub OnCustomRecordCellEdit(ByVal sender As Object, ByVal e As GetCustomRowCellEditEventArgs) Handles propertyGridControl1.CustomRecordCellEdit
			Dim control As PropertyGridControl = CType(sender, PropertyGridControl)
			Dim mi() As MemberInfo = control.SelectedObject.GetType().GetMember(e.Row.Properties.FieldName)
			Dim attr As PasswordPropertyTextAttribute = CType(Attribute.GetCustomAttribute(mi(0), GetType(PasswordPropertyTextAttribute)), PasswordPropertyTextAttribute)
			If attr IsNot Nothing AndAlso attr.Password Then
				e.RepositoryItem = passwordEdit
			End If
		End Sub
	End Class
End Namespace