using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1014_Consumo
    {
        public void Consumo()
        {
            int distancia;
            double totalCombustivel, consumoMedio;

            distancia = int.Parse(Console.ReadLine());
            totalCombustivel = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distancia / totalCombustivel;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " " + "km/l");
        }
    }
}
