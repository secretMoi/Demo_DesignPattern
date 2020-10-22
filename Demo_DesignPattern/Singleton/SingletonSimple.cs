namespace Demo_DesignPattern.Singleton
{
	/**
	 * Avantages singleton sur static
	 * + héritage
	 * + simple à tester
	 * + Sérialisation
	 * + Permet de cloner l'objet
	 * + Suit les règles de la POO
	 * + possibilité d'implémenter des interfaces
	 * + peut être initialisé en async ou en lazy
	 *
	 * Choisir static seulement si aucun état ne doit être stocké : ex classe Math
	 */
	public class SingletonSimple : Singleton
	{
		private static SingletonSimple _instance;

		/**
		 * Lecture Seule
		 * Crée une instance si aucune n'existe
		 * Ne crée donc rien si une existe => Singleton
		 */
		public static SingletonSimple Instance
		{
			get
			{
				if(_instance == null)
					_instance = new SingletonSimple();

				return _instance;
			}
		}

		/**
		 * Constructeur en privé, empêche toute nouvelle instance accidentelle en dehors de la classe
		 */
		private SingletonSimple()
		{
			NombreAleatoire = GenereNombreAleatoire();
		}
	}
}
