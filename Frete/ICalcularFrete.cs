using EstudosPooCsharp.Models;

namespace EstudosPooCsharp.Frete;

public interface ICalcularFrete
{
    OpcaoFrete Calcular(Cesta cesta);
}
