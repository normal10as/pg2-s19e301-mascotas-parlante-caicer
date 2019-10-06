Public Class Cotorra
    Inherits Loro
    Public Sub New()
        MyBase.New()
        nombre = ""
        fechaNacimiento = Date.Now
        memoria = New Queue(Of String)
    End Sub

    Public ReadOnly Property edadHumana As UShort
        Get
            Return 2 * edad
        End Get
    End Property

    Dim OnOff As Integer = 0
    Public Overrides Sub Escuchar(frase As String)
        If OnOff Mod 2 = 0 Then
            memoria.Enqueue(frase)
        End If
        OnOff += 1
    End Sub
End Class
