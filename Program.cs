using System;
using System.Collections.Generic;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto celular1 = new Produto();
            celular1.Codigo = 1;
            celular1.Nome = "Iphone 11 Pro Max";
            celular1.Preco = 7500.99f;

            produtos.Add(celular1);

            produtos.Add( new Produto(2, "Samsung A51", 3900.99f) );
            produtos.Add( new Produto(3, "Lg ", 3900.99f));
            produtos.Add( new Produto(4, "Acer", 3900.99f));
            produtos.Add( new Produto(5, "Positivo",3900.99f));
            produtos.Add( new Produto(6, "Motorola", 3900.99f));

            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Red;              
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            produtos.Remove(celular1);

            produtos.RemoveAt(1);

            produtos.RemoveAll( p => p.Nome == "Acer");

            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Green;             
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            Produto positivo = produtos.Find(x => x.Nome == "Positivo");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine( positivo.Preco );
            Console.ResetColor();

            System.Console.WriteLine("_________________________________");
            System.Console.WriteLine("  ");

            List<Cartao> cartoes = new List<Cartao>();

            Cartao Visa = new Cartao();
            Visa.Titular = "Beatriz Claus";
            Visa.Numero = 09091995f;
            Visa.Bandeira = "Visa";
            Visa.Vencimento = "21/11/2025";
            Visa.CVV = 870;

            cartoes.Add(Visa);
            
            cartoes.Add( new Cartao("Beatriz Claus", 098756, "Cielo", "25/12/2023", 20));
            cartoes.Add( new Cartao("Beatriz Claus", 353678, "Mastercard", "06/01/2026", 20));
            cartoes.Add( new Cartao("Beatriz Claus", 242354, "AmericanExpress", "25/06/2020", 20));
            cartoes.Add( new Cartao("Beatriz Claus", 546783, "Elo", "12/11/2025", 20));

            foreach(Cartao c in cartoes){
                Console.ForegroundColor = ConsoleColor.Blue;              
                Console.WriteLine($"Beatriz Claus - {c.Bandeira}");
                Console.ResetColor();
            }
        }
    }
}