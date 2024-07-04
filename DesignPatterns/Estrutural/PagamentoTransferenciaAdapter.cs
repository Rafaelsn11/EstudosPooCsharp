using EstudosPooCsharp.Models;
using EstudosPooCsharp.Pagamento;
using EstudosPooCsharp.Pagamento.Impl;

namespace EstudosPooCsharp.DesignPatterns.Estrutural;

public class PagamentoTransferenciaAdapter : IPagamento
{
    private PagamentoTransferencia _pagamentoTransferencia;

    public PagamentoTransferenciaAdapter(PagamentoTransferencia pagamentoTransferencia)
    {
        _pagamentoTransferencia = pagamentoTransferencia;
    }

    public void Processar(Cesta cesta)
    {
        _pagamentoTransferencia.Pagar(cesta.ValorTotal);
    }
}
