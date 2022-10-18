using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public int numero_Agencia;
        public string conta;
        public double saldo = 100;

        public string titular;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else { return false; }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return false;
            } 
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine();
            Console.WriteLine("Titular: " + this.titular);
            Console.WriteLine("Conta: " + this.conta);
            Console.WriteLine("Número da Agência: " + this.numero_Agencia);
            Console.WriteLine("Saldo: " + this.saldo + " reais.");
            Console.WriteLine();
        }
        
    }
}
