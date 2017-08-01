Module Module1

    Sub Main()
        Dim opcion As Integer = 0
        Dim opcion2 As Integer = 0
        Console.Title = "Holaaaa :v"
        Console.WriteLine("Selecciona una opción amiguito mío :v")
        Console.WriteLine("1.) Ejemplo de for")
        Console.WriteLine("2.) Ejemplo de while")
        opcion = Console.ReadLine
        Select Case opcion
            Case 1
                For n As Integer = 0 To 200
                    Console.WriteLine("Mi mami :v")


                Next


            Case 2
                Dim n As Integer = 0
                While n < 200
                    Console.WriteLine("Ojalá salga :v")
                    n = n + 1
                    If (n < 200) And (n > 100) Then
                        Console.WriteLine("M&M with C")
                    End If
                End While


            Case Else
                Console.Title = "Holaaaa :v"
                Console.WriteLine("Selecciona una opción amiguito mío :v")
                Console.WriteLine("1.) Ejemplo de for")
                Console.WriteLine("2.) Ejemplo de while")
                opcion = Console.ReadLine


        End Select





    End Sub

End Module
