using System;


public class Carro
{
    
    public String Modelo;
    public string AnoCarro;
    public string CorCarro;
    public bool Movimento;
    
    public Carro (string modelo, string anoCarro, string corCarro, bool movimentando=false)
    {
        Modelo = modelo;
        AnoCarro = anoCarro;
        CorCarro = corCarro;
        Movimento = movimentando;

    }

    public void movimentando()
    {
        Movimento= true;
        Console.WriteLine("o carro esta se movendo");

    }

    public void parado()
    {
        Movimento= false;
         Console.WriteLine("o carro esta se parado");

    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo} | Ano: {AnoCarro} | Cor: {CorCarro} | Em movimento: {Movimento}");
    }
}