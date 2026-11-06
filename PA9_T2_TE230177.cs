Console.WriteLine("SISTEMA DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase Motor
Motor motor1 = new Motor();

// Capturar la información del objeto 
Console.Write("Ingrese el ID del motor: ");
motor1.Identificador = Console.ReadLine() ?? "Sin ID";

Console.Write("Ingrese la temperatura del motor: ");
motor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente del motor: ");
motor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad del motor: ");
motor1.Velocidad = Convert.ToDouble(Console.ReadLine());


// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Motor: {motor1.Identificador}");
Console.WriteLine($"Temperatura: {motor1.Temperatura:F2}");
Console.WriteLine($"Corriente: {motor1.Corriente:F2}");
Console.WriteLine($"Velocidad: {motor1.Velocidad:F2}");
Console.WriteLine(motor1.CalcularTemperatura());
Console.WriteLine($"Estado: {motor1.ObtenerEstado()}");

// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";

    public double Temperatura { get; set; }

    public double Corriente { get; set; }

    public double Velocidad { get; set; }

    // Método para evaluar la temperatura y devolver mensaje
    public string CalcularTemperatura()
    {
        if (Temperatura > 70)
            return "Advertencia: La temperatura del motor es mayor a 70 grados.";
        else
            return "Temperatura dentro de lo normal.";
    }

    // Método para determinar si el motor esta en marcha o detenido
    public string ObtenerEstado()
    {
        if (Velocidad > 0)
            return "EN MARCHA";
        else
            return "DETENIDO";
    }
}
