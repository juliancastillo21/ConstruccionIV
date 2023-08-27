/*Ejercicio 1: Calculadora de Fracciones
Objetivo: Crear una calculadora que maneje fracciones. El usuario ingresará dos fracciones y un operador.
La calculadora deberá realizar la operación. Debes manejar sumas, restas, multiplicaciones y divisiones.
Si el usuario intenta dividir entre cero, deberás mostrar un mensaje de error.*/

int opcion;

do{
    Console.WriteLine("************Menú***********");
    Console.WriteLine("Opción 1. Sumar");
    Console.WriteLine("Opción 2. Restar");
    Console.WriteLine("Opción 3. Multiplicar");
    Console.WriteLine("Opción 4. Dividir");
    Console.WriteLine("Opción 5. Saliir");

    //Declarar Variables
    float numerador1, denominador1,numerador2, denominador2,resultado1,resultado2,resultado3,resultadofinal;
    opcion=Convert.ToInt32(Console.ReadLine());
    switch(opcion){

        case 1:
        Console.WriteLine("HA SELECCIONADO - SUMAR");
        Console.WriteLine("Digite el numerador de la primer fraccion");
        numerador1=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el denominador de la primer fraccion");
        denominador1=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el numerador de la segunda fraccion");
        numerador2=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el denominador de la segunda fraccion");
        denominador2=float.Parse(Console.ReadLine());
        resultado1=numerador1*denominador2;
        resultado2=numerador2*denominador1;
        resultado3=denominador1*denominador2;
        resultadofinal=(resultado1+resultado2)/resultado3;//suma resultado de la multiplicacion 1 y 2 - divide por multi de denominadores
        Console.WriteLine("La suma de la fracion es:"+resultadofinal);
        break;

        case 2:
        Console.WriteLine("HA SELECCIONADO - RESTAR");
        Console.WriteLine("Digite el numerador de la primer fraccion");
        numerador1=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el denominador de la primer fraccion");
        denominador1=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el numerador de la segunda fraccion");
        numerador2=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el denominador de la segunda fraccion");
        denominador2=float.Parse(Console.ReadLine());
        resultado1=numerador1*denominador2;
        resultado2=numerador2*denominador1;
        resultado3=denominador1*denominador2;
        resultadofinal=(resultado1-resultado2)/resultado3;//resta resultado de la multiplicacion 1 y 2 - divide por multi de denominadores
        Console.WriteLine("La resta de la fracion es:"+resultadofinal);
        break;

        case 3:
        Console.WriteLine("HA SELECCIONADO - MULTIPLICAR");
        Console.WriteLine("Digite el numerador de la primer fraccion");
        numerador1=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el denominador de la primer fraccion");
        denominador1=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el numerador de la segunda fraccion");
        numerador2=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el denominador de la segunda fraccion");
        denominador2=float.Parse(Console.ReadLine());
        resultado1=numerador1*numerador2;
        resultado2=denominador1*denominador2;
        resultadofinal=resultado1/resultado2;
        Console.WriteLine("El resultado de la multiplicacion es:"+resultadofinal);
        break;

        case 4:
        Console.WriteLine("HA SELECCIONADO - DIVIDIR");
        Console.WriteLine("Digite el numerador de la primer fraccion");
        numerador1=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el denominador de la primer fraccion");
        denominador1=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el numerador de la segunda fraccion");
        numerador2=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite el denominador de la segunda fraccion");
        denominador2=float.Parse(Console.ReadLine());
        if(denominador1==0 || denominador2==0){
            Console.WriteLine("Error!! no se puede dividir entre cero");
        }else{
            resultado1=numerador1*denominador2;
            resultado2=numerador2*denominador1;
            resultadofinal=resultado1/resultado2;
            Console.WriteLine("El resultado de la división de fracciones es:"+resultadofinal);
        }
        break;

        case 5:
        Console.WriteLine("Ha Seleccionado Salir");
        break;

        default:
        Console.WriteLine("Opción no valida");
        break;
    }
}while(opcion!=5);
