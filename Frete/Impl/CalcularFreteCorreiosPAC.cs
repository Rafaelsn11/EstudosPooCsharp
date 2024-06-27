namespace EstudosPooCsharp.Frete.Impl;

public class CalcularFreteCorreiosPAC : CalcularFreteCorreios
{
    public override string Nome()
    {
        return "PAC";
    }

    public override int Prazo()
    {
        return 10;
    }

    public override decimal Valor()
    {
        return 15M;
    }
}
