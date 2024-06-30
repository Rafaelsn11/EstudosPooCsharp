namespace EstudosPooCsharp.Models;

public class Cesta
{
    public Cesta()
    {
        _itens = new List<Item>();
    }
    private IList<Item> _itens;

    public IEnumerable<Item> Itens =>_itens.AsEnumerable();

    public int TotalItens => _itens.Sum(x => x.Quantidade);

    public decimal ValorTotal => _itens.Sum(x => x.Total);

    public string ValorTotalFormatado => ValorTotal.ToString("C");

    public void AdicionarItem(Item item)
    {
        if(item == null)
            throw new ArgumentNullException($"this is {item}");
        
        _itens.Add(item);
    }

    public void RemoverItem(Item item)
    {
        _itens.Remove(item);
    }

    public override string ToString()
    {
        return $"Qtd Itens: {TotalItens} | Total: {ValorTotalFormatado}";
    }

    // public void Pagar(IPagamento pagamento)
    // {
    //     pagamento.Processar(this);
    // }
}
