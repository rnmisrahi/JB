
Partial Class Default_aspx
    Inherits System.Web.UI.Page

    Protected Sub lstFormat_SelectedIndexChanged( _
       ByVal sender As System.Object, _
       ByVal e As System.EventArgs)
        ValSum.DisplayMode = _
           CType(lstFormat.SelectedIndex, _
              ValidationSummaryDisplayMode)
    End Sub
    Protected Sub lstDisplay_SelectedIndexChanged( _
         ByVal sender As System.Object, _
         ByVal e As System.EventArgs)
        If lstDisplay.SelectedIndex = 0 Then
            ValSum.ShowSummary = True
            ValSum.ShowMessageBox = False
        Else
            ValSum.ShowSummary = False
            ValSum.ShowMessageBox = True
        End If
    End Sub


    Protected Sub Page_Load( _
    ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles Me.Load
        lstFormat_SelectedIndexChanged(sender, e)
        lstDisplay_SelectedIndexChanged(sender, e)
    End Sub
End Class