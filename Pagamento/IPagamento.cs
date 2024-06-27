using EstudosPooCsharp.Models;

namespace EstudosPooCsharp.Pagamento;

public interface IPagamento
{
    void Processar(Cesta cesta);
}
