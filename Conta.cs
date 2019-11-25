using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.ProjetoBanco {
    class Conta {
        public int NumeroConta { get; }
        public string TitularConta { get; set; }

        //Propriedade Saldo
        public static decimal Saldo { get; set; }

        public void Depositar(decimal valor) {

            Saldo += valor;
            this.InformarConta();
        }

        //Construtor com saldo incial
        public Conta(string titularConta, int numeroConta, decimal saldoInicial) {

            TitularConta = titularConta;
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        // Construtor com cliente e conta

        public Conta(string titularConta, int numeroConta) {

            TitularConta = titularConta;
            NumeroConta = numeroConta;

        }

        public void Sacar(decimal valor) {

            Saldo -= valor;
            this.InformarConta();


        }

        public void InformarConta() {

            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {NumeroConta},Titular: {TitularConta}, Saldo: {Saldo}");

        }

    }
}
