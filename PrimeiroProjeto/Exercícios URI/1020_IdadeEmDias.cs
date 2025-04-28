using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1020_IdadeEmDias
    {
        public void IdadeEmDias()
        {
            int idade, ano, mes, dia, resto;

            idade = int.Parse(Console.ReadLine());

            ano = idade / 365;
            resto = idade % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " anos(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
