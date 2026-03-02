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
        break;
    case 7:
        break;
    case 8:
        break;
    case 9:
        break;
    case 10:
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
