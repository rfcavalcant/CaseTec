
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

public class Faturamento {
    public int dia { get; set; }
    public double valor { get; set; }
}

public static class Questao3 {
    public static void Executar() {
        try {
            var json = File.ReadAllText("dados.json");
            var dados = JsonSerializer.Deserialize<List<Faturamento>>(json);

            if (dados == null) {
                Console.WriteLine("Erro: dados do JSON estão vazios ou inválidos.");
                return;
            }

            var faturamentos = dados.Where(f => f.valor > 0).ToList();
            double menor = faturamentos.Min(f => f.valor);
            double maior = faturamentos.Max(f => f.valor);
            double media = faturamentos.Average(f => f.valor);
            int diasAcimaMedia = faturamentos.Count(f => f.valor > media);

            Console.WriteLine($"Menor: {menor:F2}");
            Console.WriteLine($"Maior: {maior:F2}");
            Console.WriteLine($"Dias acima da média: {diasAcimaMedia}");
        } catch (Exception ex) {
            Console.WriteLine("Erro ao processar dados: " + ex.Message);
        }
    }
}
