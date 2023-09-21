namespace ContaBancaria
{

    class ContaCorrente
    {
        private string titular { get; set; }
        private double saldo;

        public ContaCorrente(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo disponível para {titular} é de {saldo}");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo = saldo + valor;
                Console.WriteLine($"Depósito no valor de {valor} foi realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido para depósito.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque no valor de R${valor} foi realizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Valor inválido.");
            }
        }
    }
}
