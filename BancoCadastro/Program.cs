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
            string numeroConta = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Deseja fazer o depósito inicial? s/n");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'n')
            {
                cliente = new ContaBancaria(nomeTitular, numeroConta);
            }
            else
            {
                Console.Write("Valor do depósito inicial (em R$): ");
                double saldo = double.Parse(Console.ReadLine());
                cliente = new ContaBancaria(nomeTitular, numeroConta, saldo);
            }

            Console.WriteLine(cliente);

            Console.Write("Valor do depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            cliente.depositarDinheiro(valorDeposito);

            Console.WriteLine(cliente);
            Console.WriteLine();

            Console.Write("Valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            cliente.sacarDinheiro(valorSaque);

            Console.WriteLine(cliente);
            Console.WriteLine();

        }
    }

}