using Demo_DesignPattern.InversionAbstraite.Interfaces;

namespace Demo_DesignPattern.InversionAbstraite
{
	public class Tache : ITache
	{
		// changement
		private readonly ILogger _logger;
		private readonly IMessageSender _messageSender;

		public string Nom { get; set; }
		public IPersonne Proprietaire { get; set; } // changement
		public double HeuresTravaillees { get; set; }
		public bool EstTerminee { get; set; }

		/**
		 * Constructeur avec paramètre pour réduire encore le couplage
		 */
		public Tache(ILogger logger, IMessageSender messageSender)
		{
			_logger = logger;
			_messageSender = messageSender;
		}

		public void Travaille(double heures)
		{
			HeuresTravaillees += heures;

			// changement
			_logger.Log($"Heures travaillées sur '{Nom}'"); // changement
		}

		public void CompleteTache()
		{
			EstTerminee = true; // changement

			_logger.Log($"Tâche {Nom} finie"); // changement

			// changement
			_messageSender.SendMessage(Proprietaire, $"La tâche '{Nom}' est terminée");
		}
	}
}
