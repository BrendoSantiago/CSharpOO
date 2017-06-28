namespace POO
{
    public abstract class Conta
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

            private set
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

            protected set
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

            private set
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

        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public abstract void Depositar(decimal valor);
    }
}