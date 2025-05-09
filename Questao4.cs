
using System;

public static class Questao4 {
    public static void Executar() {
        var estados = new (string Nome, double Valor)[] {
            ("SP", 67836.43),
            ("RJ", 36678.66),
            ("MG", 29229.88),
            ("ES", 27165.48),
            ("Outros", 19849.53)
        };

        double total = 0;
        foreach (var estado in estados)
            total += estado.Valor;

        foreach (var estado in estados) {
            double percentual = (estado.Valor / total) * 100;
            Console.WriteLine($"{estado.Nome}: {percentual:F2}%");
        }
    }
}
