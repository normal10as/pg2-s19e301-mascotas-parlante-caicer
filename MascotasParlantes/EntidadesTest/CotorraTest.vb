Imports Entidades

Public Module CotorraTest
    Sub cotorra()
        Dim cotorra1 As Cotorra
        cotorra1 = New Cotorra()

        cotorra1.nombre = "juanito"
        cotorra1.fechaNacimiento = #08-30-2000#

        Console.WriteLine("Cotorra")
        Console.WriteLine("Nombre: " & cotorra1.nombre)
        Console.WriteLine("Nacimiento: " & cotorra1.fechaNacimiento)
        Console.WriteLine("Edad: " & cotorra1.edadHumana)

        cotorra1.Escuchar("papita ")
        cotorra1.Escuchar("nada")
        cotorra1.Escuchar("pa la cotorra ")
        cotorra1.Escuchar("nada")

        Console.WriteLine(cotorra1.Hablar())
        Console.WriteLine(cotorra1.Hablar())
        Console.WriteLine(cotorra1.Hablar())
        Console.WriteLine(cotorra1.Hablar())
    End Sub


End Module