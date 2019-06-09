using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keila2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float saldo;

            void cadastrar()
            {
                Console.Write("Por favor, informe seu nome para fazer o cadastro: ");
                nome = Console.ReadLine();
                Console.Write("informe o valor do seu saldo: ");
                saldo = float.Parse(Console.ReadLine());
               
            }

            float ConsultarSaldo()
                {

                    return saldo;
                }

            void depositar (float valor)
            {
              saldo = valor + ConsultarSaldo();
            }

            void sacar (float valor)
            {
                if (valor <= ConsultarSaldo())
                
                    saldo = ConsultarSaldo() - valor;
            else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }

         
            cadastrar();
            Console.WriteLine("");
            Console.WriteLine(ConsultarSaldo());
            depositar(100);
            Console.WriteLine(ConsultarSaldo());
            sacar(200);
            Console.WriteLine(ConsultarSaldo());
            sacar(400);


               Console.WriteLine("");
                Console.ReadKey();
            
        }

    }
}

 