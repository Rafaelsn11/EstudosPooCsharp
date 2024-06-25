namespace EstudosPooCsharp.Models;

public class CarrinhoItem
{
    private int _quantidade;

    public string Nome { get; set; }
    public int Quantidade 
    { 
        get => _quantidade;

        set
        {
            if(value > 0)
                _quantidade = value;

            _quantidade = 1;
        } 
    }
}
