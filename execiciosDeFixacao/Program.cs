using System;
using System.Globalization;

namespace execiciosDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Exercicio 1 Saida de Dados///

            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine(produto1 + ", cujo preço é $" + preco1.ToString("F2"));
            //Console.WriteLine(produto2 + ", cujo preço é $" + preco2.ToString("F2"));

            //Console.Write("Registro:");
            //Console.WriteLine(idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            //Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            //Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


            ///Exercicio 2 Entrada de Dados///

            Console.WriteLine("Entre com o seu nome completo");

            string nome = Console.ReadLine();



            Console.WriteLine("Quantos quartos tem na sua casa");

            var numero = Console.ReadLine();



            Console.WriteLine("Entre com o preço de um produto");

            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Console.WriteLine("Entre com com ultimo nome, idade, e altura");

            string[] dados = Console.ReadLine().Split(' ');



            Console.WriteLine(nome);

            Console.WriteLine(numero);

            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            string ultimoNome = dados[0];

            int idade = int.Parse(dados[1]);

            float altura = float.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine(ultimoNome);

            Console.WriteLine(idade);

            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}