Console.WriteLine("Problemario #1: Ciclos y Estructuras en C#.");           //Nombre del problemario
Console.WriteLine("Ejercicio 5:  \r\nDiseñe un programa que permita analizar la vibración de varios motores. Para cada motor, el \r\nprograma deberá:  ");       //Nombre del ejercicio y descripción
Console.WriteLine("a) Solicitar el nombre o identificador del motor. \r\nb) Pedir cuatro mediciones de vibración mediante un ciclo for. \r\nc) Calcular la vibración promedio. \r\nd) Clasificar el estado del motor. \r\ne) Preguntar si se desea analizar otro motor.");              //Descripción de los datos de entrada
Console.WriteLine();
Console.WriteLine("La repetición de motores se controlará mediante un ciclo while. Utilizar la siguiente \r\nclasificación: \r\n• Promedio menor o igual que 4.5 mm/s: FUNCIONAMIENTO NORMAL DEL MOTOR. \r\n• Promedio mayor que 4.5 mm/s: EL MOTOR REQUIERE MANTENIMIENTO.");       //Descripción de la salida del programa
Console.WriteLine("\r\nAl finalizar completamente el programa, deberá mostrar: \r\na) Total de motores evaluados. \r\nb) Cantidad de motores con funcionamiento normal. \r\nc) Cantidad de motores que requieren mantenimiento. ");       //Descripción de la salida del programa
Console.WriteLine();
int motoresEvaluados = 0;                       // Variable para contar la cantidad de motores evaluados
int motoresFuncionamientoNormal = 0;               // Variable para contar la cantidad de motores con funcionamiento normal
int motoresRequierenMantenimiento = 0;              // Variable para contar la cantidad de motores que requieren mantenimiento
string respuesta = "s";                                 // Variable para controlar la repetición del ciclo while
while (respuesta == "s")                                   // Ciclo while para analizar varios motores
{
    Console.WriteLine("Ingrese el nombre o identificador del motor");           // Solicitar el nombre o identificador del motor
    string motor = Console.ReadLine();                      // Leer el nombre o identificador del motor
    double sumaVibracion = 0;                               // Variable para almacenar la suma de las mediciones de vibración
    for (int i = 1; i <= 4; i++)                             // Ciclo for para pedir cuatro mediciones de vibración
    {
        Console.WriteLine($"Ingrese las cuatro mediciones de vibración del motor {motor} (en mm/s):");          // Solicitar las cuatro mediciones de vibración del motor
        Console.WriteLine($"Medición {i}:");                                                    // Solicitar la medición de vibración número i
        double medicion = Convert.ToDouble(Console.ReadLine());                                     // Leer la medición de vibración número i
        sumaVibracion += medicion;                                                                          // Sumar la medición de vibración número i a la suma total
    }
    double vibracionPromedio = sumaVibracion / 4;                                                       // Calcular la vibración promedio del motor
    motoresEvaluados++;                                                                                 // Incrementar la cantidad de motores evaluados
    if (vibracionPromedio <= 4.5)                                                                       // Clasificar el estado del motor según la vibración promedio
    {
        Console.WriteLine($"El motor {motor} tiene un funcionamiento normal con una vibración promedio de {vibracionPromedio} mm/s.");          // Mostrar mensaje de funcionamiento normal del motor
        motoresFuncionamientoNormal++;                                                  // Incrementar la cantidad de motores con funcionamiento normal
    }
    else
    {
        Console.WriteLine($"El motor {motor} requiere mantenimiento con una vibración promedio de {vibracionPromedio} mm/s.");              // Mostrar mensaje de motor que requiere mantenimiento
        motoresRequierenMantenimiento++;                                                                                                  // Incrementar la cantidad de motores que requieren mantenimiento
    }
    Console.WriteLine("¿Desea analizar otro motor? (s/n)");                                             // Preguntar si se desea analizar otro motor
    respuesta = Console.ReadLine().ToLower();                                                               // Leer la respuesta del usuario y convertirla a minúsculas
    Console.WriteLine();                                                                                      // Salto de línea para mejorar la legibilidad
}
Console.WriteLine($"Cantidad de motores evaluados:{motoresEvaluados}");                                         // Mostrar la cantidad de motores evaluados
Console.WriteLine($"Cantidad de motores con funcionamiento normal:{motoresFuncionamientoNormal}");              // Mostrar la cantidad de motores con funcionamiento normal
Console.WriteLine($"Cantidad de motores que requieren mantenimiento:{motoresRequierenMantenimiento}");          // Mostrar la cantidad de motores que requieren mantenimiento