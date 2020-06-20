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
