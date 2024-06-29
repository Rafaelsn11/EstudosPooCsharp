using EstudosPooCsharp;
using EstudosPooCsharp.Frete;
using EstudosPooCsharp.Frete.Impl;
using EstudosPooCsharp.Models;
using EstudosPooCsharp.Pagamento;
using EstudosPooCsharp.Pagamento.Impl;

Cesta minhaCesta = new Cesta();

Item bola = new Item("Bola de Futebol", 89.90M, 1);
Item camiseta = new Item("Camiseta Vasco", 297.99M, 2);
Item chuteira = new Item("Chuteira Nike", 149.99M, 1);

minhaCesta.AdicionarItem(bola);
minhaCesta.AdicionarItem(camiseta);
minhaCesta.AdicionarItem(chuteira);

Console.WriteLine($"Itens da cesta:");
foreach (var item in minhaCesta.Itens)  
{
    Console.WriteLine($"- {item.Nome.PadRight(35, ' ')} | Qtd {item.Quantidade} | {item.TotalFormatado}");
}

Console.WriteLine($"Total Itens da Cesta: {minhaCesta.TotalItens}");
Console.WriteLine($"Valor Total da Cesta: {minhaCesta.ValorTotal}");

ICalcularFrete calcularFrete = SelecionarFrete.InformarFrete();
var opcaoFrete = calcularFrete.Calcular(minhaCesta);

if (opcaoFrete != null)
    Console.WriteLine($"Frete selecionado: {opcaoFrete.Nome}");

IPagamento pagamento = SelecionarPagamento.Informar();
pagamento.Processar(minhaCesta);

// minhaCesta.Pagar(new PagamentoBoleto());


/*exemplos de classes abstradas e suas filhas no dotnet 

-- Stream - classe  abstrata e Mãe
-- classes filhas dela:
-- - FileStream
-- - MemoryStream
-- - e etc
*/