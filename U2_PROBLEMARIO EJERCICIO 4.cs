Console.WriteLine("Problemario #1: Ciclos y Estructuras en C#.");           //Nombre del problemario
Console.WriteLine("Durante una prueba se realizan ocho mediciones de corriente de un actuador eléctrico. Diseñe \r\nun programa que utilice un ciclo para introducir las ocho mediciones. Cada medición deberá \r\nclasificarse de la siguiente manera: ");       //Nombre del ejercicio y descripción
Console.WriteLine("a) Si la corriente es menor o igual que 5 A, mostrar: MEDICIÓN NORMAL.  \r\nb) Si es mayor que 5 A, mostrar: SOBRECORRIENTE DETECTADA.  ");              //Descripción de los datos de entrada
Console.WriteLine();
Console.WriteLine("Al finalizar el programa deberá mostrar:  \r\n• Corriente promedio. \r\n• Cantidad de mediciones normales. \r\n• Cantidad de sobrecorrientes. \r\n• Resultado general del actuador.  \r\nEl resultado general será: \r\na) ACTUADOR APROBADO, si no se detectó ninguna sobrecorriente.   \r\nb) EL ACTUADOR REQUIERE REVISIÓN, si se detectó una o más sobrecorrientes.  \r\n");       //Descripción de la salida del programa
Console.WriteLine();
double sumaCorriente = 0;       // Variable para almacenar la suma de las mediciones de corriente
double cantidadNormal = 0;      // Variable para almacenar la cantidad de mediciones normales
double cantidadSobrecorriente = 0;      // Variable para almacenar la cantidad de sobrecorrientes
for (int i = 1; i <= 8; i++)
{
    Console.Write($"Ingrese la medición {i} de corriente (en amperios): "); // Solicita al usuario que ingrese la medición de corriente
    double medicion = Convert.ToDouble(Console.ReadLine());                 // Convierte la entrada del usuario a un número de tipo double
    sumaCorriente += medicion;                                       // O también: sumaCorriente = sumaCorriente + medicion;
    if (medicion <= 5)                                             // Si la medición es menor o igual a 5 A
    {
        cantidadNormal++;                                      // Incrementa la cantidad de mediciones normales
        Console.WriteLine("MEDICIÓN NORMAL.");                    // Muestra que la medición es normal
    }
    else                                                // Si la medición es mayor a 5 A
    {
        cantidadSobrecorriente++;                                    // Incrementa la cantidad de sobrecorrientes
        Console.WriteLine("SOBRECORRIENTE DETECTADA.");             // Muestra que se detectó una sobrecorriente
    }
}
    double corrientePromedio = sumaCorriente / 8;                                     // Calcula la corriente promedio dividiendo la suma de las mediciones entre 8
    Console.WriteLine($"\nCorriente promedio: {corrientePromedio} A");                // Muestra la corriente promedio
    Console.WriteLine($"Cantidad de mediciones normales: {cantidadNormal}");            // Muestra la cantidad de mediciones normales
    Console.WriteLine($"Cantidad de sobrecorrientes: {cantidadSobrecorriente}");           // Muestra la cantidad de sobrecorrientes
    if (cantidadSobrecorriente == 0)                                                    // Si no se detectó ninguna sobrecorriente
    {
        Console.WriteLine("ACTUADOR APROBADO.");                                        // Muestra que el actuador está aprobado
    }
    else                                                                            // Si se detectó una o más sobrecorrientes
    {
        Console.WriteLine("EL ACTUADOR REQUIERE REVISIÓN.");                            // Muestra que el actuador requiere revisión
    }