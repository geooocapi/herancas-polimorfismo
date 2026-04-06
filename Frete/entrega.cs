using System;
using System.Collections.Generic;
using System.Text;

namespace Frete
{
    public abstract class entrega
    {
        public string nomeRemetente;
        public double km;
        public double peso;
        public double valorFrete;
        public abstract void calcularFrete();
    }
}
