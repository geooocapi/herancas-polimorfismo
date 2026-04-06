using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Frete
{
    internal class entreganormal : entrega
    {
        public override void calcularFrete()
        {
            Console.WriteLine("Insira o nome do remetente");
            nomeRemetente = Console.ReadLine();
            Console.WriteLine("Insira a quilometragem");
            km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o peso do pacote");
            peso = Convert.ToDouble(Console.ReadLine());

            valorFrete = (km * 5) + (peso * 5);
            Console.WriteLine("O valor do frete normal é: " + valorFrete);
        }

    }
}
