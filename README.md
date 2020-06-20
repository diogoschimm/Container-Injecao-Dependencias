# Container-Injecao-Dependencias
Container de Injeção de Dependências do AspNetCore

## Startup

```csharp
  ....
  
  public IConfiguration Configuration { get; }

  public void ConfigureServices(IServiceCollection services)
  {
      services.AddControllers();

      services.AddScoped<IAdicao, Adicao>();
      services.AddScoped<ISubtracao, Subtracao>();
      services.AddScoped<IMultiplicacao, Multiplicacao>();
      services.AddScoped<IDivisao, Divisao>();

      services.AddScoped<ICalculadora, Calculadora>();
  }
  
  ....
```

## Controller

```csharp
  ....

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
      
 ....
```
