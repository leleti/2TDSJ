using Fiap.Banco.Model;
using Fiap.Exercicio01.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma conta corrente
            var cc = new ContaCorrente()
            {
                Agencia = 123,
                Numero = 321,
                DataAbertura = DateTime.Now,
                Saldo = 100,
                Tipo = TipoConta.Comum
            };

            //Tratar a exceção
            try
            {
                cc.Retirar(150);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var cp = new ContaPoupanca(0.006m)
            {
                Agencia = 123,
                DataAbertura = new DateTime(2018, 1, 20),
                Numero = 222,
                Saldo = 1000,
                Taxa = 10
            };
            cp.Retirar(100);
            Console.WriteLine(cp.Saldo);

            Console.ReadLine(); //parar a execução
        }
    }
}
