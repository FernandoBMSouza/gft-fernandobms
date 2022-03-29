using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
        System.Console.Write("Insira a quantidade de valores a serem armazenados: ");
        int n = int.Parse(Console.ReadLine());

		int[] numeros = new int[n];
		int[] retiraDuplicados = numeros.Distinct().ToArray();
		
        System.Console.WriteLine("Insira os valores: ");
		for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }
		
		Console.WriteLine("Array com duplicados removidos:");
		foreach(int item in retiraDuplicados) Console.WriteLine(item);
	}
}