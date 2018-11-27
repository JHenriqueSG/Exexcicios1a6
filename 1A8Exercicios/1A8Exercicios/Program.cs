using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A8Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Uma empresa quer transmitir dados pelo telefone, mas está preocupada com a
            interceptação telefônica. Todos os seus dados são transmitidos como inteiros de quatro
            dígitos. Ela pediu para que você escreva um programa que criptografe seus dados, para
            que eles possam ser transmitidos com mais segurança. Seu aplicativo deve ler um inteiro
             quatro dígitos fornecidos pelo usuário e criptografá-lo da seguinte forma: substitua cada
            dígitos por (a soma desse dígitos mais 7) módulo 10. Em seguida, troque o primeiro dígito
            pelo terceiro e troque o segundo dígito pelo quarto e imprima o inteiro criptografado.*/

            int DECIMAL = 10;
            int CRIPTO = 7;
            int uni = 0;
            int dez = 0;
            int cent = 0;
            int mil = 0;
            int quociente = 0;
            int resDivisão = 0;

            Console.WriteLine("\ninsira seu numero de 4 digitos: ");
            Console.WriteLine();
            int dados = Convert.ToInt32(Console.ReadLine());

            //unidades
            resDivisão = dados % DECIMAL;
            quociente = (dados + CRIPTO) / DECIMAL;
            uni = resDivisão;

            //dezena
            resDivisão = quociente % DECIMAL;
            quociente = (quociente + CRIPTO) / DECIMAL;
            dez = resDivisão;

            //centena
            resDivisão = quociente % DECIMAL;
            quociente = (quociente + CRIPTO) / DECIMAL;
            cent = resDivisão;

            //milhar
            resDivisão = quociente % DECIMAL;
            quociente = (quociente + CRIPTO) / DECIMAL;
            mil = resDivisão;

            Console.WriteLine("\nNúmero criptografado: {0}{1}{2}{3}", cent, cent, uni, dez);

            Console.ReadKey();
            Console.Clear();

            /*2. Crie um programa em C# que determina se o cliente de uma loja de departamentos
            ultrapassou o limite de crédito em uma conta. Para cada cliente modelado em uma classe,
            os seguintes dados estão disponíveis:
            a. Número da conta;
            b. O saldo no início do mês;
            c. O total de todos os itens cobrados desse cliente no mês corrente;
            d. O total de todos os créditos aplicados na conta desse cliente no mês corrente;
            e. O limite de crédito permitido.
            O programa deve fornecer como valores inteiros cada um desses fatos, e através dos
            métodos da classe cliente: calcular o novo saldo (= saldo inicial + cobranças - créditos),
            exibir o novo saldo e determinar se o novo saldo ultrapassa o limite de crédito do cliente.
            Para os clientes cujo limite de crédito foi ultrapassado, o programa deve exibir a
            mensagem: “Limite de Crédito Excedido!”. Teste a classe criada, bem como os métodos
            propostos na classe principal do seu programa.*/

            

            Clientes c = new Clientes(1, 1000, 500, 1000, 2000);

            Clientes d = new Clientes(2, 2000, 0, 0, 2000);

            Console.WriteLine("Insira numero da conta: ");

            int conta = Convert.ToInt32(Console.ReadLine());

            if (conta == 1)
            {
                Console.WriteLine("\nSaldo atual: " + c.CalcularNovoSaldo());
                c.AtualizarSaldo();
                c.LimiteDeCredito();

            }
            else 
            {
                Console.WriteLine("\nSaldo atual: " + d.CalcularNovoSaldo());

                d.AtualizarSaldo();
                c.LimiteDeCredito();

            }


            Console.WriteLine("Tecle Enter para sair...");

            Console.ReadKey();
            Console.Clear();

            /*3. Implemente em C# a função booleana Par que retorna verdadeiro se um número inteiro
            passado como parâmetro for par ou falso caso ele seja ímpar. Teste seu programa
            chamando a função para verificar os números de 0 à 10.
             */
            Console.WriteLine("é Par?\n");
            int x = 0;
            


            for (x = 0; x <= 10; x++)
            {
                Console.WriteLine(x);
                Console.WriteLine( Par2(x));
            }
                Console.ReadKey(true);

            Console.Clear();

            /*4. Escreva um programa que leia 3 números inteiros referente ao comprimento dos lados de
            um triângulo e classifique como: triângulo equilátero, isósceles ou escaleno.*/

            Console.WriteLine("Classificador de triangulos");

            Console.WriteLine("\nInsira o valor do primeiro lado: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsira o valor do segundo lado: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsira o valor do terceiro lado: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if ((n1 == n2) && (n2 == n3))
            {
                Console.WriteLine("\nTriangulo equilatero!");
            }
            else
            if ((n1 == n2) && (n2 != n3) || (n1 != n2) && (n2 == n3) || (n1 == n2) && (n1 == n3))
            {
                Console.WriteLine("\nTriangulo isoceles! ");
            }
            else
            {
                Console.WriteLine("\nTriangulo escaleno");
            }

            Console.ReadKey(true);

            Console.Clear();

            /* 5. Escreva um programa que leia apenas uma letra do alfabeto como entrada e classifique-a
            como vogal ou consoante. Seu programa deverá aceitar como entrada apenas um
            caractere, ou seja, se o usuário digitar dois ou mais caracteres, o sistema deverá informar
            ao usuário a entrada rejeitada.*/

            Console.WriteLine("Digite um caractere:");
            Console.WriteLine("\nATENCAO!!! Apenas um carectere e aceito!");

            var caractere = Console.ReadLine();

            bool vogal = false;
            bool letra = true;

            string[] vogais = new string[] { "a", "i", "e", "o", "u", "A", "E", "I", "O", "U" };





            if (caractere.Length >= 2)
            {
                Console.WriteLine("\n\nEntrada rejeitada!");
                letra = false;
            }

            if (letra)
            {
                for (int i = 0; i < vogais.Length; i++)
                {

                    if (caractere[0].ToString() == vogais[i])
                    {
                        vogal = true;

                    }


                }

                if (vogal)
                {
                    Console.WriteLine("\n\nO caractere informado é uma vogal!");
                }
                else
                {
                    Console.WriteLine("\n\nO caractere informado é uma consoante!");
                }

            }

            Console.ReadKey();

            Console.Clear();


            /*6. “Um número é primo se ele for divisível por 1 e por ele mesmo”. Escreva um programa C#
            que verifica se um número é primo.*/



            Console.WriteLine("Insira um numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n");

            if (Primos(numero) == true)
            {
                Console.WriteLine("O numero " + numero + " É um número primo!");
            }
            else
            {
                Console.WriteLine("O numero " + numero + "  NÃO é um número primo!");
            }







            Console.ReadKey();







        }
        static bool Par(int x)
        {

            int resto = x % 2;


            if (resto == 0)
                return true;

            else
                return false;


        }
        static string Par2(int x)
        {


            int resto = x % 2;

            if (resto == 0)
                return "par";
            else
                return "ímpar";



        }

        static public bool Primos(int numero)
        {
            for (int x = 2; x < numero; x++)
            {
                if (numero % x == 0)
                    return false;
            }
            return true;
        }


    }
}
