Public Class frmmainreceptionist


    Private Sub btnpatview_Click(sender As Object, e As EventArgs) Handles btnpatview.Click
        MySqlWindowsFormsApplication5.frmpatient.Show()
        Me.Hide()
    End Sub

    Private Sub btndocview_Click(sender As Object, e As EventArgs) Handles btndocview.Click
        MySqlWindowsFormsApplication5.frmdoctor.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlWindowsFormsApplication5.frmcarriers.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySqlWindowsFormsApplication5.frmnurse.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MySqlWindowsFormsApplication5.frmaccountant.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MySqlWindowsFormsApplication5.frmward_boy.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MySqlWindowsFormsApplication5.frmdriver.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MySqlWindowsFormsApplication5.frmpayment.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MySqlWindowsFormsApplication5.frmambulance.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MySqlWindowsFormsApplication5.frmroom.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MySqlWindowsFormsApplication5.frmtest.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MySqlWindowsFormsApplication5.frmoperation.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MySqlWindowsFormsApplication5.frmmedication.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MySqlWindowsFormsApplication5.frmprescription.Show()
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

    

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MySqlWindowsFormsApplication5.frmappointment.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        MySqlWindowsFormsApplication5.frmadmission.Show()
        Me.Hide()
    End Sub
End Class