Public Class frmmaindoctor


    Private Sub btnpatview_Click(sender As Object, e As EventArgs) Handles btnpatview.Click
        MySqlWindowsFormsApplication5.frmpatientdoc.Show()
        Me.Hide()
    End Sub

    Private Sub btndocview_Click(sender As Object, e As EventArgs) Handles btndocview.Click
        MySqlWindowsFormsApplication5.frmdoctordoc.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmcarriers.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmnurse.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmaccountant.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmward_boy.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmdriver.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmpayment.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmambulance.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmroom.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MySqlWindowsFormsApplication5.frmtestdoc.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MySqlWindowsFormsApplication5.frmoperationdoc.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MySqlWindowsFormsApplication5.frmmedicationdoc.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MySqlWindowsFormsApplication5.frmprescriptiondoc.Show()
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



    Private Sub Button15_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmappointment.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        MySqlWindowsFormsApplication5.frmadmission.Show()
        Me.Hide()
    End Sub
End Class