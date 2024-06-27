using EstudosPooCsharp.Models;

namespace EstudosPooCsharp.Pagamento.Impl;

public class PagamentoNaoRealizado : IPagamento
{
    public void Processar(Cesta cesta)
    {
        Console.WriteLine("Pagamento não realizado!");
    }
}
