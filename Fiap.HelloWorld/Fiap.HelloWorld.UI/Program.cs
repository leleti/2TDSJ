using Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "Fiap";
            if (n == "Fiap")
            {
                Console.WriteLine("OK");
            }

            //Instanciar um carro
            Carro carro = new Carro(5,1999)
            {
               Placa = "DDD-9999"
            };
            carro.Placa = "DDD-0000"; //Set
            Console.WriteLine(carro.Placa); //Get

        }
    }
}
