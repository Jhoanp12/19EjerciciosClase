Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Bienvenido ")
        Menu()
        Console.WriteLine("Gracias por visitar mi programa, Excelente día :)")
    End Sub
    Sub Menu()
        Dim c As Integer = 1
        Dim opcion As Integer = 0
        Do
            Console.WriteLine("Por favor escoja un ejercicio del 1 - 19")
            opcion = Console.ReadLine()
            If opcion >= 1 And opcion <= 19 Then
                Select Case opcion
                    Case Is = 1
                        Ejercicio1()
                    Case Is = 2
                        Ejercicio2()
                    Case Is = 3
                        Ejercicio3()
                    Case Is = 4
                        Ejercicio4()
                    Case Is = 5
                        Ejercicio5()
                    Case Is = 6
                        Ejercicio6()
                    Case Is = 7
                        Ejercicio7()
                    Case Is = 8
                        Ejercicio8()
                    Case Is = 9
                        Ejercicio9()
                    Case Is = 10
                        Ejercicio10()
                    Case Is = 11
                        Ejercicio11()
                    Case Is = 12
                        Ejercicio12()
                    Case Is = 13
                        Ejercicio13()
                    Case Is = 14
                        Ejercicio14()
                    Case Is = 15
                        Ejercicio15()
                    Case Is = 16
                        Ejercicio16()
                    Case Is = 17
                        Ejercicio17()
                    Case Is = 18
                        Ejercicio18()
                    Case Is = 19
                        Ejercicio19()
                End Select
            Else
                Console.WriteLine("La opción es erronea, por favor vuelva a ejecutar el programa")
                c = 2
            End If

            Console.WriteLine("Sí desea continuar digite 1, de lo contrario, digite otro número")
            c = Console.ReadLine()

        Loop Until c <> 1

    End Sub
    Sub Ejercicio1()
        '******** Ejercicio 1 Hallar sí el número es primo o no*********
        Console.WriteLine("Hallar sí el número es primo o no")
        Dim num As Integer
        Dim x As Integer = 0
        Console.WriteLine("Ingrese un número")
        num = Console.ReadLine()
        For i = 2 To num - 1
            If num Mod i = 0 Then
                x = 1
            End If
        Next i
        If x = 0 Then
            Console.WriteLine("El número ingresado " & num & " es primo")
        Else
            Console.WriteLine("El número ingresado " & num & " NO es primo")
        End If
        Console.WriteLine()

    End Sub
    Sub Ejercicio2()
        '***********Ejercicio 2, 10 primeros números del fibonacci****************
        Console.WriteLine("10 primeros números del fibonacci")
        Dim numeroUno As Integer = 0
        Dim numeroDos As Integer = 1
        Dim numeroTres As Integer

        Console.Write(numeroUno & ", ")
        Console.WriteLine(numeroDos & ", ")

        For i = 1 To 8
            numeroTres = numeroUno + numeroDos
            Console.Write(numeroTres & ", ")
            numeroUno = numeroDos
            numeroDos = numeroTres
        Next i
        Console.WriteLine()

    End Sub
    Sub Ejercicio3()
        '**********Ejercicio 3, pares e impares*******************
        Console.WriteLine("La suma de los número pares e impares del 1 - 100")
        Dim pares, impares, totalPares, totalImpares As Integer
        For i = 1 To 100
            If (i Mod 2 = 0) Then
                pares = pares + i
                totalPares = totalPares + 1
            Else
                impares = impares + i
                totalImpares = totalImpares + 1
            End If

        Next
        Console.WriteLine("La sumatoria de los números pares es {0} y el total de números pares es {1}, ", pares, totalPares)
        Console.WriteLine("La sumatoria de los números impares es {0} y el total de números impares es {1}, ", impares, totalImpares)
        Console.WriteLine()

    End Sub
    Sub Ejercicio4()
        '************Ejercicio 4, Tiempo en minutos************
        Console.WriteLine("Pasar de minutos a horas")
        Dim min As Integer = 0
        Dim hora As Integer = 0
        Dim tiempo As Integer

        Console.WriteLine("Escriba el tiempo en minutos")
        tiempo = Integer.Parse(Console.ReadLine())
        While tiempo > 0
            If tiempo >= 60 Then
                hora = hora + 1
                tiempo = tiempo - 60
            Else
                min = min + 1
                tiempo = tiempo - 1
            End If
        End While
        Console.WriteLine("Horas: " & hora)
        Console.WriteLine("Minutos: " & min)
        Console.WriteLine()
    End Sub
    Sub Ejercicio5()
        '******Ejercicio 5,leer en segundos y pasar a minutos ********
        Console.WriteLine("Dar un tiempo en segundo y calcular cuantos min y cuantos seg faltan para el min")
        Dim seg As Integer = 60
        Dim min As Integer = 0
        Dim tiempo As Integer
        Console.WriteLine("Escriba el tiempo en segundos")
        tiempo = Integer.Parse(Console.ReadLine())
        While tiempo > 0
            If tiempo >= 60 Then
                min = min + 1
                tiempo = tiempo - 60
            Else
                seg = seg - 1
                tiempo = tiempo - 1
            End If
        End While
        Console.WriteLine("Minutos: " & min)
        Console.WriteLine("Faltan {0} segundos para el otro minuto", seg)
        Console.WriteLine()
    End Sub
    Sub Ejercicio6()
        '**********Ejercicio 6, Leer unos precios de productos**************
        Console.WriteLine("Leer e imprimir unos precios de un producto y calcular el total de la compra más el IVA")
        Dim producto As String
        Dim cantidad, valorUnitario, TotalSinIVA, Total As Integer
        Dim IVA As Decimal = 0.19
        Dim conIVA As Decimal
        Console.WriteLine("Ingrese el nombre del Producto que compro ")
        producto = Console.ReadLine()
        Console.WriteLine("Ingrese la cantidad comprada: ")
        cantidad = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Ingrese el valor unitario del producto: ")
        valorUnitario = Integer.Parse(Console.ReadLine())
        TotalSinIVA = cantidad * valorUnitario
        conIVA = TotalSinIVA * IVA
        Total = TotalSinIVA + conIVA
        Console.WriteLine("El producto que compro es: " & producto)
        Console.WriteLine("El total sin IVA calculado es: " & TotalSinIVA)
        Console.WriteLine("El IVA calculado es: " & conIVA)
        Console.WriteLine("El total a pagar es: " & Total)
        Console.WriteLine()
    End Sub
    Sub Ejercicio7()
        '************* Ejercicio 7, Calcular la potencia X´y*************
        Console.WriteLine("calcular la potencia de un número (yo lo hice creando una función desde cero)")
        Dim base, exponente, resultado As Integer
        Console.WriteLine("Ingrese el valor de la base de la potencia (x): ")
        base = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Ingrese el valor del exponente de la potencia (y): ")
        exponente = Integer.Parse(Console.ReadLine())
        resultado = Potencia(base, exponente)
        Console.WriteLine("El resultado de la potencia es: " & resultado)
        Console.WriteLine()
    End Sub
    Private Function Potencia(base As Integer, exponente As Integer) As Integer
        Dim resultado, I As Integer
        resultado = 1
        For I = 1 To exponente
            resultado = resultado * base
        Next I
        Return resultado
    End Function
    Sub Ejercicio8()
        '************ Ejercicio 8, intervalos *************
        Console.WriteLine("Suma los intervalos entre dos números")
        Dim numUno, numDos, resultado As Integer

        Console.WriteLine("Ingrese el primer número, recuerde que debe ser menor que el segundo número")
        numUno = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo número, recuede que debe ser mayor que el anterior")
        numDos = Console.ReadLine()
        If numUno < numDos Then
            For i = numUno To numDos
                resultado = resultado + i
                Console.Write(resultado & ", ")
            Next
            Console.WriteLine("El resultado de la suma de los intervalos entre {0} y {1} es: {2}", numUno, numDos, resultado)
        Else
            Console.WriteLine("El número {0}, es mayor que el número {1} ", numUno, numDos)
        End If

        Console.WriteLine()
    End Sub
    Sub Ejercicio9()
        '************ Ejercicio 9, Ejercicio Si el número es par se divide por 2. • Si es impar se multiplica por 3 y se suma 1. **********
        Console.WriteLine("Ejercicio de la conjetura de Ulam")
        Dim num As Integer
        Console.WriteLine("Ingrese un número")
        num = Console.ReadLine()
        While num > 1
            If (num Mod 2 = 0) Then
                num = num / 2
            Else
                num = (num * 3) + 1
            End If
            Console.Write(num & ", ")
        End While
        Console.WriteLine()
    End Sub
    Sub Ejercicio10()
        '************ Ejercicio 10, programa que calcule la factorialde un número introducido por teclado.************
        Console.WriteLine("Programa que calcule la factorialde un número digitado por teclado")
        Dim num, salida, c, f As Integer
        Do
            Console.WriteLine("ingrese un número")
            num = Integer.Parse(Console.ReadLine())
            If num > 0 Then
                f = 1
                c = 1
                While c <= num
                    f = f * c
                    c = c + 1
                End While
                Console.WriteLine("El factorial de " & num & " es: " & f)
                Console.WriteLine("")
            Else
                Console.WriteLine("No se puede calcular el factorial de " & num)
            End If
            Console.WriteLine("Desea continuar o salir")
            Console.WriteLine("Escriba 1 para continuar o 2 para salir")
            salida = Integer.Parse(Console.ReadLine())

        Loop Until salida <> 1
        Console.WriteLine()


    End Sub
    Sub Ejercicio11()
        '************ Ejercicio 11, programa que determine cuántos dígitos se necesitan para escribir el valor N. **********
        Console.WriteLine("Programa que determine cuántos dígitos se necesitan para escribir el valor N")
        Dim num As String
        Dim contador As Integer
        Console.WriteLine("Ingrese un número")
        num = Console.ReadLine()
        contador = num.Length()
        Console.WriteLine("El número ingresado {0} tiene {1} digitos", num, contador)
        Console.WriteLine()
    End Sub
    Sub Ejercicio12()
        '************ Ejercicio 12, programa que permita generar la siguiente sucesión aritmética, hasta que sea 100 o menor que 100 *******
        Console.WriteLine("programa que permita generar la siguiente sucesión aritmética, hasta que sea 100 o menor que 100")
        Dim numero As Double
        For numero = 3 To 100 Step 4
            Console.Write(numero & ", ")
        Next
        Console.WriteLine()
    End Sub
    Sub Ejercicio13()
        '*********** Ejercicio 13 secuencia de fibonacci los siguiente 10 numeros **********
        Console.WriteLine("secuencia de fibonacci los siguiente 10 numeros")
        Dim numero As Integer
        Console.WriteLine("Ingrese el número entero de donde desea que empiece la secuencia de fibonacci")
        numero = Console.ReadLine()
        Dim numDos As Integer = 1
        Dim numTres As Integer

        For i = 1 To 10
            numTres = numero + numDos
            Console.WriteLine(numTres)
            numero = numDos
            numDos = numTres
        Next i
        Console.WriteLine()
    End Sub
    Sub Ejercicio14()
        '******* Ejercicio 14, ¿Cuántos años, meses, semanas y días; constituyen el número de días proporcionado? *******
        Console.WriteLine("¿Cuántos años, meses, semanas y días; constituyen el número de días proporcionado?")
        Dim years As Integer = 0
        Dim mounths As Integer = 0
        Dim weeks As Integer = 0
        Dim days As Integer
        Dim time As Integer

        Console.WriteLine("Escriba el número de días")
        time = Integer.Parse(Console.ReadLine())
        While time > 0
            If time >= 365 Then
                years = years + 1
                time = time - 365
            ElseIf time >= 30 Then
                mounths = mounths + 1
                time = time - 30
            ElseIf time >= 7 Then
                weeks = weeks + 1
                time = time - 7
            Else
                days = days + 1
                time = time - 1
            End If
        End While
        Console.WriteLine("Años: " & years)
        Console.WriteLine("Meses: " & mounths)
        Console.WriteLine("Semanas: " & weeks)
        Console.WriteLine("Días: " & days)
        Console.WriteLine()
    End Sub
    Sub Ejercicio15()
        '******* Ejercicio 15, Realice un algoritmo que genere la siguiente sucesión hasta los 10 primeros números: 0,1,2,5,26,677... *******
        Console.WriteLine("Programa que realiza el siguiente algoritmo 0-1-2-5-26-677...")
        Dim num As Integer = 0
        Console.Write(num & ", ")
        For i = 1 To 6
            num = (num * num) + 1
            Console.Write(num & ", ")
        Next i
        Console.WriteLine("El siguiente número es muy grande '210.066.388.901'")
        Console.WriteLine()
    End Sub
    Sub Ejercicio16()
        '******* Ejercicio 16, Realice algoritmo que genere la siguiente sucesión hasta los 10 primeros números: 5,15,45 *******
        Console.WriteLine("Programa que genera una suceción")
        Dim resultado As Integer = 5
        For index = 1 To 10
            Console.Write(resultado & ", ")
            resultado = resultado * 3
        Next
        Console.WriteLine()



    End Sub
    Sub Ejercicio17()
        '******* Ejercicio 17, Realice algoritmo que genere la siguiente sucesión hasta los 10 primeros números: 1,4,9,16,25,36... *******
        Console.WriteLine("Generar la sucesión 1, 4, 9, 16, 25, 36, 49, ...")
        For num = 1 To 10
            Console.Write(num * num & ", ")
        Next
        Console.WriteLine()
    End Sub
    Sub Ejercicio18()
        '******* Ejercicio 18, Realizar un algoritmo que resuelva el siguiente problema: Una progresión geométrica comienza en 1 y tiene razón 2. Encontrar los tres términos consecutivos (de la sucesión) cuyo producto es 512.*******
        Console.WriteLine(".Encontrar los tres términos consecutivos (de la sucesión) cuyo producto es 512")
        Dim numUno As Integer = 1
        Dim arrayUno(15) As Integer
        For index = 1 To 15
            arrayUno(index) = numUno
            numUno = numUno * 2
        Next
        Console.WriteLine("La secuencia es: ")
        For i = 1 To 15

            Console.Write(arrayUno(i) & ", ")

        Next
        Console.WriteLine()

        For i = 1 To 10
            If (arrayUno(i) * arrayUno(i + 1) * arrayUno(i + 2)) = 512 Then
                Console.WriteLine("Los números que cumplen la condición son: {0}, {1} y  {2}", arrayUno(i), arrayUno(i + 1), arrayUno(i + 2))
            Else
            End If
        Next
        Console.WriteLine()
    End Sub
    Sub Ejercicio19()
        '******* Ejercicio 19, La suma de 6 números impares consecutivos vale 120. Encontrar dichos números. *******
        Console.WriteLine("La suma de 6 números impares consecutivos vale 120.")
        Dim arrayUno(60) As Integer
        Dim numUno As Integer = 1
        For index = 1 To 60
            arrayUno(index) = numUno
            numUno = numUno + 2
        Next
        For index = 1 To 55
            If (arrayUno(index) + arrayUno(index + 1) + arrayUno(index + 2) + arrayUno(index + 3) + arrayUno(index + 4) + arrayUno(index + 5)) = 120 Then
                Console.WriteLine("Los números que cumplen la condición son: {0}, {1}, {2}, {3}, {4} y  {5}", arrayUno(index), arrayUno(index + 1), arrayUno(index + 2), arrayUno(index + 3), arrayUno(index + 4), arrayUno(index + 5))
            Else
            End If
        Next
        Console.WriteLine()
    End Sub
End Module
