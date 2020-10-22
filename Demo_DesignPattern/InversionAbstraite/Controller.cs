using Demo_DesignPattern.InversionAbstraite.Interfaces;

namespace Demo_DesignPattern.InversionAbstraite
{
	public class Controller
	{
		/**
		 * Des modules de haut niveau ne devraientt pas dépendre de modules bas niveau, mais plutôt d'une abstraction (interface ou constructeur ou champs)
		 * D = Inversion de dépendance => l'injection de dépendance est une manière (la plus courante) pour l'Invesion de dépendance
		 * Inversion de dépendance ou de contrôle
		 *
		 * Pourquoi ?
		 * Faciliter les modifications futures du code (changement de modules bas niveau, ne pas modifier partout dans un code spaghuetti)
		 * Réutiliser dans d'autres futurs projets avec une bonne base
		 * Généricité
		 * Compartimente les modules en les rendants indépendant de l'application => évite des effets en cascade si changement
		 *
		 * 1 - Créer des interfaces des modules de bas niveau
		 * 2 - Factory pour supprimer les new et réduire le couplage entre les modules
		 * 3 - Créer texter => changer Mailer to Texter dans la factory
		 * 4 - Magie, change tout le comportement de l'application en changeant 1 seule ligne et sans induire de bug !
		 */
		public Controller()
		{
			IPersonne personne = Factory.CreePersonne();
			personne.Nom = "Rantan";
			personne.Prenom = "Plan";
			personne.Mail = "google@apple.microsoft";
			personne.Telephone = "0471/0123456";

			ITache tache = Factory.CreeTache();
			tache.Nom = "Sortir les poubelles";
			tache.Proprietaire = personne;

			tache.Travaille(3);
			tache.Travaille(1.5);
			tache.CompleteTache();
		}
	}
}
