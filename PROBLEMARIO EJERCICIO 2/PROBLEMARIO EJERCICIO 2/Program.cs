Console.WriteLine("Problemario #1: Ciclos y Estructuras en C#.");                   //Nombre del problemario
Console.WriteLine("Ejercicio 2:  Ejercicio 2:  \r\nUn sensor mide diez veces la temperatura de un motor. Diseñe un programa en el que se \r\nescriba una sola vez las instrucciones para solicitar las diez mediciones, sumarlas y calcular la \r\ntemperatura promedio. El programa deberá indicar:");         //Nombre del ejercicio y enunciado
Console.WriteLine("a) TEMPERATURA NORMAL, si el promedio es menor o igual que 70 °C.  \r\nb) ALERTA DE TEMPERATURA, si el promedio es mayor que 70 °C. ");              //Indicaciones del ejercicio
Console.WriteLine();
double suma = 0;                        //Variable para almacenar la suma de las mediciones
for (int i = 1; i <= 10; i++)               //Ciclo para solicitar las mediciones
{
    Console.Write($"Ingrese la medición {i}: ");                        //Solicita la medición al usuario
    double temperatura = Convert.ToDouble(Console.ReadLine());                      //Convierte la medición a double
    suma = suma+temperatura;                                                    //Suma las mediciones
}
double promedio = suma / 10;                                                    //Calcula el promedio de las mediciones
Console.WriteLine($"El promedio de las mediciones es: {promedio} °C");              //Muestra el promedio de las mediciones
if (promedio <= 70)                                                             //Condición para determinar si la temperatura es normal o alerta
{
    Console.WriteLine("TEMPERATURA NORMAL.");                                       //Muestra el mensaje de temperatura normal
}
else
{
    Console.WriteLine("ALERTA DE TEMPERATURA.");                                        //Muestra el mensaje de alerta de temperatura
}