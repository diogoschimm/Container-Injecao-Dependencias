using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTesteInjecaoDependencias.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTesteInjecaoDependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadora _calculadora;

        public CalculadoraController(ICalculadora calculadora)
        {
            this._calculadora = calculadora;
        }

        public string Get() => "Funcionando";


        [HttpPost("somar")]
        public int Somar(Valores valores)
        {
            return this._calculadora.Add(valores.V1, valores.V2);
        }
        [HttpPost("subtrair")]
        public int Subtrair(Valores valores)
        {
            return this._calculadora.Sub(valores.V1, valores.V2);
        }
        [HttpPost("multiplicar")]
        public int Multiplicar(Valores valores)
        {
            return this._calculadora.Mul(valores.V1, valores.V2);
        }
        [HttpPost("dividir")]
        public double Dividir(Valores valores)
        {
            return this._calculadora.Div(valores.V1, valores.V2);
        }
    }

    public class Valores
    {
        public int V1 { get; set; }
        public int V2 { get; set; }
    }
}
