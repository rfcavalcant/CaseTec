
using System;

class Program {
    static void Main() {
        while (true) {
            Console.WriteLine("\n--- Desafio Técnico ---");
            Console.WriteLine("1. Soma com laço while");
            Console.WriteLine("2. Fibonacci");
            Console.WriteLine("3. Faturamento Diário");
            Console.WriteLine("4. Percentual por Estado");
            Console.WriteLine("5. Inverter String");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            var opcao = Console.ReadLine();

            switch (opcao) {
                case "1": Questao1.Executar(); break;
                case "2": Questao2.Executar(); break;
                case "3": Questao3.Executar(); break;
                case "4": Questao4.Executar(); break;
                case "5": Questao5.Executar(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }
    }
}
