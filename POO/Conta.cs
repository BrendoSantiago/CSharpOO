namespace POO
{
    public class Conta
    {
        private int agencia;
        private int numeroConta;
        private decimal saldo;

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

        public void SetAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        private void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        private void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}