
using System;

public static class Questao5 {
    public static void Executar() {
        Console.Write("Digite uma palavra para inverter: ");
        string? original = Console.ReadLine();

        if (string.IsNullOrEmpty(original)) {
            Console.WriteLine("String vazia ou nula.");
            return;
        }

        char[] invertida = new char[original.Length];
        for (int i = 0; i < original.Length; i++)
            invertida[i] = original[original.Length - 1 - i];

        Console.WriteLine("Inversão: " + new string(invertida));

    }
}
