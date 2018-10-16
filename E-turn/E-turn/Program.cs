using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_turn
{
    class Program
    {

        static void Main(string[] args)
        {

            /*1 - Implemente uma função que retorne um array de inteiros ordenado em ordem crescente, esta
                  função recebe arrays de inteiro ordenados.
                  Ex: a = {1, 2, 4, 5, 7}, b = {2, 3, 5, 6}
                  Resultado = {1, 2, 2, 3, 4, 5, 5, 6, 7}*/
            int[] primeiro = new int[] { 1, 2, 4, 5, 7 };
            int[] segundo = new int[] { 2, 3, 5, 6 };

            int[] resultado = primeiro
              .Concat(segundo)
              .OrderBy(x => x)
              .ToArray();

            // Resultado = {1, 2, 2, 3, 4, 5, 5, 6, 7}
            Console.Write(String.Join(", ", resultado));
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*2 - Implemente uma função que receba um array de inteiros e retorne o segundo maior valor contido
                  neste parâmetro de entrada.
                  Ex: Se a função receber o valor { 1, 9, 33, 12, 5 } ela deve retornar o valor 12*/

            int[] vetor = new int[5] { 1, 9, 33, 12, 5 };
            int second_maior = 0;
            int n = vetor.Length;
            Array.Sort(vetor);
            foreach (int i in vetor) ;
            second_maior = vetor[n - 2];

            Console.Write("O segundo maior numero é " + second_maior);
            Console.ReadKey();
            Console.Clear();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*3 - Antes dos smartphones, os telefones celulares não tinham muitos recursos e eram limitados quando
             tentavam executar uma serie de tarefas. Nesta época, para se enviar um SMS era necessário digitar o texto
             através de um teclado numérico onde a quantidade de vezes que um determinado número era digitado,
             significava uma letra sendo:
              O numero 0 correspondia ao espaço.
              O numero 1 não correspondia a nenhuma letra.
              O numero 2 correspondia as letras A, B e C.
              O numero 3 correspondia as letras D, E e F.
              O numero 4 correspondia as letras G, H e I.
              O numero 5 correspondia as letras J, K e L.
              O numero 6 correspondia as letras M, N e O.
              O numero 7 correspondia as letras P, Q, R e S.
              O numero 8 correspondia as letras T, U e V.
              O numero 9 correspondia as letras W, X, Y e Z.
             Para selecionar a letra, o usuário digitava quantas vezes necessária a tecla do número para chegar até a letra
             desejada conforme:
              Para selecionar a letra B o usuário digitava duas vezes o numero 2.
              Para selecionar a letra Z o usuário digitava quatro vezes o numero 9.
             Com base nestas informações, implemente um sistema para interpretar e apresentar o texto contido na string
             abaixo:

                 33 8 88 777 66 0 9 33 22 0 33 0 7777 666 333 8 9 2 777 33 0 7777 666 555 88 8 444 666 66

             Importante: o espaço entre os números indica que aquele numero foi digitado aquela quantidade de vezes.
             Exemplo: 88 o numero 8 foi digitado 2 vezes o que equivale a letra U.*/

            string caseSwitch = "2";
            switch (caseSwitch)
            {
                case "0":
                    Console.WriteLine(" ");
                    break;
                case "1":
                    Console.WriteLine("");
                    break;
                case "2":
                    Console.WriteLine("a");
                    break;
                case "22":
                    Console.WriteLine("b");
                    break;
                case "222":
                    Console.WriteLine("c");
                    break;
                case "3":
                    Console.WriteLine("d");
                    break;
                case "33":
                    Console.WriteLine("e");
                    break;
                case "333":
                    Console.WriteLine("f");
                    break;
                case "4":
                    Console.WriteLine("g");
                    break;
                case "44":
                    Console.WriteLine("h");
                    break;
                case "444":
                    Console.WriteLine("i");
                    break;
                case "5":
                    Console.WriteLine("j");
                    break;
                case "55":
                    Console.WriteLine("k");
                    break;
                case "555":
                    Console.WriteLine("l");
                    break;
                case "6":
                    Console.WriteLine("m");
                    break;
                case "66":
                    Console.WriteLine("n");
                    break;
                case "666":
                    Console.WriteLine("o");
                    break;
                case "7":
                    Console.WriteLine("p");
                    break;
                case "77":
                    Console.WriteLine("q");
                    break;
                case "777":
                    Console.WriteLine("r");
                    break;
                case "7777":
                    Console.WriteLine("s");
                    break;
                case "8":
                    Console.WriteLine("t");
                    break;
                case "88":
                    Console.WriteLine("u");
                    break;
                case "888":
                    Console.WriteLine("v");
                    break;
                case "9":
                    Console.WriteLine("w");
                    break;
                case "99":
                    Console.WriteLine("x");
                    break;
                case "999":
                    Console.WriteLine("y");
                    break;
                case "9999":
                    Console.WriteLine("z");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.ReadKey();
        }
    }

}
