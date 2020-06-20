using eTesteInjecaoDependencias.Services.Contracts;
using eTesteInjecaoDependencias.Services.Operacoes.Contracts;

namespace eTesteInjecaoDependencias.Services
{
    public class Calculadora : ICalculadora
    {
        private readonly IAdicao _adicao;
        private readonly ISubtracao _subtracao;
        private readonly IMultiplicacao _multiplicacao;
        private readonly IDivisao _divisao;

        public Calculadora(
            IAdicao adicao, 
            ISubtracao subtracao, 
            IMultiplicacao multiplicacao, 
            IDivisao divisao)
        {
            this._adicao = adicao;
            this._subtracao = subtracao;
            this._multiplicacao = multiplicacao;
            this._divisao = divisao;
        }

        public int Add(int n1, int n2) =>  this._adicao.Add(n1, n2);

        public int Sub(int n1, int n2) => this._subtracao.Sub(n1, n2);

        public int Mul(int n1, int n2) => this._multiplicacao.Mul(n1, n2);

        public double Div(int n1, int n2) =>  this._divisao.Div(n1, n2);
    }
}
