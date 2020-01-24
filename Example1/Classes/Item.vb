Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports Example1.LanguageExtensions

Namespace Classes
    Public Class Item
        Implements INotifyPropertyChanged
        Private _value1 As Integer

        Public Sub New()

        End Sub
        Public Sub New(line As String)
            Dim parts = line.Split(","c).ToIntegerArray()
            If parts.Length = 5 Then
                Id = parts(0)
                Value1 = parts(1)
                Value2 = parts(2)
                Value3 = parts(3)
                Value4 = parts(4)
            End If
        End Sub

        Public Property Id() As Integer

        Public Property Value1() As Integer
            Get
                Return _value1
            End Get
            Set(ByVal value As Integer)
                If Not (value = _value1) Then
                    _value1 = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Public Property Value2() As Integer
        Public Property Value3() As Integer
        Public Property Value4() As Integer
        Public ReadOnly Property Array() As Integer()
            Get
                Return New Integer() {Value1, Value2, Value3, Value4}
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return Id.ToString()
        End Function


        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End NameSpace