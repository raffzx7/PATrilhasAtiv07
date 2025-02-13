using System;

namespace att01
{
    class Program
    {
        public static void Main()
        {
            int numero, total = 0;
            Random rand = new Random();
            int[,] tabela = new int[4, 2];
            
            for (int lin = 0; lin < 4; lin++) {
                Console.Write("\n\r ");
                    
                for (int col = 0; col < 2; col++) {
                    tabela[lin, col] = rand.Next(0, 9);
                    Console.Write(tabela[lin, col] + " ");
                    
                    numero = tabela[lin, col];
                    total += numero;
                }
            }
            Console.WriteLine("Total: " + total);
            Console.ReadKey(true);
        }
      
    }
  
}
