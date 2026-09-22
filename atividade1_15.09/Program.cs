// 6. Programa Principal
class Program
{
    static void Main()
    {
        // A forma correta em C# de agrupar o Carro, Moto e Caminhão na "frota":
        List<Veiculo> frota = new List<Veiculo>
        {
            new Carro("Ford", "Fiesta", 2020, "Gasolina"),
            new Moto("Honda", "CB500", 2021, "Gasolina"),
            new Caminhao("Volvo", "FH", 2019, "Diesel")
        };

        // Iterando sobre cada veículo da frota
        foreach (Veiculo veiculo in frota)
        {
            veiculo.ExibirInfo();
            veiculo.Acelerar();
            Console.WriteLine($"Consumo para 100km: {veiculo.CalcularConsumo(100)} L");

            // Testando o alarme se o veículo possuir a interface IAlarme
            if (veiculo is IAlarme veiculoComAlarme)
            {
                veiculoComAlarme.Ligaralarme();
                veiculoComAlarme.Desligaralarme();
            }

            
        }
    }
}