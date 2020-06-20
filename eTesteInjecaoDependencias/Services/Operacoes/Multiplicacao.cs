using eTesteInjecaoDependencias.Services.Operacoes.Contracts;

namespace eTesteInjecaoDependencias.Services.Operacoes
{
    public class Multiplicacao : IMultiplicacao
    {
        public int Mul(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
