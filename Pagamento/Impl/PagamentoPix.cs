using EstudosPooCsharp.Models;

namespace EstudosPooCsharp.Pagamento.Impl;

public class PagamentoPix : IPagamento
{
    public void Processar(Cesta cesta)
    {
        Console.WriteLine($"Gerando Pix da cesta no valor total de: {cesta.ValorTotalFormatado}");
        Console.WriteLine("Pix gerado com sucesso!");
    }
}
