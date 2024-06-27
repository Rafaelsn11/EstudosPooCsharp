namespace EstudosPooCsharp.Frete;

public class OpcaoFrete
{
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public int Prazo { get; set; }

    private OpcaoFrete()
    {
    }

    public OpcaoFrete(string nome, decimal valor, int prazo)
    {
        Nome = nome;
        Valor = valor;
        Prazo = prazo;
    }
}
