Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls



Public NotInheritable Class HelperClass
	Private Sub New()
	End Sub
	Public Shared Function GetChildControls(ByVal container As Object, ByVal predicate As Func(Of Control, Boolean)) As List(Of ASPxEdit)
		Return GetChildControls(container, New List(Of ASPxEdit)(), predicate)
	End Function
	Public Shared Function GetChildControls(ByVal container As Object) As List(Of ASPxEdit)
		Return GetChildControls(container, New List(Of ASPxEdit)(), Nothing)
	End Function
	Private Shared Function GetChildControls(ByVal Container As Object, ByVal controlsList As List(Of ASPxEdit), ByVal predicate As Func(Of Control, Boolean)) As List(Of ASPxEdit)
		Dim c As Control = TryCast(Container, Control)
		If c Is Nothing OrElse c.Controls.Count = 0 Then
			Return controlsList
		End If
		For Each item As Control In c.Controls
			If TypeOf item Is ASPxEdit AndAlso (predicate Is Nothing OrElse predicate(item) = True) Then
				controlsList.Add(CType(item, ASPxEdit))
			End If
			If item.Controls.Count > 0 Then
				controlsList = GetChildControls(item, controlsList, predicate)
			End If
		Next item
		Return controlsList
	End Function
End Class