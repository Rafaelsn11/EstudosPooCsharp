namespace EstudosPooCsharp.Models;

public class Item
{
    private const int PADRAO_QUANTIDADE = 1;

    public Item() : this("Desconhecido")
    {   
    }

    public Item(string nome) : this(nome, 0)
    {
    }

    public Item(string nome, decimal preco) : this(nome, preco, PADRAO_QUANTIDADE)
    {
    }

    public Item(string nome, decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    
    public string Nome { get; set; }

    private int _quantidade;
    public int Quantidade
    {
        get => _quantidade; 
        set 
        {  
            if (value > 0)
            {
                _quantidade = value;
            }

        }
    }

    private decimal _preco;
    public decimal Preco
    {
        get => _preco;
        set 
        {  
            if (value > 0)
            {
                _preco = value;
            }

        }
    }
    
    public decimal Total => Preco * Quantidade;

    public string TotalFormatado => Total.ToString("C");

    public override string ToString() => $"Item: {Nome.PadRight(35, ' ')} | Qtd {Quantidade} | Preço Total: {TotalFormatado}";

    public static Item CriarBola()
    {
        var bola = new Item();

        bola.Nome = "Bola de Futebol";
        bola.Quantidade = 1;
        bola.Preco = 99M;

        return bola;
    }
    
}
