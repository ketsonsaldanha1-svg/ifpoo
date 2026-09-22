internal class Cachorro : Animal
{
    public override void FazerSom()
    {
        
        Console.WriteLine($"{nome} fez um au-au");

    }

    public override void Mover()
    {
        Console.WriteLine($"{nome} correu");

    }


}