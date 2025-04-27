using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1013_OMaior
    {
       public void OMaior()
        {
            int A, B, C, MaiorAB;

            String[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0], CultureInfo.InvariantCulture);
            B = int.Parse(valores[1], CultureInfo.InvariantCulture);
            C = int.Parse(valores[2], CultureInfo.InvariantCulture);

            MaiorAB = Math.Max(A, Math.Max(B, C));

            Console.WriteLine(MaiorAB.ToString(CultureInfo.InvariantCulture) + " eh o maior");
        }
    }
}
