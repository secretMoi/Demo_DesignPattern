namespace Demo_DesignPattern.Injection
{
	public class Controller
	{
		/**
		 * Des modules de haut niveau ne devraientt pas dépendre de modules bas niveau, mais plutôt d'une abstraction (interface)
		 */
		public Controller()
		{
			Personne personne = new Personne()
			{
				Nom = "Rantan",
				Prenom = "Plan",
				Mail = "google@apple.microsoft",
				Telephone = "0471/0123456"
			};

			Chore tache = new Chore()
			{
				Nom = "Sortir les poubelles",
				Proprietaire = personne
			};

			tache.Travaille(3);
			tache.Travaille(1.5);
			tache.CompleteTache();
		}
	}
}
