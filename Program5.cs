using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;            
                System.Threading.Thread Centimetros1 = new System.Threading.Thread(new ThreadStart(Centimetros));
                Centimetros1.Start();                                 
        }
        public static void Centimetros()
        {
            double talla, peso, imc;
            Console.WriteLine("Ingrese Su Talla (Centimetros) : ");
            talla = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese Su Peso  (Kilogramos)  : ");
            peso = Convert.ToDouble(Console.ReadLine());
            talla = cuadrado(talla);
            imc = calcularimc(talla, peso);
            int imc2 = Convert.ToInt32(imc);
            Console.WriteLine("Su Indice de Masa Corporal es : " + imc2);
            cc(imc);
            Console.ReadKey();
        }
        public static double cuadrado(double cm)
        {
            double m, m2;
            m = cm / 100;
            m2 = m * m;
            return m2;
        }
        public static double calcularimc(double m2, double kg)
        {
            double imc;
            imc = kg / m2;
            return imc;
        }
        static void cc(double imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine("Peso Inferior al NORMAL");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso NORMAL");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Peso Superior al NORMAL");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("OBESIDAD");
            }
        }
    }
}
