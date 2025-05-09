
public static class Questao2 {
    public static void Executar() {
        Console.Write("Informe um número: ");
        if (int.TryParse(Console.ReadLine(), out int numero)) {
            int a = 0, b = 1;
            while (b < numero) {
                int temp = b;
                b = a + b;
                a = temp;
            }

            if (b == numero || numero == 0)
                Console.WriteLine(numero + " pertence à sequência de Fibonacci.");
            else
                Console.WriteLine(numero + " não pertence à sequência de Fibonacci.");
        } else {
            Console.WriteLine("Número inválido.");
        }
    }
}
