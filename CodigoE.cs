using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{
			float soma = 0;
			float[,] tabela = new float[2,2];
			
			for (int lin = 0; lin < 2; lin++) {

				for (int col = 0; col < 2; col++) {
					
					Console.WriteLine("Digite o numero do elemento[{0}, {1}]", lin, col);
					float	numero = float.Parse(Console.ReadLine());
					tabela[lin, col] = numero;
					soma += numero;
				}
			}
			Console.WriteLine("MATRIZ 2x2");
			
			for (int lin = 0; lin < 2; lin++) {
				for (int col = 0; col < 2; col++) {
														
					Console.Write(tabela[lin, col] + " ");
				}
			}
			Console.WriteLine(" ");
			float total = soma / 4;
			Console.WriteLine("A média da matriz é: "+ total);
			Console.ReadKey(true);
		}

	}

}
