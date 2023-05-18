// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int a;

//int b;

//a = 10;

//b = a;

//Console.WriteLine("Valor de a:"+a);

//Console.WriteLine("Valor de b:"+b);

//ejercicio 1
int numero;
Console.WriteLine("Ingrese un numero");
string numeroString = Console.ReadLine(); //leo el numero
while (!int.TryParse(numeroString,out numero)) //si es un numero devuelve true y guarda el numero en "numero",si no es un numero devuelve false
{
    Console.WriteLine("Numero ingresado no valido");
    Console.WriteLine("Ingrese un numero");
    numeroString = Console.ReadLine();    
}

int resto = 0,divisor = numero,i=10,invertido = 0;

do
{
    resto = divisor % 10;
    divisor = divisor / 10;
    invertido = invertido * i + resto;
} while (divisor > 0);

Console.WriteLine("Numero ingresado:"+numero);
Console.WriteLine("Numero invertido:"+invertido);