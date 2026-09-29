using System;
using System.IO;          // Necessário para File e Path
using System.Text.Json;   // Necessário para JsonSerializer

// Função para escrever o JSON no arquivo
string WriteJson()
{
    var newWeatherForecast = new WeatherForecast
    {
        Date = DateTime.Parse("2019-08-01"),
        TemperatureC = 25,
        Summary = "hot"
    };

    string jsonString = JsonSerializer.Serialize(newWeatherForecast);
    
    // Path.Combine é mais seguro do que concatenar barras manuais ("\\")
    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "weatherforecast.json");
    
    File.WriteAllText(path, jsonString);

    return path;
}

// Função para ler o JSON do arquivo e converter de volta para objeto
WeatherForecast ReadJson(string path)
{
    // 1. Lê todo o conteúdo de texto do arquivo
    string jsonString = File.ReadAllText(path);

    // 2. Converte a string JSON de volta para o objeto WeatherForecast
    WeatherForecast weather = JsonSerializer.Deserialize<WeatherForecast>(jsonString);

    return weather;
}

// Execução
string filePath = WriteJson();
Console.WriteLine($"Arquivo salvo em: {filePath}");

// Lendo o arquivo
WeatherForecast forecast = ReadJson(filePath);
Console.WriteLine($"\nDados lidos do arquivo:");
Console.WriteLine($"Data: {forecast.Date:yyyy-MM-dd}");
Console.WriteLine($"Temperatura: {forecast.TemperatureC}°C");
Console.WriteLine($"Resumo: {forecast.Summary}");

// Definição da Classe
public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }
}