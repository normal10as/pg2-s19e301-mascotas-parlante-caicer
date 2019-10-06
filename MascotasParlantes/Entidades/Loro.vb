Public Class Loro
    Protected memoria As Queue(Of String)
    Private _fechaNacimiento As Date
    Private _nombre As String
    Public Sub New()
        memoria = New Queue(Of String)
        fechaNacimiento = Date.Now '#04-10-1992#
        nombre = ""
    End Sub

    Public ReadOnly Property edad As Short
        Get
            Return CalcularEdad(fechaNacimiento)
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
    Private Function CalcularEdad(fechaNacimiento As Date) As UShort
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
    Public Overridable Sub Escuchar(Frase As String)
        memoria.Enqueue(Frase)
    End Sub
    Private frase As String
    Public Function Hablar() As String
        If memoria.Count <> 0 Then
            frase += memoria.Dequeue
        End If
        Return frase
    End Function
    Public Overrides Function toString() As String
        Return nombre
    End Function
End Class
