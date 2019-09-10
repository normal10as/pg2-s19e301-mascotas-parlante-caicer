Imports System
Imports Entidades
Module Program
    Sub Main()
        Dim loro1 As New Loro With {
            .nombre = "Pepito",
            .fechaNacimiento = #04-10-1992#
        }
        loro1.Escuchar("papita")
        loro1.Escuchar("pal loro")
        loro1.Escuchar("juan")
        Console.WriteLine("La diferencia de edad: " & loro1.CalcularEdad(loro1.fechaNacimiento))
        'Console.WriteLine(loro1.Hablar())
        Console.WriteLine("a " & loro1.Hablar())
        Console.WriteLine("b " & loro1.Hablar())
        Console.WriteLine("c " & loro1.Hablar())
    End Sub
End Module
