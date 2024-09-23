using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
	/// <summary>
    /// Operação soma.
    /// </summary>
    /// <returns>Retorna a soma de dois números.</returns>

    /// <summary>
    /// Operação subtração.
    /// </summary>
    /// <returns>Retorna o resultado da subtração de dois números.</returns>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.ReadKey();
        }
    }
	internal class Aritmetica
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }
    }
	 public int Subtrair(int x, int y)
    {
        return x - y;
    }
	
}
