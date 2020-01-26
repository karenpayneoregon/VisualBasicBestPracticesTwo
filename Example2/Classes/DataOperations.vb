Imports System.Data.SqlClient

' responsible for connections construction
Imports BaseConnectionLibrary.ConnectionClasses

Namespace Classes
    Public Class DataOperations
        Inherits SqlServerConnection

        Public Sub New()
            DefaultCatalog = "CustomerDatabase"
            DatabaseServer = "KARENS-PC"
        End Sub
        Public Async Function TestConnectionAsync() As Task(Of Boolean)
            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Try
                    Await cn.OpenAsync()
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End Using
        End Function
        Public Function TestConnection() As Boolean
            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Try
                    cn.Open()
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End Using
        End Function
        ''' <summary>
        ''' Get customers by gender using a stored procedure
        ''' </summary>
        ''' <param name="genderType">1 Female, 2 Male, 3 Other</param>
        ''' <returns>List of customer by gender</returns>
        Public Async Function CustomersByGenderStoredProcedureAsync(genderType As Integer) As Task(Of List(Of Customer))

            Dim customersList As New List(Of Customer)

            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn}
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "uspCustomersByGender"
                    cmd.Parameters.AddWithValue("@GenderType", genderType)

                    Await cn.OpenAsync()

                    Dim reader = Await cmd.ExecuteReaderAsync()


                    While reader.Read()

                        customersList.Add(New Customer() With {
                                             .Identifier = reader.GetInt32(0),
                                             .CompanyName = reader.GetString(1),
                                             .ContactName = reader.GetString(2)})
                    End While

                End Using
            End Using

            Return customersList

        End Function
        ''' <summary>
        ''' Get customers by gender with conventional SQL
        ''' </summary>
        ''' <param name="genderType">1 Female, 2 Male, 3 Other</param>
        ''' <returns>List of customer by gender</returns>
        Public Async Function CustomersByGenderAsync(genderType As Integer) As Task(Of List(Of Customer))
            Dim customersList As New List(Of Customer)

            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn}

                    cmd.CommandText =
                        "SELECT C.Identifier,C.CompanyName ,C.ContactName,C.ContactTypeIdentifier,CT.ContactType,C.GenderIdentifier,G.GenderType " &
                        "FROM   dbo.Customer AS C INNER JOIN dbo.ContactTypes AS CT ON C.ContactTypeIdentifier = CT.Identifier " &
                        "INNER JOIN dbo.Genders AS G ON C.GenderIdentifier = G.id " &
                        "WHERE  C.GenderIdentifier = @GenderType;"
                    cmd.Parameters.AddWithValue("@GenderType", genderType)

                    Await cn.OpenAsync()

                    Dim reader = Await cmd.ExecuteReaderAsync()


                    While reader.Read()
                        customersList.Add(New Customer() With {
                                             .Identifier = reader.GetInt32(0),
                                             .CompanyName = reader.GetString(1),
                                             .ContactName = reader.GetString(2)})
                    End While

                End Using
            End Using

            Return customersList

        End Function
    End Class
End Namespace