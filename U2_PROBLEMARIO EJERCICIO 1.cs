Console.WriteLine("Problemario #1: Ciclos y Estructuras en C#.");               //Nombre del programa
Console.WriteLine("Ejercicio 1: Diseñe un programa que solicite al usuario el voltaje y la corriente consumida por un motor de \r\ncorriente directa. El programa deberá calcular la potencia eléctrica mediante: P:VI");       //Descripción del programa
Console.WriteLine("El programa deberá calcular la potencia eléctrica mediante: P=V*I.");       //Instrucción del programa
Console.WriteLine();
Console.WriteLine("Después deberá clasificar el funcionamiento del motor de acuerdo con lo siguiente:  \r\na) Si la potencia es menor o igual a 120 W, mostrar: CONSUMO NORMAL.  \r\nb) Si la potencia es mayor que 120 W, mostrar: ADVERTENCIA: CONSUMO ELEVADO. ");          //Instrucción del programa           
Console.WriteLine("Ingrese el voltaje (V): ");                  //Solicitar al usuario el voltaje                                               
double voltaje = Convert.ToDouble(Console.ReadLine());                //Convertir el voltaje a tipo double                                           
Console.WriteLine("Ingrese la corriente (I): ");                    //Solicitar al usuario la corriente                                         
double corriente = Convert.ToDouble(Console.ReadLine());                      //Convertir la corriente a tipo double                                    
double potencia = voltaje * corriente;                                        //Calcular la potencia eléctrica mediante la fórmula P=V*I                         
Console.WriteLine($"La potencia eléctrica es: {potencia} W");                      //Mostrar la potencia eléctrica calculada                    
Console.WriteLine();                                                                  //Espacio en blanco para mejorar la legibilidad                 
if (potencia <= 120)                                                                //Condición para clasificar el funcionamiento del motor                   
{
    Console.WriteLine("CONSUMO NORMAL.");                                           //Mostrar mensaje de consumo normal si la potencia es menor o igual a 120 W
}
else
{
    Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO.");                             //Mostrar mensaje de advertencia si la potencia es mayor a 120 W
}