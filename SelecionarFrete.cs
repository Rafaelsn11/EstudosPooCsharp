using EstudosPooCsharp.Frete;
using EstudosPooCsharp.Frete.Impl;

namespace EstudosPooCsharp;

public class SelecionarFrete
{
    public static ICalcularFrete InformarFrete()
    {
        Console.WriteLine("1 - Frete Correios PAC\n2 - Frete Correios Sedex\n");
        Console.Write("Escolha a opção de frete: ");
        string opcao = Console.ReadLine();

        switch(opcao)
        {
            case "1": return new CalcularFreteCorreiosPAC();
            case "2": return new CalcularFreteCorreiosSedex();
            default: return new EscolhaFreteNaoRealizada();
        }
    }
}
