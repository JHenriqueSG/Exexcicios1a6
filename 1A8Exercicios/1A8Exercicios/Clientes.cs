using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A8Exercicios
{
    class Clientes
    {

            private int conta;
            private int saldo;
            private int debitos;
            private int pagamentos;
            private int limiteCredito;

            public Clientes(int conta, int saldo, int debitos, int pagamento, int limite)
            {
                this.saldo = saldo;
                this.conta = conta;
                this.debitos = debitos;
                this.pagamentos = pagamento;
                this.limiteCredito = limite;
            }


            public int CalcularNovoSaldo()
            {
                return this.saldo + this.debitos - this.pagamentos;
            }

            public int AtualizarSaldo()
            {
               return this.saldo = CalcularNovoSaldo();
            }


            public void LimiteDeCredito()
            {
            if (this.limiteCredito > AtualizarSaldo())
               {
                Console.WriteLine("\nBoas compras!");

               }

                else
                {
                Console.WriteLine("\nLimite de credito excedido!");
                }
          
            }

        

    }
}
