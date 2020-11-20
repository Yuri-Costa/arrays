using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual tamanho da lista que voce quer?");
            int tamanho = int.Parse(Console.ReadLine());
            Console.Foreground = ConsoleColor.Green;

            string[] nomesalunos = new string[tamanho];
            

            for(int i = 0 < nomesalunos.Length; i++){
                Console.Write("digite um nome :");
                nomesalunos[i] = Console.ReadLine();

            }

             for(var i = 0 < nomesalunos.Length; i++){
                  Console.WriteLine(nomesalunos[i]);
             }


            
            
        }
    }
}
