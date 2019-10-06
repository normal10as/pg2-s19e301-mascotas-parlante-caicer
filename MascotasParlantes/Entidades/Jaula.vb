Public Class Jaula
    Inherits Cotorra
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
    Private _cotorra As List(Of Cotorra)
    Private _loro As Loro
End Class
