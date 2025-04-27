using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1019_ConversaoDeTempo
    {
        public void ConversaoTempo()
        {
            int tempo, horas, minutos, segundos, resto;

            tempo = int.Parse(Console.ReadLine());

            horas = tempo / 3600;
            resto = tempo % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
