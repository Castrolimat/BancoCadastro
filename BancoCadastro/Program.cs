namespace BancoCadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente;
            Console.Write("Nome do titular: ");
            string nomeTitular = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Deseja fazer o depósito inicial? s/n");
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (resp == 'n')
            {
                cliente = new ContaBancaria(nomeTitular, numeroConta);
            }
            else
            {
                Console.Write("Valor do depósito inicial (em R$): ");
                double saldoInicial = double.Parse(Console.ReadLine());
                Console.WriteLine($"Depósito inicial de R$: {saldoInicial} realizado com sucesso!");
                cliente = new ContaBancaria(nomeTitular, numeroConta, saldoInicial);
            }
            
            Console.WriteLine();
            Console.WriteLine(cliente);
            Console.WriteLine();

            Console.Write("Valor do depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            cliente.depositarDinheiro(valorDeposito);
            Console.WriteLine();
            Console.WriteLine($"Depósito de R$: {valorDeposito:F2} realizado com sucesso!");

            Console.WriteLine(cliente);
            Console.WriteLine();

            Console.Write("Valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            cliente.sacarDinheiro(valorSaque);
            Console.WriteLine();
            Console.WriteLine($"Saque de R$: {valorSaque:F2} realizado com sucesso!");

            Console.WriteLine(cliente);
            Console.WriteLine();

        }
    }

}