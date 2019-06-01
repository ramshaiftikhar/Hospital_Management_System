Public Class Form1
    Private Sub Cmdmain_Click(sender As Object, e As EventArgs) Handles Cmdmain.Click
        frmmainguest.Show()
        Me.Hide()
    End Sub
    Private Sub Cmdend_Click(sender As Object, e As EventArgs) Handles Cmdend.Click
        Dim response As String
        response = MsgBox("Do you want to close?", MsgBoxStyle.YesNoCancel) 'a message will be displayed and answer will be stored as string variable
        If response = vbYes Then 'use of selection programming structure
            Me.Close()
        End If
    End Sub
End Class