Console.WriteLine("EJERCICIO_5");                                               //Numero de la practica
Console.WriteLine("PROMEDIO DE CINCO CALIFICACIONES");               //Nombre del ejercicio
Console.WriteLine();                                                            //Instruccion para dejar un espacio en blanco en la consola
double suma = 0;
for (int numero = 1; numero <= 5; numero++)
{
    Console.WriteLine();
    Console.Write($"Ingrese la calificación {numero}: ");
    double calificacion = Convert.ToDouble(Console.ReadLine());
    suma = suma + calificacion;
}
double promedio = suma / 5.0;
Console.WriteLine();
Console.WriteLine($"El promedio es: {promedio:F2}");                            //Muestra el promedio en la consola
Console.WriteLine();
if (promedio >= 90)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno excelente.");                        //Mensaje de aprobación
}
else if (promedio < 90 && promedio >= 80)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno bueno.");                        //Mensaje de aprobación
}
else if (promedio < 80 && promedio >= 70)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno regular.");                        //Mensaje de aprobación
}
else if (promedio < 70 && promedio >= 50)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno requiere apoyo.");                        //Mensaje de reprobación
}
else if (promedio < 50)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno deficiente.");                        //Mensaje de reprobación
}