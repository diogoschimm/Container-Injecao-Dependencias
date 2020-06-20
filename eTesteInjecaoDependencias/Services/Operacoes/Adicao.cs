using eTesteInjecaoDependencias.Services.Operacoes.Contracts;

namespace eTesteInjecaoDependencias.Services.Operacoes
{
    public class Adicao : IAdicao
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
