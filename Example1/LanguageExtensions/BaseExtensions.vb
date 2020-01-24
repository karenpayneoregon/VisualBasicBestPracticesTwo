Namespace LanguageExtensions
    Public Module BaseExtensions
        ''' <summary>
        ''' Provides access to all controls on a form including
        ''' controls within containers e.g. panel and group-box etc.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="control"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Iterator Function Descendants(Of T As Class)(control As Control) As IEnumerable(Of T)
            For Each child As Control In control.Controls

                Dim currentChild = TryCast(child, T)
                If currentChild IsNot Nothing Then
                    Yield currentChild
                End If

                If child.HasChildren Then
                    For Each descendant As T In child.Descendants(Of T)()
                        Yield descendant
                    Next
                End If
            Next

        End Function
    End Module
End NameSpace