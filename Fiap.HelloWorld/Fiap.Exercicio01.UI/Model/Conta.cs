using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    //Classe abstrata: não pode ser instanciada
    //e pode ter métodos abstratos (sem implementação)
    abstract class Conta
    {
        //Propriedades (gets e sets)
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }
        
        //Métodos
        public abstract void Retirar(decimal valor);

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
