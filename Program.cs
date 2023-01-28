using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{//Profe, con mucho amor y dedicación me quedé hasta las 12:17 am haciendo esto JAJAJAJ
	internal class Program
	{
		static void Main(string[] args)
		{

			int[] edad = new int[] { 20, 22, 33 };
			float[] Salarios = new float[] { 200, 300, 150 };
			String[] musico = new string[3];
			musico[0] = "Ringo";
			musico[1] = "Paul";
			musico[2] = "John";
			float total = 0;
			for (int i = 0; i < musico.Length; i++)
			{
				// double IVA = Salarios[i] * 0.13;
				float IVA = 0;
				IVA = Salarios[i] * 0.13f;
				Console.WriteLine($"{musico}[i] EDAD: {edad[i]} Salario: {Salarios[i]} IVA:{IVA} Total:{Salarios[i]+IVA} ");
				
				
			
			}
			Console.ReadLine();












		}
	}

}