using System;

public class Program
{
    public static void Main()
    {
        // Instancia o objeto do produto
        var produto = new Produto
        {
            Nome = "Notebook Gamer",
            Preco = 5000.00m,
            QuantidadeEstoque = 10
        };

        // Instancia a classe de ações
        var produtoService = new ProdutoService();

        // 1. Executa a ação de aplicar desconto
        produtoService.AplicarDesconto(produto, 10); // Desconto de 10%

        // 2. Executa a ação de salvar em JSON
        string caminho = produtoService.SalvarEmJson(produto, "produto.json");
        Console.WriteLine($"Produto salvo em: {caminho}");

        // 3. Executa a ação de ler do ficheiro
        Produto produtoCarregado = produtoService.CarregarDeJson(caminho);
        Console.WriteLine($"\nDados Lidos do Ficheiro:");
        Console.WriteLine($"Nome: {produtoCarregado.Nome} | Preço: R$ {produtoCarregado.Preco:F2} | Estoque: {produtoCarregado.QuantidadeEstoque}");
    }
}