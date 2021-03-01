using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Selecciona una función");

                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Ceiling");
                Console.WriteLine("6. Floor");
                Console.WriteLine("7. Potencia");
                Console.WriteLine("8. Raíz");
                string option = Console.ReadLine();

                if (option.Trim() == "1")
                {
                    Console.WriteLine("\nIngresa el primero numero: ");
                    float numero1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("\nIngresa el segundo numero: ");
                    float numero2 = float.Parse(Console.ReadLine());

                    float resultadoSuma = CustomMath.Sumar(numero1, numero2);

                    Console.WriteLine($"\nEl resultado de la suma es: {resultadoSuma}\n");
                }
                else if (option.Trim() == "2")
                {
                    Console.WriteLine("el resultado es "+ CustomMath.Resta());
                   
                }
                else if (option.Trim() == "3")
                {

                }
                else if (option.Trim() == "4")
                {
                    Console.WriteLine("Digite el dividendo");
                    double dividendo= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite el divisor");
                    double divisor= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CustomMath.Dividir(dividendo, divisor)+" \n");
                }
                else if (option.Trim() == "5")
                {

                }
                else if (option.Trim() == "6")
                {
                    double numero1;
                    Console.WriteLine("Intoduce un número");
                    numero1=Double.Parse(Console.ReadLine());
                    Console.WriteLine("el resultado es = " + Math.Floor(numero1));
                }
                else if (option.Trim() == "7")
                {
                    Console.WriteLine("Ingresa el numero base");
                    int numeroBase = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Ingresa la potencia que le deseas aplicar");
                    int potencia = int.Parse(Console.ReadLine());

                    Console.WriteLine("El resultado de la operación es: " + CustomMath.Potencia(numeroBase, potencia));
                    
                }
                else if (option.Trim() == "8")
                {

                }
                else if(option.Trim() == "9")
                {
                    Console.WriteLine(CustomMath.Echo());
                }
                else
                    break;
            }
        }
    }
}
