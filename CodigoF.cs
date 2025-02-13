using System;

class Program
{
    static void Main()
    {
    	int[,] matriz3x3 = new int[3, 3];
    	Random rand = new Random();
    	int maiornumero = int.MinValue;
    	
    	Console.WriteLine("MATRIZ 3x3");
    	Console.WriteLine("----------");
    	
    	for(int i = 0; i < 3; i++)
    	{
    		for(int j = 0; j < 3; j++)
    		{
    			matriz3x3[i, j] = rand.Next(1, 100);
    			Console.Write(matriz3x3[i, j] + " ");
    		}
    		Console.WriteLine();
    	}
      	
    	Console.WriteLine("----------");
    	
		for(int i = 0; i < 3; i++)
    	{
    		for(int j = 0; j < 3; j++)
    		{
    			if (maiornumero < matriz3x3[i, j])
    			    {
    			    	maiornumero = matriz3x3[i, j];
    			    }
    		}

    	}
		Console.WriteLine("O maior número da matriz é: {0}", maiornumero);
        Console.ReadKey();    	    	
    }

}
