namespace POO
{
    public class ContaCorrente : Conta
    {
        private decimal taxaMovimento;

        public decimal TaxaMovimento
        {
            get
            {
                return taxaMovimento;
            }

            set
            {
                taxaMovimento = value;
            }
        }

        public ContaCorrente() : base(1070.00m)
        {
            this.TaxaMovimento = 0.1m;
        }
    }
}