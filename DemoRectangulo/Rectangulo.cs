using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    class Rectangulo
    {
        public Punto p1 { get; set; }
        public Punto p2 { get; set; }
        public Punto p3 { get; set; }
        public Punto p4 { get; set; }

        //public double x1 {get; set;}
        //public double x2 { get; set; }
        //public double x3 { get; set; }
        //public double x4 { get; set; }
        //public double y1 { get; set; }
        //public double y2 { get; set; }
        //public double y3 { get; set; }
        //public double y4 { get; set; }

        public double HallarDistancia1( )
        {
            return Math.Sqrt((Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2)));
        }
        public double HallarDistancia2()
        {
            return Math.Sqrt((Math.Pow((p3.x - p2.x), 2) + Math.Pow((p3.y - p2.y), 2)));
        }
        public double HallarDistancia3()
        {
            return Math.Sqrt((Math.Pow((p4.x - p3.x), 2) + Math.Pow((p4.y - p3.y), 2)));
        }
        public double HallarDistancia4()
        {
            return Math.Sqrt((Math.Pow((p1.x - p4.x), 2) + Math.Pow((p1.y - p4.y), 2)));
        }
        public double CalcularArea()
        {
            return HallarDistancia1() * HallarDistancia2();
        }
        public double CalcularPerimetro()
        {
            return 2*(HallarDistancia1() + HallarDistancia2()); 
        }
    }
}