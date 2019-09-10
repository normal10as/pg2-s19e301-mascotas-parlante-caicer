Public Class Jaula
    Private _nombre As String
    Public Sub New()
        _nombre = ""
    End Sub
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
