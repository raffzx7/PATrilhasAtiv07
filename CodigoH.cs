using System;

namespace PATrilhasAtiv07
{
	class Program
	{
		public static void Main(string[] args)
		{
		int diagonalprincipal = 0;
		int diagonalsecundaria = 0;	
		double mediaprincipal = 0;
		double mediasecundaria = 0;
		
		Random rand = new Random();	
    	int [,] matriz10 = new int[10, 10];
    	
    	for (int i = 0; i < 10; i++) 
    	{
    		for (int j = 0; j < 10; j++) 
    		{
    			matriz10[i, j] = rand.Next(0, 9);
    			Console.Write(matriz10[i, j] + " |");
    		}
    		Console.WriteLine();
    	}
    	Console.WriteLine("\n\rElementos diagonais da matriz: ");
      
    	for (int i = 0; i < 10; i++)
    	{
    		diagonalprincipal += matriz10[i, i];
    	}   
    	
    	for (int i = 0; i < 10; i++)
    	{
    		diagonalsecundaria += matriz10[i, 9 - i];
    	} 
		mediaprincipal = diagonalprincipal / 10;  
  		mediasecundaria = diagonalsecundaria / 10;
    	
    	Console.WriteLine("A soma da diagonal principal é {0} e sua média é {1:F2}.", diagonalprincipal, mediaprincipal);
    	Console.WriteLine("A soma da diagonal secundaria é {0} e sua média é {1:F2}.", diagonalsecundaria, mediasecundaria);
		Console.ReadKey(true);
		}

	}

}
