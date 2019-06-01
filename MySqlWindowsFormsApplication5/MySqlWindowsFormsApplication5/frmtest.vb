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
	
	Public Class frmtest
		
		Private ad As MySqlDataAdapter
		
		Private Sub frmtest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = "port=3306;server=localhost;user id=root;database=hospital;password=fus939597;persistsecurityinfo=True;allowuservariables=True;"
			ad = New MySqlDataAdapter("select * from `test`", strConn)
			Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
			ad.Fill(Me.newDataSet.test)
			ad.DeleteCommand = builder.GetDeleteCommand()
			ad.UpdateCommand = builder.GetUpdateCommand()
			ad.InsertCommand = builder.GetInsertCommand()
			Dim ad3 As MySqlDataAdapter
		End Sub
		
		Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
			If Not Me.Validate() Then
				Return
			End If
			If TypeOf( CType(testBindingSource.Current, DataRowView )( "Date" ) ) Is DBNull Then 
				CType(testBindingSource.Current, DataRowView )("Date") = Date_dateTimePicker.Value
			End If
			If TypeOf( CType(testBindingSource.Current, DataRowView )( "Rep_Date" ) ) Is DBNull Then 
				CType(testBindingSource.Current, DataRowView )("Rep_Date") = Rep_Date_dateTimePicker.Value
			End If
			testBindingSource.EndEdit()
			ad.Update(Me.newDataSet.test)
		End Sub
		
		Private Sub frmtest_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = False
		End Sub
		
        Private Sub Test_IDTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Test_IDTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Test_IDTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Test_IDTextBox, "The field Test_ID is required")
            End If
            Dim v As Integer
            Dim s As String = Test_IDTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(Test_IDTextBox, "The field Test_ID must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Test_IDTextBox, "")
            End If
        End Sub
		
        Private Sub Test_NameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles Test_NameTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(Test_NameTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(Test_NameTextBox, "The field Test_Name is required")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(Test_NameTextBox, "")
            End If
        End Sub
		
        Private Sub FeeTextBox_Validating(sender As Object, e As CancelEventArgs) Handles FeeTextBox.Validating

            e.Cancel = False
            If String.IsNullOrEmpty(FeeTextBox.Text) Then
                e.Cancel = True
                ErrorProvider1.SetError(FeeTextBox, "The field Fee is required")
            End If
            Dim v As Integer
            Dim s As String = FeeTextBox.Text
            If Not Integer.TryParse(s, v) Then
                e.Cancel = True
                ErrorProvider1.SetError(FeeTextBox, "The field Fee must be Integer.")
            End If
            If Not e.Cancel Then
                ErrorProvider1.SetError(FeeTextBox, "")
            End If
        End Sub
		
		
        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
            testBindingSource.AddNew()
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
            testBindingSource.MoveNext()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            testBindingSource.MovePrevious()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            testBindingSource.MoveFirst()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            testBindingSource.MoveLast()
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
            ad.Update(Me.newDataSet.test)
        End Sub

        Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
            testBindingSource.AddNew()
        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
            testBindingSource.RemoveCurrent()
        End Sub
	End Class
	
End Namespace