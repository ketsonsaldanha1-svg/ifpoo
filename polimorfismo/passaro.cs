internal class Passaro : Animal
{
    public override void FazerSom()
    {
        
        Console.WriteLine($"{nome} fez piu-piu");

    }

    public override void Mover()
    {
        Console.WriteLine($"{nome} voou");

    }


}