using System;
using System.Collections.Generic;
using System.Text;

namespace TestePraVariar
{
    public class NumberDraw
    {

        public List<int> AddValores(int numeros)
        {
            var sorteados = new List<int>();

            var sorteadosAleatorios = new Random();

            numeros = GeraNumeroAleatorio(sorteadosAleatorios);

         

                while (sorteados.Count <= 10)
                {
                    sorteados.Add(numeros);
                }

                //sorteados.RemoveAt

            var a = int.Parse(sorteados.ToArray().GetValue(1).ToString());
            if (sorteados.Contains(a))
            {
                numeros = GeraNumeroAleatorio(sorteadosAleatorios);
            }
            return sorteados;
        }

       public void PrintNumeros(int numeros)
        {

            for (int i = 0; i <= 10; i++)
            {
                int valores = int.Parse(AddValores(numeros).ToArray().GetValue(i).ToString());
       
                    AddValores(numeros);

                Console.WriteLine(valores);
            }

        }

        //static bool ValidaNumeros(int numero) => numero >= 10 ? false : true;

        public int GeraNumeroAleatorio(Random numero) => numero.Next(0, 9);
    }
}

