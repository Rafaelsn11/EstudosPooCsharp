namespace EstudosPooCsharp.Models;

public class Cesta
{
    public Cesta()
    {
        Itens = new List<Item>();
    }
    public List<Item> Itens { get; set; }
}
