Imports Example1.Classes1

Public Class Form2
    Private BindingSource As New BindingSource
    Private Sub Binding1Button_Click(sender As Object, e As EventArgs) _
        Handles Binding1Button.Click

        Dim operations = New Example1.Classes1.FileOperations
        BindingSource.DataSource = operations.Read()
        BindingNavigator1.BindingSource = BindingSource


        Value1TextBox.DataBindings.Add("Text", BindingSource, "Value1")
    End Sub

    Private Sub SetCurrentValue1Button_Click(sender As Object, e As EventArgs) _
        Handles SetCurrentValue1Button.Click

        CType(BindingSource.Current, Item).Value1 = 2
        BindingSource.ResetCurrentItem()
    End Sub
End Class