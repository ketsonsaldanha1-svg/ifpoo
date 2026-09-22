using System;
using System.Net.Security;

public class Moto
{
    public string Modelo;
    public int Anofab;

    public Moto (string modelo, int anofab)
    {
        this.Modelo=modelo;
        this.Anofab=anofab;

    }

    public void Exibir()
    {
        Console.WriteLine($"fabricante; {Modelo} | ano da fabricaçãO: {Anofab}");
    }
    
}


