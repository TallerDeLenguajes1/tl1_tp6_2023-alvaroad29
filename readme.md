# Ejercicio 4 🤚
![](https://www.10wallpaper.com/wallpaper/1366x768/1205/twilight_blue_moon_mountains-HD_Space_Wallpapers_1366x768.jpg)

**1. ¿String es un tipo por valor o un tipo por referencia?**
   - `string` es un tipo de dato por referencia en C#. Esto significa que cuando se crea una variable de tipo `string`, se almacena una referencia a la ubicación en memoria donde se encuentra el valor de la cadena de texto. Las variables de tipo `string` se asignan en la pila, pero el contenido de la cadena de texto en sí se almacena en el montón (heap).

**2. ¿Qué secuencias de escape tiene el tipo `string`?**
   - El tipo `string` en C# admite varias secuencias de escape para representar caracteres especiales dentro de una cadena de texto. Algunas de las secuencias de escape comunes son:
     - `\"` para representar una comilla doble dentro de una cadena.
     - `\'` para representar una comilla simple dentro de una cadena.
     - `\\` para representar una barra invertida dentro de una cadena.
     - `\n` para representar un salto de línea.
     - `\r` para representar un retorno de carro.
     - `\t` para representar un tabulador.
     - `\b` para representar un retroceso.
     - `\f` para representar un avance de página.
     - `\uXXXX` para representar un carácter Unicode especificado por su valor hexadecimal de 4 dígitos.
     - `\xXX` para representar un carácter Unicode especificado por su valor hexadecimal de 2 dígitos.

**3. ¿Qué sucede cuando utilizas el carácter `@` y `$` antes de una cadena de texto?**
   - Cuando utilizas el carácter `@` antes de una cadena de texto (por ejemplo, `@"C:\Directorio\Archivo.txt"`), se crea una cadena literal. Esto significa que los caracteres de escape como `\n`, `\t`, etc., no se interpretan y se consideran parte de la cadena tal como están escritos. Esto es útil, por ejemplo, cuando se trabaja con rutas de archivos o cadenas que contienen muchos caracteres de escape.
   - Cuando utilizas el carácter `$` antes de una cadena de texto (por ejemplo, `$"El resultado es: {resultado}"`), se crea una cadena interpolada. Esto te permite incluir expresiones o variables dentro de la cadena utilizando la sintaxis `{}`. Las expresiones dentro de las llaves se evalúan y se sustituyen por sus valores correspondientes en tiempo de ejecución. Es una forma conveniente de concatenar valores dentro de una cadena de texto sin tener que usar el operador `+` para la concatenación.
