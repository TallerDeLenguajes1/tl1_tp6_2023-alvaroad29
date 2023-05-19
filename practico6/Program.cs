//ejercicio 2
float num1,num2;
int op = 1;

do
{
    do
    {
        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><>");
        Console.WriteLine("<>   Ingrese la operacion a realizar:       <>");
        Console.WriteLine("<>   0-Salir                                <>");
        Console.WriteLine("<>   1-Suma                                 <>");
        Console.WriteLine("<>   2-Resta                                <>");
        Console.WriteLine("<>   3-Multiplicacion                       <>");
        Console.WriteLine("<>   4-Division                             <>");
        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><>");
    } while (!int.TryParse(Console.ReadLine(),out op) || op < 0 || op > 4); //si ingreso un texto o un valor que no este en el rango seguir iterando

    if (op != 0)
    {
        do
        {
            Console.WriteLine("<<<< Ingrese el primer numero >>>>");  
        } while (!float.TryParse(Console.ReadLine(),out num1));

        do
        {
            Console.WriteLine("<<<< Ingrese el segundo numero >>>>"); 
        } while (!float.TryParse(Console.ReadLine(),out num2));

        switch (op)
        {
            case 1:
                Console.WriteLine("\nSuma : " + (num1+num2)+"\n");
                break;

            case 2:
                Console.WriteLine($"\nResta de {num1} y {num2} es {num1-num2}\n");
                break;

            case 3:
                Console.WriteLine($"\nProducto de {num1} y {num2} es {num1*num2}\n");
                break;

            case 4:
                Console.WriteLine($"\nDivision de {num1} entre {num2} es {(num1/num2).ToString("N2")}\n");
                break;
        }

        do
        {
            Console.WriteLine("<<<< Desea continuar? SI[1] / NO[0] >>>>");
        } while (!int.TryParse(Console.ReadLine(),out op) || op < 0 || op > 1);
    }
} while (op != 0);