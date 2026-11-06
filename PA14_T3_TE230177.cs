class Program
{
    static void Main()
    {
        Console.WriteLine("SISTEMA DE MONITOREO DE SENSORES INDUSTRIALES");
        Console.WriteLine("1. Sensor de temperatura");
        Console.WriteLine("2. Sensor de presión");
        Console.WriteLine("3. Sensor de distancia");
        Console.Write("Seleccione el tipo de sensor (1-3): ");
        char teclaOpcion = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int.TryParse(teclaOpcion.ToString(), out int opcion);

        // Evaluación de la opción seleccionada
        switch (opcion)
        {
            case 1:
                SensorTemperatura temp1 = new SensorTemperatura();
                temp1.CapturarDatosBase();
                temp1.ValorMedio = LeerValor("Ingrese la temperatura (°C): ");
                temp1.MostrarDatos();
                Console.WriteLine($"Temperatura: {temp1.ValorMedio} °C");
                Console.WriteLine($"Evaluación: {temp1.EvaluarTemperatura()}");
                break;

            case 2:
                SensorPresion pres1 = new SensorPresion();
                pres1.CapturarDatosBase();
                pres1.ValorMedio = LeerValor("Ingrese la presión (bar): ");
                pres1.MostrarDatos();
                Console.WriteLine($"Presión: {pres1.ValorMedio} bar");
                Console.WriteLine($"Evaluación: {pres1.EvaluarPresion()}");
                break;

            case 3:
                SensorDistancia dist1 = new SensorDistancia();
                dist1.CapturarDatosBase();
                dist1.ValorMedio = LeerValor("Ingrese la distancia (cm): ");
                dist1.MostrarDatos();
                Console.WriteLine($"Distancia: {dist1.ValorMedio} cm");
                Console.WriteLine($"Evaluación: {dist1.EvaluarDistancia()}");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
    // Método para leer un valor numérico desde la consola
    static double LeerValor(string mensaje)
    {
        double valor;

        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine() ?? "";

            if (double.TryParse(entrada, out valor))
                return valor;

            Console.WriteLine("Entrada no válida. Ingrese un número.");
        }
    }
}
// CLASE BASE
class Sensor
{
    public string Identificador { get; set; } = "";
    public double ValorMedio { get; set; }
    public bool Activo { get; set; }
    public void CapturarDatosBase()
    {
        Console.Write("Ingrese el identificador del sensor: ");
        Identificador = Console.ReadLine() ?? "Sin identificador";

        Console.Write("¿El sensor está activo? (s o n): ");

        char teclaActivo = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Activo = teclaActivo == 's';
    }
    public void MostrarDatos()
    {
        Console.WriteLine("\nDATOS DEL SENSOR");
        Console.WriteLine($"Sensor: {Identificador}");
        Console.WriteLine($"Valor medido: {ValorMedio}");
        Console.WriteLine($"Estado: {ObtenerEstado()}");
    }
    public string ObtenerEstado()
    {
        return Activo ? "Sensor activo" : "Sensor inactivo";
    }
}
// CLASES DERIVADAS
class SensorTemperatura : Sensor
{
    public string EvaluarTemperatura()
    {
        if (ValorMedio > 80)
            return "REQUIERE ATENCIÓN: Supera el límite de 80 °C";

        return "Dentro del criterio establecido";
    }
}
class SensorPresion : Sensor
{
    public string EvaluarPresion()
    {
        if (ValorMedio > 10)
            return "REQUIERE ATENCIÓN: Supera el límite de 10 bar";

        return "Dentro del criterio establecido";
    }
}
class SensorDistancia : Sensor
{
    public string EvaluarDistancia()
    {
        if (ValorMedio < 20)
            return "REQUIERE ATENCIÓN: Objeto a menos de 20 cm";

        return "Dentro del criterio establecido";
    }
}