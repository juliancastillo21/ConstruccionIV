Console.WriteLine("TABLAS DE MULTIPLICAR");

Console.Write("Ingrese el inicio del rango: ");
int rangoInicio = int.Parse(Console.ReadLine());

Console.Write("Ingrese el fin del rango: ");
int rangoFin = int.Parse(Console.ReadLine());
Console.Write("**************\n");

for (int numero = rangoInicio; numero <= rangoFin; numero++) {
        Console.WriteLine($"Tabla de multiplicar del {numero}:");
    for(int i=1; i<=10;i++){
        Console.WriteLine(numero + " X " + i + " = " + numero*i);
    }
}