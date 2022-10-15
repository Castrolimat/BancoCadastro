namespace BancoCadastro
{
    internal class ContaBancaria
    {
        public string TitularConta { get; set; }//autoproperty
        public int NumeroConta { get; private set; }
        public double Saldo { get; set; }

        public ContaBancaria(string titularConta, int numeroConta)//construtor
        {
            TitularConta = titularConta;
            NumeroConta = numeroConta;

        }

        public ContaBancaria(string titularConta, int numeroConta, double saldo) : this(titularConta, numeroConta)//construtor
        {
            Saldo = saldo;
        }

        public override string ToString()//printar usando variavel
        {
            return "Titular: " + TitularConta
                + ", Número da Conta: " + NumeroConta +
                ", Saldo (em R$): " + Saldo.ToString("F2");
        }

        public void depositarDinheiro(double valorDeposito)
        {
            Saldo += valorDeposito;
        }
        
        public void sacarDinheiro(double ValorSaque)
        {
            Saldo -= ValorSaque;
        }
    }
        
}
