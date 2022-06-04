using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_de_Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar a matriz
            string[,] cadastro = new string[5, 4];
            string resposta = "s";
            int linha = 0;
            while (resposta == "s")

            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Cadastro de contatos");
                Console.WriteLine("Cpf:");
                cadastro[linha, 0] = Console.ReadLine();

                Console.WriteLine("Nome:");
                cadastro[linha, 1] = Console.ReadLine();
                Console.WriteLine("Telefone:");
                cadastro[linha, 2] = Console.ReadLine();
                Console.WriteLine("E-mail:");
                cadastro[linha, 3] = Console.ReadLine();

                linha++;
                Console.WriteLine("Deseja Castrar mais clientes(s/n)");
                resposta = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("|{0,-10}|{1,-30}|{2,-20}|{3,-20}","Cpf","Nome","Telefone","E-mail");
            Console.WriteLine(new String('-',80));
            
         for (int i = 0; i < 5; i++) 
         {
                
                Console.WriteLine("|{0,-10}|{1,-30}|{2,-20}|{3,-10}", cadastro[i,0],cadastro[i,1],cadastro[i,2],cadastro[i,3] );
                Console.WriteLine(new string ( '-',80));
             
           
            
         }
            Console.ReadKey();




            
         
           
         
            

           
            
            
        }
    }
}
