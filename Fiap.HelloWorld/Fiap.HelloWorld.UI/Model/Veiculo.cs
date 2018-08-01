using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    abstract class Veiculo
    {
        //Atributo
        private string _placa;

        //Construtor
        public Veiculo(int ano)
        {
            Ano = ano;
        }

        //Gets e Sets
        public int Ano { get; set; }
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        //Métodos
        // Virtual -> permite a sobrescrita do método
        public virtual void Acelerar(int velocidade)
        {
            Console.WriteLine("Aumentando a velocidade");
        }

        public abstract void Frear(); //Método abstrato
        
    }
 
}
