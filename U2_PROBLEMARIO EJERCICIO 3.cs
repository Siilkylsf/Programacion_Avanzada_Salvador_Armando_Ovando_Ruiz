Console.WriteLine("Problemario #1: Ciclos y Estructuras en C#.");           //Nombre del problemario
Console.WriteLine("Ejercicio 3:  \r\nDiseñe un programa que simule la carga de una batería de 12.6 V. El usuario deberá ingresar: ");       //Nombre del ejercicio y descripción
Console.WriteLine("a) El voltaje inicial de la batería.  \r\nb) El incremento de voltaje producido en cada ciclo de carga. ");              //Descripción de los datos de entrada
Console.WriteLine();
Console.WriteLine("Mediante un ciclo while, el programa aumentará el voltaje hasta alcanzar 12.6 V. En cada \r\nrepetición deberá mostrar el número de ciclo y el voltaje actual. \r\nSi el incremento introducido es igual o menor que cero, el programa deberá mostrar un mensaje \r\nde error y no ejecutar la simulación. ");       //Descripción de la salida del programa
Console.WriteLine();
Console.WriteLine("ingrese el voltaje inicial de la batería: ");        // Solicitar al usuario que ingrese el voltaje inicial de la batería
double voltajeInicial = Convert.ToDouble(Console.ReadLine());           // Leer el voltaje inicial ingresado por el usuario y convertirlo a tipo double
Console.WriteLine("ingrese el incremento de voltaje producido en cada ciclo de carga: ");       // Solicitar al usuario que ingrese el incremento de voltaje producido en cada ciclo de carga
double incrementoVoltaje = Convert.ToDouble(Console.ReadLine());        // Leer el incremento de voltaje ingresado por el usuario y convertirlo a tipo double
if (incrementoVoltaje <= 0)                                             // Verificar si el incremento de voltaje es menor o igual a cero
{
    Console.WriteLine("Error: El incremento de voltaje debe ser mayor que cero.");      // Mostrar un mensaje de error si el incremento de voltaje es menor o igual a cero
}
else                                     // Si el incremento de voltaje es mayor que cero, ejecutar la simulación de carga de la batería
{
    int ciclo = 0;                         // Inicializar el contador de ciclos en cero
    double voltajeActual = voltajeInicial;      // Inicializar el voltaje actual con el voltaje inicial ingresado por el usuario
    while (voltajeActual < 12.6)                // Mientras el voltaje actual sea menor que 12.6 V, continuar con el ciclo de carga
    {
        ciclo++;                                // Incrementar el contador de ciclos en uno
        voltajeActual += incrementoVoltaje;         // Aumentar el voltaje actual en el incremento de voltaje ingresado por el usuario
        if (voltajeActual > 12.6)                   // Verificar si el voltaje actual supera los 12.6 V
        {
            voltajeActual = 12.6;                        // Limitar el voltaje a 12.6 V
        }
        Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {voltajeActual} V");            // Mostrar el número de ciclo y el voltaje actual en cada repetición del ciclo
    }
    Console.WriteLine("La batería ha alcanzado su carga completa de 12.6 V.");              // Mostrar un mensaje indicando que la batería ha alcanzado su carga completa de 12.6 V
}