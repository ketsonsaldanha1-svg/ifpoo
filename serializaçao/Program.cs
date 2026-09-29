// Program.cs
using System;
using System.Xml.Serialization;

// 1. Código executável principal (Top-Level Statements)
string caminhoDoArquivo = writeXml();
Console.WriteLine($"Arquivo {caminhoDoArquivo} gerado com sucesso!");

// 2. Funções locais
string writeXml()
{
    Book livro = new Book { Title = "Harry Potter" };
    XmlSerializer writer = new XmlSerializer(typeof(Book));
    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "livros.xml");

    using (FileStream arquivoXML = File.Create(path))
    {
        writer.Serialize(arquivoXML, livro);
    }

    return path;
}

// 3. Definição de classes (OBRIGATÓRIO FICAR NO FINAL)
public class Book
{
    public string Title;
}

class LivroNaoEncontradoException : Exception
{
    public LivroNaoEncontradoException(string message) : base(message) { }
}