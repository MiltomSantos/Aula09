using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09ProdutosEstoque
{
    class Program
    {
           static List<string> produtos = new List<string> {"pepsi", "fanta" };
        static void Main(string[] args)
        {


            Console.WriteLine("Bem vindo ao Conradito Store");

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar e 2 para listar");
                string resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.WriteLine("Digite o nome do produto:");
                    string produto = Console.ReadLine();                

                    if (produtos.Contains(produto))
                    {
                        Console.WriteLine("Este produto já está na lista....");
                        Console.ReadLine();
                        Main(null);
                        return;
                    }
                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto cadastrado com sucesso!");
                        Console.ReadLine();
                        Main(null);
                        return;
                    }

                }
                else
                {
                    string texto = "";
                    int contador = 0;

                    while (contador < produtos.Count)
                    {
                        string nome = produtos[contador];
                        string primeiraLetra = nome.Substring(0, 1).ToUpper();
                        string resto = nome.Substring(1, nome.Length - 1);
                        string nomePronto = primeiraLetra + resto;

                        texto += nomePronto + ", ";
                        contador++;
                    }
                    string textoPronto=texto.Substring(0, texto.Length - 2);
                    Console.WriteLine(textoPronto);
                }
            }
            

        }
        
    }
}
