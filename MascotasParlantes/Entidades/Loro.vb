Public Class Loro
    Private memoria As Queue(Of String)
    Private _fechaNacimiento As Date
    Private _nombre As String
    Public Sub New()
        memoria = New Queue(Of String)
        fechaNacimiento = Date.Now '#04-10-1992#
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
    Public Function CalcularEdad(fechaNacimiento As Date) As UShort
        Dim diferenciaDeEdad As UShort
        Dim fechaActual As Date = Date.Now()
        diferenciaDeEdad = fechaActual.Year - fechaNacimiento.Year
        If fechaActual.Month < fechaNacimiento.Month Then
            diferenciaDeEdad -= 1
        ElseIf fechaActual.Month = fechaNacimiento.Month And fechaActual.Day < fechaNacimiento.Day Then
            diferenciaDeEdad -= 1
        End If
        Return diferenciaDeEdad
    End Function
    Public Sub Escuchar(Frase As String)
        memoria.Enqueue(Frase)
    End Sub
    Public Function Hablar() As String
        Dim frase As String
        frase = memoria.Dequeue
        Return frase
    End Function
End Class
