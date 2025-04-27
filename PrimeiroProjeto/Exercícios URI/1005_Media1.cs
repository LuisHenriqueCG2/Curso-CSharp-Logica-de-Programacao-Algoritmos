using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1005_Media1
    {
        public void Media1()
        {
            double pesoA = 3.5;
            double pesoB = 7.5;

            double notaA, notaB;
            double media;

            notaA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaB = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((notaA * pesoA) + (notaB * pesoB)) / (pesoA + pesoB);

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
