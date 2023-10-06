Module Module1

    Sub Main()
        producto()


    End Sub
    Sub producto()
        Dim precio = 75
        Dim cambio, pago, faltante, suma, comple As Double

        Console.WriteLine("COSTO DEL PRODUCTO= 75 dolares")

        Console.WriteLine("Ingrese el monto de dinero")
        pago = Console.ReadLine()

        If pago > precio Then
            cambio = pago - precio
            Console.WriteLine("Su cambio es " & cambio)
            Console.WriteLine("Gracias por su compra")

        ElseIf pago = precio Then

            Console.WriteLine("Gracias por su compra")

        ElseIf pago < precio Then

            faltante = precio - pago

            Console.WriteLine("Debe agregar la cantidad de " & faltante)
            Console.WriteLine("Introduzca el pago solicitado")
            comple = Console.ReadLine()

            suma = comple + pago


        ElseIf suma = precio Then
            Console.WriteLine("Gracias por su compra")

        Else
            Console.WriteLine("Regrese otro dia por su producto")

        End If


    End Sub

End Module
