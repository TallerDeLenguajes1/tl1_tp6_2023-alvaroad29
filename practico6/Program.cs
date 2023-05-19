//ejercicio 3
float num1,num2;
int op = 1;

void info(float num)
{
    Console.WriteLine($"Valor absoluto de {num}: {Math.Abs(num)}");
    Console.WriteLine("Potencia cuadrada de {0}: {1}",num,Math.Pow(num,2));
    Console.WriteLine($"Raiz cuadrado de {num}: {Math.Sqrt(num).ToString("N4")}");
    Console.WriteLine("Seno: " + Math.Sin(num * Math.PI / 180).ToString("N4"));
    Console.WriteLine("Coseno: {0:N4}", Math.Cos(num * Math.PI / 180));
    Console.WriteLine("Parte entera: " + Math.Truncate(num));
}

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
        Console.WriteLine("<>   5-Otros                                <>");
        Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><>");
    } while (!int.TryParse(Console.ReadLine(),out op) || op < 0 || op > 5); //si ingreso un texto o un valor que no este en el rango seguir iterando

    if (op != 0)
    {
        if (op != 5)
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
        }
        else
        {
            do
            {
                Console.WriteLine("<<<< Ingrese un numero para obtener su informacion >>>>");  
            } while (!float.TryParse(Console.ReadLine(),out num1));
            info(num1);

            do
            {
                Console.WriteLine("<<<< Ingrese el primer numero >>>>");  
            } while (!float.TryParse(Console.ReadLine(),out num1));

            do
            {
                Console.WriteLine("<<<< Ingrese el segundo numero >>>>"); 
            } while (!float.TryParse(Console.ReadLine(),out num2));

            if (num1 == num2)
            {
                Console.WriteLine("\nLos numeros ingresados son iguales\n"); 
            }else
            {
                Console.WriteLine($"\nEl maximo entre {num1} y {num2} es: {Math.Max(num1,num2)}"); 
                Console.WriteLine($"El Minimo entre {num1} y {num2} es: {Math.Min(num1,num2)}\n"); 
            }
        }

        do
        {
            Console.WriteLine("<<<< Desea continuar? SI[1] / NO[0] >>>>");
        } while (!int.TryParse(Console.ReadLine(),out op) || op < 0 || op > 1);
    }
} while (op != 0);