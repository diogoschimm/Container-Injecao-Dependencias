using eTesteInjecaoDependencias.Services.Operacoes.Contracts;
using System;

namespace eTesteInjecaoDependencias.Services.Operacoes
{
    public class Divisao : IDivisao
    {
        public double Div(int n1, int n2)
        {
            if (n2 == 0)
                throw new ArgumentException("N2 não pode ser igual a ZERO");

            return Convert.ToDouble(n1) / Convert.ToDouble(n2);
        }
    }
}
