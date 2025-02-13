using System;

namespace PATrilhasAtiv07
{
	class Program
	{
		public static void Main(string[] args)
		{		
			string[] nomeloja = {"Loja A", "Loja B", "Loja C", "Loja D", "Loja E", "Loja F", "Loja G", "Loja H"};
			
			string[] nomeprodutos = {"Geladeira", "Microondas", "Tablet", "Televisão"};
			
			double[,] precoprodutos = new double[8, 4];
			Random rand = new Random();

			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					precoprodutos[i, j] = rand.Next(40, 200);
				}
				
			}
			Console.WriteLine("Produtos com preços até R$ 120,00: \n");
			
			for (int i = 0; i < 8; i++)
			{
					for (int j = 0; j < 4; j++)
					{
						if (precoprodutos[i, j] <= 120)
						{
							Console.WriteLine("Produto: {0} | Loja: {1} | Preço: R$ {2:F2}", nomeprodutos[j], nomeloja[i], precoprodutos[i, j] );
							Console.WriteLine("----------------------------------------------------------------------------");
						}
            
					}
        
			 }
		Console.ReadKey(true);
		}
    
	}
  
}
