public class Aluno
{
        private string Nome;
        private int Idade;
      

    public Aluno(string nome, int idade)
    {
        this.Nome=nome;
        this.Idade=idade;
    }

    public void apresentar()
    {
        Console.WriteLine($"nome do aluno: {Nome} | idade do aluno: {Idade}");

    }


}