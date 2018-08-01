using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Moto : Veiculo
    {
        public Moto(int ano) : base(ano)
        {
        }

        //Métodos
        public override void Acelerar(int velocidade)
        {
            Console.WriteLine("Moto acelerando");
        }

        public override void Frear()
        {
            Console.WriteLine("Moto diminuindo a velocidade");
        }
    }
}
