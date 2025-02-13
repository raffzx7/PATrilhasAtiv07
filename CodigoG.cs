using System;

class Program
{
    static void Main()
    {
    	int par = 0;
    	int[,] matriz4x4 = new int[4, 4];
    	Random rand = new Random();
    	
    	Console.WriteLine("MATRIZ 4x4");
    	Console.WriteLine("----------");
    	
    	for(int i = 0; i < 4; i++)
    	{
    		for(int j = 0; j < 4; j++)
    		{
    			matriz4x4[i, j] = rand.Next(1, 100);
    			Console.Write(matriz4x4[i, j] + " ");
    		}
    		Console.WriteLine();
    	}
    	Console.WriteLine("----------");
    	Console.WriteLine("\n\rOs números pares são: ");
		for(int i = 0; i < 4; i++)
    	{
    		for(int j = 0; j < 4; j++)
    		{
    			if (matriz4x4[i, j] % 2 == 0)
    			    {
    			    	par = matriz4x4[i, j];
    			    	Console.Write(par+ " ");
    			    }
    		}

    	}
		Console.WriteLine();
        Console.ReadKey();    	    	
    }

}
