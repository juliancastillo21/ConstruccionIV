        
        //Declaramos variables iniciales        
        int Intentos = 1;
        string Respuesta1 = "gato";
        string Respuesta2 = "en";
        string Respuesta3 = "jardin";
        
        string Respuestaval1 = "no";
        string Respuestaval2 = "no";
        string Respuestaval3 = "no";
        
        int aciertos = 0;
        
        
        while (Intentos < 11)
        {
            
            if (aciertos == 0)
            
            Console.WriteLine("El ____ juega __ el ______");
            Console.WriteLine("intento #"+Intentos);
            Console.Write("Por favor, ingresa su respuesta: ");
            string Respuesta = Console.ReadLine();
            
            if (Respuesta != Respuesta1 && Respuesta != Respuesta2 && Respuesta != Respuesta3 )
            {
                Console.WriteLine("La palabra es incorrecta");
                Intentos++;
                if (Intentos == 11)
                {
                    Console.WriteLine("Has perdido , utilizaste tus 10 intentos");
                }
                
            }    
            else 
            {   
                aciertos = aciertos +1 ;
                
                if (aciertos == 1)
                {
                    // Identificar cual de las 3 palabras encontrò el usuario 
                    if (Respuesta == Respuesta1 )
                    {
                         Respuestaval1 = "si";
                         Console.WriteLine("La palabra es correcta");
                         Console.WriteLine("El gato juega __ el ______");
                    
                    }   
                    
                    if (Respuesta == Respuesta2 )
                    {
                        Respuestaval2 = "si";
                        Console.WriteLine("La palabra es correcta");
                        Console.WriteLine("El ____ juega en el ______");
                    
                    }  
                    
                    if (Respuesta == Respuesta3 )
                    {
                        Respuestaval3 = "si";
                        Console.WriteLine("La palabra es correcta");
                        Console.WriteLine("El ____ juega __ el jardin");
                    
                    }  
                    
                    Console.WriteLine(aciertos);
                    
                
                }
                
                if (aciertos == 2)
                {
                    if (Respuesta == Respuesta1 )
                    {
                         Respuestaval1 = "si";
                         Console.WriteLine("La palabra es correcta");
                    }   
                    
                    if (Respuesta == Respuesta2 )
                    {
                        Respuestaval2 = "si";
                        Console.WriteLine("La palabra es correcta");
                    }  
                    
                    if (Respuesta == Respuesta3 )
                    {
                        Respuestaval3 = "si";
                        Console.WriteLine("La palabra es correcta");
                    }  
                
                    if (Respuestaval1 == "si" && Respuestaval2 == "si" && Respuestaval3 == "no")
                    {
                        Console.WriteLine("El gato juega en el ______");
                    }
                    
                    if (Respuestaval1 == "si" && Respuestaval2 == "no" && Respuestaval3 == "si")
                    {
                        Console.WriteLine("El gato juega __ el jardin");
                    }
                    
                    if (Respuestaval1 == "no" && Respuestaval2 == "si" && Respuestaval3 == "si")
                    {
                        Console.WriteLine("El ____ juega en el jardin");
                    }
                    
                }
                
                if (aciertos == 3)
                {
                    Console.WriteLine("El gato juega en el jardin");
                    Console.WriteLine("Felicitaciones !!!!!! Has encontrado las 3 palabras");
                    Intentos = 12;
                }
                
                
            }               
        }