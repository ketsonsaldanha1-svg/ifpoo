using System;
using System.Collections.Generic;

// 1. Interface de Alarme
public interface IAlarme
{
    bool alarme { get; set; } 
    void Ligaralarme();
    void Desligaralarme();
}

// 2. Classe Base Abstrata
public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Combustivel { get; set; }

    public Veiculo(string marca, string modelo, int ano, string combustivel)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Combustivel = combustivel;
    }

    public abstract double CalcularConsumo(double distancia);

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Combustível: {Combustivel}");
    }

    public void Acelerar()
    {
        Console.WriteLine($"O veículo {Modelo} está acelerando!");
    }
}

// 3. Classe Carro com IAlarme Implementado
public class Carro : Veiculo, IAlarme
{
    public bool alarme { get; set; } = false;

    public Carro(string marca, string modelo, int ano, string combustivel) 
        : base(marca, modelo, ano, combustivel)
    {
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 12.0;
    }

    public void Ligaralarme()
    {
        alarme = true;
        Console.WriteLine($"[ALARME]: O alarme do {Modelo} foi LIGADO! 🔒");
    }

    public void Desligaralarme()
    {
        alarme = false;
        Console.WriteLine($"[ALARME]: O alarme do {Modelo} foi DESLIGADO! 🔓");
    }
}

// 4. Classe Moto
public class Moto : Veiculo
{
    public Moto(string marca, string modelo, int ano, string combustivel)
        : base(marca, modelo, ano, combustivel)
    {
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 30.0;
    }
}

// 5. Classe Caminhao
public class Caminhao : Veiculo
{
    public Caminhao(string marca, string modelo, int ano, string combustivel)
        : base(marca, modelo, ano, combustivel)
    {
    }

    public override double CalcularConsumo(double distancia)
    {
        return distancia / 4.0;
    }
}