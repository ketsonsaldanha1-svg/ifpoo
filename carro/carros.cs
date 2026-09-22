using System;

public class Carro : Veiculos
{

    public bool correr;
    int Numerodeportas;
    public Carro (string marca, string modelo, int anofabricacao, int numerodeportas) : base (marca, modelo)
    {
        Numerodeportas=numerodeportas;
    }


}