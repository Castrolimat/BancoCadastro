namespace BancoCadastro
{
    internal class ContaBancaria
    {
        public string TitularConta { get; set; }//autoproperty
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titularConta, int numeroConta)
        {
            TitularConta = titularConta;
            NumeroConta = numeroConta;

        }

        public ContaBancaria(string titularConta, int numeroConta, double saldoInicial) : this(titularConta, numeroConta)
        {
            DepositarDinheiro(saldoInicial);
        }

        public override string ToString()
        {
            return "Titular: " + TitularConta
                + ", Número da Conta: " + NumeroConta +
                ", Saldo (em R$): " + Saldo.ToString("F2");
        }

        public void DepositarDinheiro(double valorDeposito)
        {
            Saldo += valorDeposito;
        }
        
        public void SacarDinheiro(double ValorSaque)
        {
            Saldo -= ValorSaque;
            Saldo -= 5.0;
        }
    }
        
}
