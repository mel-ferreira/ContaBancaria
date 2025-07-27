using System.Globalization;
using System.Threading.Channels;

namespace ContaBancaria {
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Entre com os dados para abertura de conta");

            Conta conta;

            Console.Write("Número da conta: ");
            int Numeroconta = int.Parse(Console.ReadLine()!);

            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;

            Console.Write ("Deseja fazer um depósito inicial? s/n");
            string perguntaDepositoInicial = Console.ReadLine()!;

            if (perguntaDepositoInicial == "s" || perguntaDepositoInicial == "S")
            {
                Console.WriteLine("Insira um valor: ");
                double depositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta = new (Numeroconta, nome, depositoInicial);
                Console.WriteLine($"Cadastro realizado! Segue os dados: {conta}");
            }
            else
            {
                conta = new Conta(Numeroconta, nome);
                Console.WriteLine($"Cadastro realizado! Segue os dados: {conta}");
            }

            Console.WriteLine("Realize um valor de depósito: ");
            double quantiaDeposito = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Deposito(quantiaDeposito);

            Console.WriteLine($"Dados atualizados: {conta}\n");

            Console.WriteLine("Realize um saque: ");
            double quantiaSaque = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Saque(quantiaSaque);

            Console.WriteLine($"Dados atualizados: {conta}\n");

        }
    }
}