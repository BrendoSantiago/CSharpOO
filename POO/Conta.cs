namespace POO
{
    public class Conta
    {
        private int agencia;
        private int numeroConta;
        private decimal saldo;
        private decimal limite;

        //Encapsulamento
        public int Agencia
        {
            get
            {
                return agencia;
            }

            private set
            {
                if (value > 0)
                    agencia = value;
            }
        }

        public int NumeroConta
        {
            get
            {
                return numeroConta;
            }

            set
            {
                numeroConta = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public decimal Limite
        {
            get
            {
                return limite;
            }

            set
            {
                limite = value;
            }
        }

        //Fim do Encapsulamento

        public Conta()
        {
            this.limite = 1000;
        }

        public Conta(decimal limite)
        {
            this.limite = limite;
        }

        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        private void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        private void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}