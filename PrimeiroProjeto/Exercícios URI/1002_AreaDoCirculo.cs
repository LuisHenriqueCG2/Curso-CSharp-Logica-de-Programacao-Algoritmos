using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1002_AreaDoCirculo
    {
        public void AreaDoCirculo() {
            
            double Raio, Area, PI;
            PI = 3.14159;
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = PI * Raio * Raio;
            Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture));
        }
       
    }
}
