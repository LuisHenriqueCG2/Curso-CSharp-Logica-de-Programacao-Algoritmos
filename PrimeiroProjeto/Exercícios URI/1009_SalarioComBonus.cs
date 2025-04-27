using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Exercícios_URI
{
    public class _1009_SalarioComBonus
    {
       public void SalarioComBonus()
        {
            string nome;
            double salario, venda, totalSalario;
            double percComissao = 0.15;

            nome = Console.ReadLine();

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            venda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalSalario = (venda * percComissao) + salario;

            Console.WriteLine("TOTAL = R$ " + totalSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
