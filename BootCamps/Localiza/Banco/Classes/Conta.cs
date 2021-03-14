namespace Banco
{
    public class Conta
    {
        private uint numeroConta {get; set;}
        private string nome {get; set;} 
        private TipoConta tipoConta {get; set;}
        private decimal saldo {get; set;}
        private decimal limite {get; set;}

        public Conta(uint numeroConta, string nome, TipoConta tipoConta, decimal saldo, decimal limite)
        {
            this.numeroConta = numeroConta;
            this.nome = nome;
            this.tipoConta = tipoConta;
            this.saldo = saldo;
            this.limite = limite;
        }

        public void depositar(decimal valor)
        {
            this.saldo += valor;
        }

        public bool sacar(decimal valor)
        {
            if (valor > this.saldo + this.limite)
                return false;
            this.saldo -= valor;
            return true;
        }
        public bool transferir(decimal valor, Conta contaDestino)
        {
            if (this.sacar(valor))
            {
                contaDestino.depositar(valor);
                return true;
            }
            return false;
        }
        public decimal getNumeroConta()
        {
            return this.numeroConta;
        }

        public decimal getSaldo()
        {
            return this.saldo;
        }

        public override string ToString()
        {
            return  "Número da conta: " + this.numeroConta + 
                    " | Nome: " + this.nome + 
                    " | Tipo de conta: " + this.tipoConta + 
                    " | Saldo: " + this.saldo + 
                    " | Limite: " + this.limite; 
        }

    }
}