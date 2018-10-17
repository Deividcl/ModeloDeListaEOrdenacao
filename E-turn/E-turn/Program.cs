using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_turn
{
    class Program
    {
        //Questao 3
        static string entrada = "33 8 88 777 66 0 9 33 22 0 33 0 7777 666 333 8 9 2 777 33 0 7777 666 555 88 8 444 666 66";
        static  ArrayList[] dicionarioTeclas = new ArrayList[10];

        static void Inicializa()
        {
            for (int i = 0; i < 10; i++)
                dicionarioTeclas[i] = new ArrayList();


            dicionarioTeclas[0].Add(" ");
            dicionarioTeclas[1].Add("");

            dicionarioTeclas[2].Add("A");
            dicionarioTeclas[2].Add("B");
            dicionarioTeclas[2].Add("C");


            dicionarioTeclas[3].Add("D");
            dicionarioTeclas[3].Add("E");
            dicionarioTeclas[3].Add("F");

            dicionarioTeclas[4].Add("G");
            dicionarioTeclas[4].Add("H");
            dicionarioTeclas[4].Add("I");

            dicionarioTeclas[5].Add("J");
            dicionarioTeclas[5].Add("K");
            dicionarioTeclas[5].Add("L");

            dicionarioTeclas[6].Add("M");
            dicionarioTeclas[6].Add("N");
            dicionarioTeclas[6].Add("O");

            dicionarioTeclas[7].Add("P");
            dicionarioTeclas[7].Add("Q");
            dicionarioTeclas[7].Add("R");
            dicionarioTeclas[7].Add("S");

            dicionarioTeclas[8].Add("T");
            dicionarioTeclas[8].Add("U");
            dicionarioTeclas[8].Add("V");

            dicionarioTeclas[9].Add("W");
            dicionarioTeclas[9].Add("X");
            dicionarioTeclas[9].Add("Y");
            dicionarioTeclas[9].Add("Z");

        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


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
            int p = vetor.Length;
            Array.Sort(vetor);
            foreach (int i in vetor) ;
            second_maior = vetor[p - 2];

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

            Inicializa();

            string[] teclas = entrada.Split(' ');

            for (int i = 0; i < teclas.Length; i++)
            {
                string teclaDigitada = teclas[i];
                int teclaLida = Int32.Parse(teclaDigitada[0].ToString());
                int n = teclaDigitada.Length;

                Console.Write(dicionarioTeclas[teclaLida][n - 1]);

            }


            Console.ReadKey(true);
        }
    }
    }


