﻿Public Class frmmainguest

    Private Sub btndocview_Click(sender As Object, e As EventArgs) Handles btndocview.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MySqlWindowsFormsApplication5.frmdoctorguest.Show()
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

    Private Sub frmmaincarrier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class