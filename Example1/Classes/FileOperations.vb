Imports System.IO

Namespace Classes
    Public Class FileOperations
        Public Function Read() As List(Of Item)

            Dim lines = File.ReadAllLines("TextFile1.txt").Where(
                Function(line)
                    Dim parts = line.Split(","c)
                    If line.Length > 0 AndAlso parts.Length = 5 Then
                        Return True
                    Else
                        Return False
                    End If

                End Function).Select(Function(fileItem) new Item(fileItem) )

            Return lines.ToList()

        End Function
    End Class
End Namespace