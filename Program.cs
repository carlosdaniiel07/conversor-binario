using System;

namespace conversor_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            do {
                try {
                    Console.Clear();
                    Console.WriteLine("==================================");
                    
                    Console.WriteLine("[1] - Decimal para binário");
                    Console.WriteLine("[2] - Binário para decimal");
                    Console.WriteLine("[3] - Sair");

                    Console.Write("\nSelecione uma opção: ");
                    opcao = int.Parse(Console.ReadLine());

                    ProcessaCalculo(opcao);
                } catch (Exception ex) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[ERRO] => {ex.Message}");
                    Console.ResetColor();

                    Console.Write("\nAperte {ENTER} para continuar.");
                    Console.ReadLine();
                }
            } while (opcao != 3);
        }

        static void ProcessaCalculo(int opcao) {
            var conversor = new Conversor();

            if (opcao.Equals(1)) {
                Console.Clear();

                Console.Write("Digite um número inteiro para ser convertido para binário: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write($"A representação binária do número {numero} é {conversor.ToBinario(numero)}\n");

                Console.Write("\nAperte {ENTER} para efetuar outra conversão.");
                Console.ReadLine();
            } 
            else if (opcao.Equals(2)) {
                Console.Clear();

                Console.Write("Digite um número binário para ser convertido para decimal: ");
                string binario = Console.ReadLine();
                Console.Write($"A representação decimal do binário {binario} é {conversor.ToDecimal(binario)}\n");

                Console.Write("\nAperte {ENTER} para efetuar outra conversão.");
                Console.ReadLine();
            } 
            else if (opcao.Equals(3)) {
                // Encerra a aplicação..
            }
            else {
                throw new SystemException($"A opção inserida ({opcao}) não existe!");
            }
        }
    }
}
