
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static float TaxaOperacao { get; private set; }

        public static int totalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        public string Conta { get; set; }
        private double saldo = 100;

        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set {
                if (value > 0) {
                    this.numero_agencia = value;
                }
            }
        }

        public void Depositar(double valor) {
            this.saldo += valor;
        }

        public bool Sacar(double valor) 
        {
            if (valor <= saldo) {
                this.saldo -= valor;
                return true;
            }
            else {
                throw new SaldoInsuficienteException(">> Saldo da Conta Insuficiente para operacao <<");
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor) {
                throw new ArgumentException("Valor inválido para transação.");
            }
            else {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0) {
                return;
            }
            else {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }


        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;

            if (numero_agencia <= 0) {
                throw new ArgumentException("[>> Número da agencia menor ou igual a zero <<]", nameof(numero_agencia));
            }

            totalDeContasCriadas++;
        }
    }
}
