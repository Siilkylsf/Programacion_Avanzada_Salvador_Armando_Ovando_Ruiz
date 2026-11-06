Console.WriteLine("EJERCICIO_3");                                               //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");               //Nombre del ejercicio
Console.WriteLine();                                                            //Instruccion para dejar un espacio en blanco en la consola
Console.Write("Ingrese la primera calificación: ");
double calificacion1 = Convert.ToDouble(Console.ReadLine());                //Declaramos la variable 1
Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());                //Declaramos la variable 2
Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());                //Declaramos la variable 3
double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0;    //Calculo del promedio de las calificaciones, redondeado a 2 decimales
Console.WriteLine();
Console.WriteLine($"El promedio es: {promedio:F2}");                            //Muestra el promedio en la consola
Console.WriteLine();
if (promedio >= 90)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno excelente.");                        //Mensaje de aprobación
}
else if (promedio < 90 && promedio >=80)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno bueno.");                        //Mensaje de aprobación
}
else if (promedio < 80 && promedio >=70)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno regular.");                        //Mensaje de aprobación
}
else if (promedio < 70 && promedio >=50)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno requiere apoyo.");                        //Mensaje de reprobación
}
else if (promedio <= 50)                                                                 //Condición para determinar si el promedio es aprobado o reprobado
{
    Console.WriteLine("Alumno deficiente.");                        //Mensaje de reprobación
}