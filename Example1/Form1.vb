Imports Example1.LanguageExtensions

Public Class Form1
    Private BindingSource As New BindingSource
    Private Sub Binding1Button_Click(sender As Object, e As EventArgs) Handles Binding1Button.Click
        BindingNavigator1.BindingSource = Nothing

        Dim operations = New Example1.Classes.FileOperations

        Dim itemList = operations.Read()

        If Not String.IsNullOrWhiteSpace(IdentifierTextBox.Text) Then
            Dim singleItem = itemList.FirstOrDefault(Function(item) item.Id = CInt(IdentifierTextBox.Text))
            If singleItem IsNot Nothing Then

                BindingSource.DataSource = singleItem

            Else

                TextBoxList.ForEach(Sub(tb)
                                        tb.Text = ""
                                    End Sub)
                Exit Sub

            End If
        Else
            BindingNavigator1.BindingSource = BindingSource
            BindingSource.DataSource = itemList
        End If

        Value1TextBox.DataBindings.Clear()
        Value2TextBox.DataBindings.Clear()
        Value3TextBox.DataBindings.Clear()
        Value4TextBox.DataBindings.Clear()

        Value1TextBox.DataBindings.Add("Text", BindingSource, "Value1")
        Value2TextBox.DataBindings.Add("Text", BindingSource, "Value2")
        Value3TextBox.DataBindings.Add("Text", BindingSource, "Value3")
        Value4TextBox.DataBindings.Add("Text", BindingSource, "Value4")

    End Sub
    Private Sub IdentifierTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdentifierTextBox.KeyPress
        If (Not Char.IsControl(e.KeyChar)) AndAlso (Not Char.IsDigit(e.KeyChar))  Then
            e.Handled = True
        End If
    End Sub
End Class
