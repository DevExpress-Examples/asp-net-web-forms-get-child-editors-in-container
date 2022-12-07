Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim l As New List(Of ASPxEdit)()
		ASPxGridView1.DataBind()
		'l = HelperClass.GetChildControls(ASPxGridView1,k=>k.NamingContainer is GridViewDataItemTemplateContainer);             
	End Sub

	Protected Sub ASPxButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim b As ASPxButton = TryCast(sender, ASPxButton)
		Dim s As String = b.ID(b.ID.Length - 1).ToString()
		 Dim l As New List(Of ASPxEdit)()
		Select Case s
			Case "1"
			   l = HelperClass.GetChildControls(ASPxPageControl1)
			Case "2"
                l = HelperClass.GetChildControls(ASPxGridView1, Function(k) F(k))
			Case "3"
				l = HelperClass.GetChildControls(ASPxPanel1)
		End Select
		CType(Me.FindControl("ASPxLabel" & s), ASPxLabel).Text = l.Count.ToString()
	End Sub
    Private Function F(ByVal k As Control) As Boolean
        If TypeOf k.NamingContainer Is GridViewDataItemTemplateContainer Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
