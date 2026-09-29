using System;
using System.IO;
using System.Text.Json;

public class ProdutoService
{
    // Ação 1: Aplicar desconto no produto
    public void AplicarDesconto(Produto produto, decimal porcentagem)
    {
        decimal valorDesconto = produto.Preco * (porcentagem / 100);
        produto.Preco -= valorDesconto;
        Console.WriteLine($"Desconto de {porcentagem}% aplicado! Novo preço: R$ {produto.Preco:F2}");
    }

    // Ação 2: Serializar e Salvar no Ficheiro
    public string SalvarEmJson(Produto produto, string nomeArquivo)
    {
        string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            nomeArquivo
        );

        string jsonString = JsonSerializer.Serialize(produto);
        File.WriteAllText(path, jsonString);

        return path;
    }

    // Ação 3: Ler do Ficheiro e Desserializar
    public Produto CarregarDeJson(string path)
    {
        string jsonString = File.ReadAllText(path);
        return JsonSerializer.Deserialize<Produto>(jsonString);
    }
}