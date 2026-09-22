using System.Runtime.InteropServices.Marshalling;

internal class PagamentoCartao : IPagamento
{
    public decimal ValorTransacao {get; private set;}
    private string numerocartao;

    public PagamentoCartao(string Numerocartao)
    {
        
           this.numerocartao = Numerocartao; 
    }

    public bool ProcessarPagamento(decimal valor)
    {
        
        ValorTransacao = valor;
        Console.WriteLine($"processando pagamento no valor de {valor}no cartão {numerocartao}");
        return true;

    }

    public string ObterComprovante()
    {
        return $"comprovante cartão: r$ {ValorTransacao}";
    }

    public void CancelarTransacao()
    {
        Console.WriteLine("estornando o valor do cartão");
    }
   
}