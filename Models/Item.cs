namespace EstudosPooCsharp.Models;

public class Item
{
    private const int PADRAO_QUANTIDADE = 1;
    public Item()
    {
        _quantidade = PADRAO_QUANTIDADE;
    }

    public Item(string nome, decimal preco) : base()
    {
        Nome = nome;
        _preco = preco;
    }

    private int _quantidade;
    private decimal _preco;

    public string Nome { get; set; }
    public int Quantidade 
    { 
        get => _quantidade;

        set
        {
            if(value > 0)
                _quantidade = value;
        } 
    }

    public decimal Preco 
    { 
        get => _preco;

        set
        {
            if(value > 0)
                _preco = value;
        } 
    }

    public static Item CriarBola() // método estático
    {
        var bola = new Item();
        bola.Nome = "Bola de Futebol";
        bola.Quantidade = 1;
        bola.Preco = 99M;

        return bola;
    }

    public decimal Total => Preco * Quantidade;

    public string TotalFormatado => Total.ToString("C");
}
