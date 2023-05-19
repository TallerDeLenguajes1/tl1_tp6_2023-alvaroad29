//ejercicio 4
//int numero;
Console.WriteLine("Ingrese una cadena de texto");
string texto = Console.ReadLine(); //Guardo la cadena
// while (!int.TryParse(numeroString,out numero)) //si es un numero devuelve true y guarda el numero en "numero",si no es un numero devuelve false
// {
//     Console.WriteLine("Numero ingresado no valido");
//     Console.WriteLine("Ingrese un numero");
//     numeroString = Console.ReadLine();    
// }

//longitud
int longitud = texto.Length;
Console.WriteLine("Longitud de la cadena ingresada: "+ longitud);

//ingreso otra cadena y concateno
Console.WriteLine("Ingrese otra cadena de texto");
string texto1 = Console.ReadLine(); //Guardo la cadena
string concatenada = string.Concat(texto,texto1);
//string concatenada = texto + texto1;
Console.WriteLine("Cadena concatenada: "+ concatenada);

//subcadena
int inicio,fin;
Console.WriteLine($"Ingrese el indice de inicio de la subcadena: {concatenada}");
inicio = int.Parse(Console.ReadLine());
Console.WriteLine($"Ingrese la longitud de la subcadena a partir del inicio: {concatenada}");
fin = int.Parse(Console.ReadLine());
string subcadena = concatenada.Substring(inicio,fin); // longitud representar el indice desde el q obtendra la subcadena
Console.WriteLine($"Subcadena de la cadena {concatenada}: {subcadena}");

//recorro la cadena
foreach (char caracter in subcadena) //caracter: donde se van guardando, subcadena: nombre del string que recorro
{
    Console.WriteLine(caracter);
}

//buscar la ocurrencia de una palabra determinada en la cadena ingresada
int i = 0;
string[] palabras = concatenada.Split(' '); //separo la cadena en subcadenas usando el espacio como separados
Console.WriteLine("Ingrese la palabra buscada en la cadena :"+concatenada);
string buscada = Console.ReadLine(); //Guardo la cadena
foreach (string item in palabras)
{
    if (buscada == item)
    {
        i++;
    }
}
Console.WriteLine("Ocurrencia de la palabra {0} en la cadena {1} : {2}",buscada,subcadena,i);

// o tambien si esta o no esta una secuencia de letras
Console.WriteLine("Ingrese la palabra buscada en la cadena :"+concatenada);
buscada  = Console.ReadLine();
bool contienePalabra = concatenada.Contains(buscada); //devuelve true o false
Console.WriteLine("La cadena contiene la palabra buscada: " + contienePalabra);


//Mayusculas y minusculas
string cadenaMayuscula = concatenada.ToUpper();

string cadenaMinuscula = concatenada.ToLower();

Console.WriteLine("Cadena en mayusculas : " + cadenaMayuscula);
Console.WriteLine("Cadena en minusculas : " + cadenaMinuscula);

//ecuacion y split
Console.WriteLine("Ingrese una ecuacion (suma sin espacios): ej 2+2");
string ecuacion =Console.ReadLine();
string[] ecSeparada = ecuacion.Split('+');
Console.WriteLine("El resultado es : " + (double.Parse(ecSeparada[0]) + double.Parse(ecSeparada[1])));


