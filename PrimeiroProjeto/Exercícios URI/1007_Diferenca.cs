using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1007_Diferenca
    {
        public void Diferenca() {
            int A, B, C, D, Diferenca;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            Diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + Diferenca);
        }
    }
}
