Imports Example1.LanguageExtensions

Namespace Classes1
    Public Class Item

        Public Sub New()

        End Sub
        Public Sub New(line As String)
            Dim parts = line.Split(","c).ToIntegerArray()
            If parts.Length = 4 Then
                Value1 = parts(0)
                Value2 = parts(1)
                Value3 = parts(2)
                Value4 = parts(3)
            End If
        End Sub

        Public Property Value1() As Integer
        Public Property Value2() As Integer
        Public Property Value3() As Integer
        Public Property Value4() As Integer
    End Class

End Namespace