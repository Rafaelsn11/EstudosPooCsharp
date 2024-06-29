using EstudosPooCsharp.Models;

namespace EstudosPooCsharp.Frete.Impl;

public class EscolhaFreteNaoRealizada : CalcularFreteCorreios
{
    public override string Nome()
    {
        return "Escolha não realizada";
    }

    public override int Prazo()
    {
        return 0;
    }

    public override decimal Valor()
    {
        return 0;
    }
}
