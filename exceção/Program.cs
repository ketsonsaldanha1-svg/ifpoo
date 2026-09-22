
/*int x = 10;
int y = 0;


if(y !> 0)

    {
       int resultado= x/y; 
       Console.WriteLine(resultado);
    } else
    {
        Console.WriteLine("Não é possível dividir por zero.");
    }



try
{
    int [] numeros = [1, 2, 3];
    Console.WriteLine(numeros[5]);
}
catch (System.Exception ex)
{
    Console.WriteLine("Ocorreu um erro ao acessar o índice do array.");
    Console.WriteLine("Detalhes do erro: " + ex.Message);
    throw;
}  
  */

try
{
    int a = int.Parse("2"); // Isso vai gerar uma exceção[]
    int idade =-1;
    if(idade < 0)
    {
        throw new idadeInvalidaException("Idade não pode ser negativa.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Ocorreu um erro de formatação: "+ ex.Message);
}
catch (idadeInvalidaException ex)
{
    Console.WriteLine("Ocorreu um erro de idade inválida: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
} finally
{
    Console.WriteLine("Bloco finally executado.");
}