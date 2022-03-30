using DemoRectangulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            
            Console.WriteLine("Ingrese las coordenadas del rectangulo");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ingrese las coordenadas x1 y y1");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            rectangulo.p1 = new Punto(x1, y1);
            Console.WriteLine("Ingrese las coordenadas x2 y y2");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas x3 y y3");
            rectangulo.p2 = new Punto(x2, y2);
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las coordenadas x4 y y4");
            rectangulo.p3 = new Punto(x3, y3);
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            rectangulo.p4 = new Punto(x4, y4);

            double base1;
            double altura1;
            double base2;
            double altura2;
            double res1;
            double res2;
            
            base1 = rectangulo.HallarDistancia1();
            altura1= rectangulo.HallarDistancia2();          
            base2 = rectangulo.HallarDistancia3();
            altura2 = rectangulo.HallarDistancia4();
            res1 = rectangulo.CalcularArea();
            res2 = rectangulo.CalcularPerimetro();

            if (base1 == base2 && altura1 == altura2)
            {
                Console.WriteLine("El área del rectangulo es: " + res1);
                Console.WriteLine("El perimetro del rectangulo es: " + res2);
            }
            else
            {
                Console.WriteLine("Los datos ingresados no son el de un rectangulo");
            }
            Console.Read();
        }
    }
}