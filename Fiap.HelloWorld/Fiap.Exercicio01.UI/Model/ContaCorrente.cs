using Fiap.Exercicio01.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    //sealed: classe não pode ter filhos 
    sealed class ContaCorrente : Conta
    {
        //Propriedade
        public TipoConta Tipo { get; set; }

        public override void Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && Saldo - valor < 0)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
}
