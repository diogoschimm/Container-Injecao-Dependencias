using eTesteInjecaoDependencias.Services.Operacoes.Contracts;

namespace eTesteInjecaoDependencias.Services.Operacoes
{
    public class Subtracao : ISubtracao
    {
        public int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
