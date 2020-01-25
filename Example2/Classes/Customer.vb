Namespace Classes
    Public Class Customer
        Public Property Identifier() As Integer
        Public Property CompanyName() As String
        Public Property ContactName() As String
        Public Property ContactTypeIdentifier() As Integer
        Public Property ContactType() As Integer
        Public Property GenderIdentifier() As Integer
        Public Property GenderType() As String

        Public Overrides Function ToString() As String
            Return CompanyName
        End Function
    End Class
End Namespace