using Demo_DesignPattern.InversionAbstraite.Interfaces;

namespace Demo_DesignPattern.InversionAbstraite
{
	public static class Factory
	{
		public static IPersonne CreePersonne()
		{
			return new Personne();
		}

		public static ITache CreeTache()
		{
			// fournit les objet pour que la classe puisse appeler les autres sans couplage
			return new Tache(CreeLogger(), CreeMessageSender());
		}

		public static ILogger CreeLogger()
		{
			return new Logger();
		}

		public static IMessageSender CreeMessageSender()
		{
			return new Texter();
		}
	}
}
