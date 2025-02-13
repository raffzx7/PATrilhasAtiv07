using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{
			Random rand = new Random();
			int[,] tabela = new int[10,10];
			
			for (int lin = 0; lin < 10; lin++) {
				Console.Write("\n\r ");	
					
				for (int col = 0; col < 10; col++) {
					tabela [lin,col] = rand.Next(0 ,9);
					Console.Write(tabela[lin, col] + " ");
				}
			}
			Console.WriteLine("Os numeros diagonaais principais são:");
			for (int lin = 0; lin < 10; lin++) {
				Console.Write(tabela[lin, lin] + " ");
			}
			Console.ReadKey(true);
		}
    
	}
  
}
