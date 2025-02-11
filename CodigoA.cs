using System;

class Program
{
    static void Main()
    {
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
    	Console.WriteLine("elemntos diagonais na matriz: ");
      
    	for (int i = 0; i < 10; i++)
    	{
    		Console.WriteLine(matriz10[i, i] + " ");
    	}        
        Console.ReadKey();    	    	
    }
    
}
