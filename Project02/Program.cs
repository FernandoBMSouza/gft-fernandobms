using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		System.Console.Write("Insira a quantidade de numeros a serem armazenados: ");
		int n = int.Parse(Console.ReadLine());

		int[] numeros = new int[n];

		System.Console.WriteLine("Insira os valores: ");
		for (int i = 0; i < n; i++)
		{
			numeros[i] = int.Parse(Console.ReadLine());
		}

		int[] retiraDuplicados = numeros.Distinct().ToArray();
		int[] ordemCrescente = retiraDuplicados.OrderBy(i => i).ToArray();
		
		Console.WriteLine("\nVetor sem Duplicatas e em ordem crescente:");
		foreach(int item in ordemCrescente) Console.WriteLine(item);
	}
}