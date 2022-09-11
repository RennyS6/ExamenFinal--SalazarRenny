using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenFinal_SalazarRenny
{
    public class FiguraGeometrica 
    {
        string name;
        

       // List<IPoligono> poligonos = new List<IPoligono>();
        

         public interface IPoligono
        {
            public  double lado1 { get; set; }
            public  double lado2 { get; set; }

            public double area(double valor1, double valor2)
            {

                double totalArea = valor1 * valor2;
                return totalArea;

            }

            public double perimetro(double valor1, double valor2)
            {
                double totalPerimetro = (2 * valor1) + (2 * valor2);
                return totalPerimetro;
            }
        }

       public class Triangulo : FiguraGeometrica
        {
            
        }
       public class Rectangulo : FiguraGeometrica
        {
            
        }
       public class Paralelogramo : FiguraGeometrica
        {
            
        }

    }
}
