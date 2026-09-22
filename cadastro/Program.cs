class Program
{
    
  static void Main()
    {
        string nomedigitado;
        int idadedigitada;

       Console.WriteLine("digite seu nome");
        nomedigitado = Console.ReadLine();

        Console.WriteLine("digite sua idade");
        idadedigitada = Convert.ToInt32(Console.ReadLine());

       Aluno aluno1 = new Aluno (nomedigitado, idadedigitada); 

       aluno1.apresentar(); 
    }


}
