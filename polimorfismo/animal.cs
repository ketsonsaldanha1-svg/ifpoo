public class Animal
{
    public string nome {get;set;}
    public virtual void FazerSom()
    {
        
        Console.WriteLine("o animal fez: au au");

    }

    public virtual void Mover()
    {
        Console.WriteLine("o animal se moveu");
        
    }



}