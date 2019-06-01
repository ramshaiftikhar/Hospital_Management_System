Public Class frmaccountantmain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlWindowsFormsApplication5.frmbillacc.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MySqlWindowsFormsApplication5.frmaccountantacc.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MySqlWindowsFormsApplication5.frmpaymentacc.Show()
        Me.Hide()
    End Sub

    Private Sub Cmdmain_Click(sender As Object, e As EventArgs) Handles Cmdmain.Click
        MySqlWindowsFormsApplication4.frmMain.Show()
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