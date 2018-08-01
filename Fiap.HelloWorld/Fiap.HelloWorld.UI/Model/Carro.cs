using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Carro : Veiculo
    {
        //Construtor
        public Carro(int numeroPortas, int ano) : base(ano)
        {
            NumeroPortas = numeroPortas;
        }

        //Propriedades
        public int NumeroPortas { get; set; }

        public override void Frear()
        {
            Console.WriteLine("Diminuindo a velocidade do carro");
        }
    }
}
