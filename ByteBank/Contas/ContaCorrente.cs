using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Titular;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        private int numero_Agencia;
        public int Numero_Agencia
        {
            get { return this.numero_Agencia; }
            set
            {
                if (value > 0)
                {

                    this.numero_Agencia = value;
                }
            }
        }
        public string Conta { get; set; }
        private double saldo = 100;

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else { return false; }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }

        }
        public double GetSaldo()
        {
            return this.saldo;
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine();
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Conta: " + Conta);
            Console.WriteLine("Número da Agência: " + numero_Agencia);
            Console.WriteLine("Saldo: " + saldo + " reais.");
            Console.WriteLine();
        }

    }
}
