using eTesteInjecaoDependencias.Services.Operacoes.Contracts;

namespace eTesteInjecaoDependencias.Services.Contracts
{
    public interface ICalculadora 
        : IAdicao, ISubtracao, IMultiplicacao, IDivisao
    {
    }
}
