using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1015_DistanciaEntreDoisPontos
    {
        public void DistanciaEntreDoidPontos()
        {
            double x1, y1, x2, y2, distancia;
            String[] valores1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores1[1], CultureInfo.InvariantCulture);

            String[] valores2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0)); ;

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
