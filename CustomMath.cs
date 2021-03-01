using System;

namespace SimpleMath
{
    public static class CustomMath
    {
        public static double Dividir(double dividendo, double divisor)
        {
            double cociente = (dividendo/ divisor);
            return cociente;
        }
        public static double Resta()
        {
            double resultado;
            Console.WriteLine("ingrese primer valor");
            int valor1 =Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese segundo valor valor");
            int valor2 = Int32.Parse(Console.ReadLine());

            resultado = valor1-valor2;
            return resultado;
        }
        public static float Sumar(float numero1, float numero2)
        {
            return numero1 + numero2;
        }
        public static string Echo(string value = "Default value")
        {
            return value;
        }
        public static int Potencia(int numeroBase, int potencia)
        {
            int resultado = numeroBase;
            
            for(int i = 1; i < potencia; i++){
                resultado = resultado * numeroBase;
            }

            return resultado;
        }
    }
}