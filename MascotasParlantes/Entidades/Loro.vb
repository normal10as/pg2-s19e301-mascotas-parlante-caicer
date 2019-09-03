Public Class Loro
    Private memoria As Queue(Of String)
    Private _fechaNacimiento As Date
    Private _nombre As String
    Public Sub New()
        memoria = New Queue(Of String)
        fechaNacimiento = Date.Now '#10-04-1992#
        nombre = ""

    End Sub

    Public ReadOnly Property edad As Short
        Get
            Return edad
        End Get
    End Property
    Public Property fechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

End Class
