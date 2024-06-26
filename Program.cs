using EstudosPooCsharp.Models;



// CarrinhoItem bola = new CarrinhoItem();

// bola.nome = "Bola de Futebol";
// bola.quantidade  = 1;
// bola.preco = 99.00M;

// CarrinhoItem camisa = new CarrinhoItem();

// camisa.nome = "Camiseta de Frio";
// camisa.quantidade  = 1;
// camisa.preco = 99.00M;


// Item bola = Item.CriarBola();

Cesta cesta = new Cesta();

Item bola = new Item("Bola de futebol", 99M);
bola.Quantidade = 2;
cesta.Itens.Add(bola);

Item camiseta = new Item("Camiseta do Vasco", 150M);
camiseta.Quantidade = 3;
cesta.Itens.Add(camiseta);

foreach(var item in cesta.Itens)
{
    Console.WriteLine($"{item.Nome}: {item.TotalFormatado}");
}

var itens = cesta.Itens; // Erro de design

itens.Add(new Item("Tenis Nike", 300M));

foreach(var item in cesta.Itens)
{
    Console.WriteLine($"{item.Nome}: {item.TotalFormatado}");
}