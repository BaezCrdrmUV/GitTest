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

                if(option.Trim() == "1")
                {

                }
                else if(option.Trim() == "2")
                {

                }
                else if(option.Trim() == "3")
                {

                }
                else if(option.Trim() == "4")
                {
                    Console.WriteLine("Digite el dividendo");
                    double dividendo= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite el divisor");
                    double divisor= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(CustomMath.Dividir(dividendo, divisor)+" \n");
                }
                else if(option.Trim() == "5")
                {

                }
                else if(option.Trim() == "6")
                {

                }
                else if(option.Trim() == "7")
                {

                }
                else if(option.Trim() == "8")
                {

                }
                else 
                    break;
            }
        }
    }
}
