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
					if (lin == col) {
						Console.Write(" " + " ");
					}
					else {
						Console.Write(tabela[lin, col] + " ");
					}
					
				}
        
			}
			Console.ReadKey(true);
		}
    
	}
  
}
