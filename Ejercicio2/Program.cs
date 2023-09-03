Console.Write("Ingrese el inicio del rango: ");
int rangoInicio = int.Parse(Console.ReadLine());

Console.Write("Ingrese el fin del rango: ");
int rangoFin = int.Parse(Console.ReadLine());
Console.WriteLine("******");

// Crear un generador de números aleatorios
Random random = new Random();

// Ejecuta a través de los números en el rango especificado
for (int numero = rangoInicio; numero <= rangoFin; numero++)
{
    // Mostrar la tabla de multiplicar para el número actual
    Console.WriteLine($"Tabla de multiplicar del {numero}:");

    // Elegir aleatoriamente un número para ocultar
    int numeroOculto = random.Next(1, 11);

    // Ejecuta del 1 al 10 y mostrar la multiplicación
    for (int i = 1; i <= 10; i++)
    {
        // Ocultar el resultado si es igual al número oculto
        if (i == numeroOculto)
        {
            Console.WriteLine($"{numero} X ? = {numero * i}");
        }
        else
        {
            Console.WriteLine($"{numero} X {i} = {numero * i}");
        }
    }
    Console.Write("Ingrese el número faltante: ");
    int respuestaUsuario = int.Parse(Console.ReadLine());

    // Verificar si la respuesta es correcta
    if (respuestaUsuario == numeroOculto)
    {
        Console.WriteLine("¡Correcto!");
    }
    else
    {
        Console.WriteLine($"Incorrecto. El número faltante era {numeroOculto}");
    }
}