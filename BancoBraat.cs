using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.ProjetoBanco {
    class BancoBraat {
    
        static void Main(string[] args) {

            Console.Write("Entre com o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string TitularConta = Console.ReadLine();
            char recebeSimOuNao = 'a';

            while (recebeSimOuNao != 's' && recebeSimOuNao !=  'n') {
                Console.Write("Haverá depósito inicial (s/n)? ");
                recebeSimOuNao = char.Parse(Console.ReadLine());
            }

            Conta c = BancoBraat.CriarConta(recebeSimOuNao, NumeroConta, TitularConta);

            Console.Write($"Entre um valor para depósito: ");
            c.Depositar(decimal.Parse(Console.ReadLine()));

            Console.Write($"Entre um valor para sacar: ");
            c.Sacar(decimal.Parse(Console.ReadLine()));
            
        }



        public static Conta CriarConta(char recebeSimOuNao, int NumeroConta, string TitularConta) {

            char sim = 's';

            Conta c = null;

         
            if (recebeSimOuNao == sim) {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                decimal recebeSaldo = decimal.Parse(Console.ReadLine());
                c = new Conta(TitularConta, NumeroConta, recebeSaldo);

            } else {

                c = new Conta(TitularConta, NumeroConta);       

                }

            c.InformarConta();

            return c;

        }


    }
}
