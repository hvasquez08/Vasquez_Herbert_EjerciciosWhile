//ejercicio de while
Console.WriteLine("Mostrar los números del 1 al 10.\r\n\r\nMostrar los números del 10 al 1.\r\n\r\nMostrar los números pares del 1 al 20.\r\n\r\nMostrar los números impares del 1 al 20.\r\n\r\nSumar los números del 1 al 100.\r\n\r\nPedir números hasta que el usuario ingrese 0.\r\n\r\nContar cuántos números positivos ingresa el usuario.\r\n\r\nCalcular el factorial de un número ingresado.\r\n\r\nMostrar la tabla de multiplicar de un número ingresado.\r\n\r\nContar cuántos dígitos tiene un número.\r\n\r\nSumar números ingresados hasta que el total supere 100.\r\n\r\nPedir una contraseña hasta que sea correcta.\r\n\r\nMostrar los múltiplos de 3 menores a 50.\r\n\r\nGenerar una secuencia que aumente de 5 en 5 hasta 100.\r\n\r\nSimular un menú que se repita hasta que el usuario elija salir.");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        Console.Clear();
        int i = 0;
        while (i <= 9)
        {
            i++;
            Console.WriteLine(i);
        }
        break;
    case 2:
        Console.WriteLine("ejercici");
        Console.Clear();
        int x = 11;
        while (x >= 2)
        {
            x--;
            Console.WriteLine(x);
        }
        break;
    case 3:
        Console.WriteLine("ejercici");
        Console.Clear();
        int w = 2;
        while (w <= 20)
        {
            
            Console.WriteLine(w);
            w += 2;
        }
        break;
    case 4:
        Console.Clear();
        Console.WriteLine("ejercicio realizado");
        int ww = 1;
        while (ww <= 20)
        {

            Console.WriteLine(ww);
            ww += 2;
        }
            break;
    case 5:
        Console.Clear();
        Console.WriteLine("Ejercicio realizado");
        int suma = 0;
        for (int ii = 1; ii<=100; ii++)
        {
            suma = suma+ ii ;
        }
        Console.WriteLine($"la suma es{suma}");
        break;
    case 6:
        Console.Clear();
        double numero = 1;
        while(numero != 0)
        {
            Console.WriteLine("ingrese un numero");
            numero = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("adios");
        break;
    case 7:
        //vamos a declarar solamente 7 intentos para saber cuantos numero negativos ingresa
        //funciona pero no se como jajjajaja
        Console.Clear();
        int negativo = 0;
        int yy = 0;
  for (int contadooor = 0; contadooor <= 2; contadooor++) { 
            Console.WriteLine("Ingrese un numero ");
            yy = int.Parse(Console.ReadLine());
            while (yy < 0)
        {
            Console.WriteLine("Ingrese un numero ");
            yy = int.Parse(Console.ReadLine());
            negativo++;
        }
        }
        Console.WriteLine($"Numeros negativos:{negativo}");
        break;
    case 8:
        //factorial es multiplicar un numero por el mismo numero las veces del numero, algo haci jajajs xd 
        Console.Clear();
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        int factorial = 1;
        int ix = 1;

        while (ix <= n)
        {
            factorial *= ix;
            ix++;
        }

        Console.WriteLine($"El factorial de {n} es {factorial}");

        break;
    case 9:
        Console.Clear() ;
        Console.WriteLine("Ingrese un numero");
        int numeromultiplicado = int.Parse(Console.ReadLine());
        int multiplicacion = 1;
        while (multiplicacion <= 10)
        {
            Console.WriteLine($"{numeromultiplicado}x{multiplicacion}={numeromultiplicado*multiplicacion}");
            multiplicacion ++ ;
        }

        break;
    case 10:
        Console.Clear() ;
        Console.Write("Ingrese un número: ");
        int numerocontado = int.Parse(Console.ReadLine());

        int cantidadDigitos = 0;

        while (numerocontado > 0)
        {
            numerocontado /= 10; 
            cantidadDigitos++;
        }

        Console.WriteLine($"El número tiene {cantidadDigitos} dígitos.");

        break;
    case 11:
        break;
    case 12:
        break;
    case 13:
        break;
    case 14:
        break;
    case 15:
        break;
    default:
        break;
}
