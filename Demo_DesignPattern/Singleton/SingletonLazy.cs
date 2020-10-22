using System;

namespace Demo_DesignPattern.Singleton
{
	public class SingletonLazy : Singleton
	{
		private static readonly Lazy<SingletonLazy> Lazy = new Lazy<SingletonLazy>(() => new SingletonLazy());

		public static SingletonLazy Instance => Lazy.Value;

		private SingletonLazy()
		{
			NombreAleatoire = GenereNombreAleatoire();
		}
	}
}
