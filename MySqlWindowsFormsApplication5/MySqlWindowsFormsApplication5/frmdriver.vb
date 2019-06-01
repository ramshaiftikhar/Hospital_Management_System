' ++++++++++++++++++++++++++++++++++++++++++++++++++
' This code is generated by a tool and is provided "as is", without warranty of any kind,
' express or implied, including but not limited to the warranties of merchantability,
' fitness for a particular purpose and non-infringement.
' In no event shall the authors or copyright holders be liable for any claim, damages or
' other liability, whether in an action of contract, tort or otherwise, arising from,
' out of or in connection with the software or the use or other dealings in the software.
' ++++++++++++++++++++++++++++++++++++++++++++++++++
' 

Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Namespace MySqlWindowsFormsApplication5
	
	Public Class frmdriver
		
		Private ad As MySqlDataAdapter
		
		Private Sub frmdriver_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=localhost;user id=root;database=hospital;password=fus939597;persistsecurityinfo=True;allowuservariables=True;"
			ad = New MySqlDataAdapter("select * from `driver`", strConn)
			Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
			ad.Fill(Me.newDataSet.driver)
			ad.DeleteCommand = builder.GetDeleteCommand()
			ad.UpdateCommand = builder.GetUpdateCommand()
			ad.InsertCommand = builder.GetInsertCommand()
			Dim ad3 As MySqlDataAdapter
		End Sub
		
		Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
			If Not Me.Validate() Then
				Return
			End If
			driverBindingSource.EndEdit()
			ad.Update(Me.newDataSet.driver)
		End Sub
		
		Private Sub frmdriver_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = False
		End Sub
		
        Private Sub Driver_IDTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Driver_IDTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Driver_IDTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Driver_IDTextBox, "The field Driver_ID is required")
            End If
            Dim v As Integer
            Dim s As String = Driver_IDTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(Driver_IDTextBox, "The field Driver_ID must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Driver_IDTextBox, "")
            End If
        End Sub
		
        Private Sub Driver_nameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Driver_nameTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Driver_nameTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Driver_nameTextBox, "The field Driver_name is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Driver_nameTextBox, "")
            End If
        End Sub
		
        Private Sub Mob_numTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Mob_numTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Mob_numTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Mob_numTextBox, "The field Mob_num is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Mob_numTextBox, "")
            End If
        End Sub
		
        Private Sub AddressTextBox_Validating(sender As Object, e As CancelEventArgs) Handles AddressTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(AddressTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(AddressTextBox, "The field Address is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(AddressTextBox, "")
            End If
        End Sub
		
        Private Sub SalaryTextBox_Validating(sender As Object, e As CancelEventArgs) Handles SalaryTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(SalaryTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(SalaryTextBox, "The field Salary is required")
            End If
            Dim v As Integer
            Dim s As String = SalaryTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(SalaryTextBox, "The field Salary must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(SalaryTextBox, "")
            End If
        End Sub
		
        Private Sub ShiftTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ShiftTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(ShiftTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(ShiftTextBox, "The field Shift is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(ShiftTextBox, "")
            End If
            Dim s As String = ShiftTextBox.Text()
            If s <> "night" And s <> "morning" And s <> "afternoon" Then
                e.Cancel = True
                ErrorProvider1.SetError(ShiftTextBox, "The shift can only be of morning, afternoon or night.")
            Else
                e.Cancel = False
                ErrorProvider1.SetError(ShiftTextBox, "")
            End If
        End Sub
		
		
        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
            driverBindingSource.AddNew()
        End Sub
        Private Sub Cmdmain_Click(sender As Object, e As EventArgs) Handles Cmdmain.Click
            frmmainreceptionist.Show()
            Me.Hide()
        End Sub
        Private Sub Cmdend_Click(sender As Object, e As EventArgs) Handles Cmdend.Click
            Dim response As String
            response = MsgBox("Do you want to close?", MsgBoxStyle.YesNoCancel) 'a message will be displayed and answer will be stored as string variable
            If response = vbYes Then 'use of selection programming structure
                Me.Close()
            End If
        End Sub
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            driverBindingSource.MoveNext()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            driverBindingSource.MovePrevious()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            driverBindingSource.MoveFirst()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            driverBindingSource.MoveLast()
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
            ad.Update(Me.newDataSet.driver)
        End Sub

        Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
            driverBindingSource.AddNew()
        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
            driverBindingSource.RemoveCurrent()
        End Sub

        Private Sub ShiftTextBox_TextChanged(sender As Object, e As EventArgs) Handles ShiftTextBox.TextChanged

        End Sub
    End Class
	
End Namespace