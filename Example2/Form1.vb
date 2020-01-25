Imports Example2.Classes

Public Class Form1
    Private BindingSource As BindingSource = New BindingSource()
    Private Async Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim operations = New DataOperations
        If Await operations.TestConnection() Then
            Dim customerList = Await operations.CustomersByGenderStoredProcedureAsync(1)

            BindingSource.DataSource = customerList

            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = BindingSource
        Else
            MessageBox.Show("Connection failed, check DatabaseServer setting in new constructor")
        End If


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class
