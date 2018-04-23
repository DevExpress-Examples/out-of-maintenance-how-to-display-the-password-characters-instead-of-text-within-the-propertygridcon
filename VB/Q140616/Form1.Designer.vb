Imports Microsoft.VisualBasic
Imports System
Namespace Q140616
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.passwordEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.passwordEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.passwordEdit})
			Me.propertyGridControl1.ServiceProvider = Nothing
			Me.propertyGridControl1.Size = New System.Drawing.Size(547, 296)
			Me.propertyGridControl1.TabIndex = 0
'			Me.propertyGridControl1.CustomRecordCellEdit += New DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventHandler(Me.OnCustomRecordCellEdit);
			' 
			' passwordEdit
			' 
			Me.passwordEdit.AutoHeight = False
			Me.passwordEdit.Name = "passwordEdit"
			Me.passwordEdit.PasswordChar = "*"c
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(547, 296)
			Me.Controls.Add(Me.propertyGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.passwordEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private passwordEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	End Class
End Namespace

