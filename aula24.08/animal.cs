using System;

  public class Animal
{
    // Propriedades/Campos
    public string Nome;
    public string Especie;
    public int Idade;
    public bool EstaDormindo;

    // Construtor atualizado para receber o estado inicial de 'estaDormindo'
    public Animal(string nome, string especie, int idade, bool estaDormindo = false)
    {
        Nome = nome;
        Especie = especie;
        Idade = idade;
        EstaDormindo = estaDormindo;
    }

    public void Dormir()
    {
        EstaDormindo = true;
        Console.WriteLine($"{Nome} dormiu.");
    }

    public void Acordar()
    {
        EstaDormindo = false;
        Console.WriteLine($"{Nome} acordou.");
    }

    public void FazerSom()
    {
        Console.WriteLine($"{Nome} fez um som!");
    }

    public void ApresentarSe()
    {
        Console.WriteLine($"Olá, eu sou o {Nome}, um {Especie} de {Idade} anos.");
    }

    public void Voar()
    {
        if (Especie.ToLower() == "passaro" || Especie.ToLower() == "pássaro")
        {
            Console.WriteLine($"{Nome} está voando!");
        }
        else
        {
            Console.WriteLine($"{Nome} não pode voar.");
        }
    }
}