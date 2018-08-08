using Fiap.Exercicio01.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Propriedade 
        public decimal Taxa { get; set; }
        //Fields (atributos)
        private readonly decimal _rendimento;
        //Construtor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        //Métodos
        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Retirar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor + Taxa;
        }
    }
}
