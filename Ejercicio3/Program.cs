// Solicitar al usuario que ingrese un número
Console.WriteLine("Digite un número:");
int num = Int32.Parse(Console.ReadLine());

// Definir la función que verifica si un número es especial
bool numEs(int num)
{
    // Verificar si el número cumple con los criterios de ser especial
    return num % 5 == 0 && num % 2 != 0 && num % 3 != 0 && Suma(num);
}

// Verificar si el número ingresado es especial y mostrar el resultado
if (numEs(num))
{
    Console.WriteLine("¡Es un número especial!");
}
else
{
    Console.WriteLine("No es un número especial.");
}

// Definir la función que calcula la suma de los dígitos del número
bool Suma(int num)
{
    int suma = 0;
    foreach (char Lnum in num.ToString())
    {
        // Convertir el dígito de tipo char a int y sumarlo
        int digito = Int32.Parse(Lnum.ToString());
        suma += digito;
    }
    // Verificar si la suma de los dígitos es mayor a 10
    return suma > 10;
}