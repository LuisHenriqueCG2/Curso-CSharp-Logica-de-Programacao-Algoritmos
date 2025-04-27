using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1017_GastoCombustivel
    {
        public void GastoCombustivel()
        {
            int tempoGasto, velocidadeMedia, distanciaPercorrida;
            double litros;

            tempoGasto = int.Parse(Console.ReadLine());

            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempoGasto * velocidadeMedia;

            litros = distanciaPercorrida / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
