
class Program
{
    static void Main()
    {
        Animal meuCao = new Animal("Rex", "cachorro", 4, false);
        Animal meuGato = new Animal("Mimi", "gato", 2, false);
        Animal meuPassaro = new Animal("Loro", "passaro", 1, true);

        meuCao.ApresentarSe();
        meuCao.FazerSom();
        meuCao.Dormir();

        Console.WriteLine("----------------");

        meuGato.ApresentarSe();
        meuGato.FazerSom();

        Console.WriteLine("----------------");

        meuPassaro.ApresentarSe();
        meuPassaro.FazerSom();
        meuPassaro.Voar();
    }
}