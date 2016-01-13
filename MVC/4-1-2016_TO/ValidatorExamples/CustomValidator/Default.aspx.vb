
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
    Protected Sub ServerEvenValidate(ByVal source As Object, _
                    ByVal e As ServerValidateEventArgs)
        Dim evenNumber As Int32 = Int32.Parse(e.Value)

        If evenNumber Mod 2 = 0 Then
            e.IsValid = True
        Else
            e.IsValid = False
        End If

    End Sub


    Protected Sub Page_Load( _
    ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles Me.Load
        lstFormat_SelectedIndexChanged(sender, e)
        lstDisplay_SelectedIndexChanged(sender, e)
    End Sub
End Class