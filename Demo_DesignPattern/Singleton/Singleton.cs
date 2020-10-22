using System;
using System.Collections.Generic;

namespace Demo_DesignPattern.Singleton
{
	public class Singleton
	{
		protected readonly List<int> List = new List<int>();

		public int NombreAleatoire { get; protected set; }

		/**
		 * <summary>Génère un nombre aléatoire à chaque appel</summary>
		 */
		public static int GenereNombreAleatoire()
		{
			Random random = new Random();
			return random.Next(Int32.MinValue, int.MaxValue);
		}
	}
}
