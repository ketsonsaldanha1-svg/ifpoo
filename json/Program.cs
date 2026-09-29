using System;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        string path = WriteJsonBytes();
        Console.WriteLine($"Arquivo gravado em: {path}");

        WeatherForecast? forecast = ReadJsonBytes(path);

        if (forecast != null)
        {
            Console.WriteLine($"\nDados lidos do arquivo:");
            Console.WriteLine($"Data: {forecast.Date:yyyy-MM-dd}");
            Console.WriteLine($"Temperatura: {forecast.TemperatureC}°C");
            Console.WriteLine($"Resumo: {forecast.summary}");
        }
    }

    public static string WriteJsonBytes()
    {
        // 1. Instanciar o objeto
        var weatherForecast = new WeatherForecast
        {
            Date = DateTime.Parse("2019-08-01"),
            TemperatureC = 25,
            summary = "hot"
        };

        // 2. Serializar para byte array (UTF-8)
        byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(weatherForecast);

        // 3. Definir o caminho
        string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "weatherforecast.json"
        );

        // 4. Escrever os bytes no arquivo
        File.WriteAllBytes(path, jsonUtf8Bytes);

        return path;
    }

    public static WeatherForecast? ReadJsonBytes(string path)
    {
        byte[] bytesRead = File.ReadAllBytes(path);
        return JsonSerializer.Deserialize<WeatherForecast>(bytesRead);
    }
}