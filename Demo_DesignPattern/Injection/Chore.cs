namespace Demo_DesignPattern.Injection
{
	public class Chore
	{
		public string Nom { get; set; }
		public Personne Proprietaire { get; set; }
		public double HeuresTravaillees { get; set; }
		public bool EstTerminee { get; set; }

		public void Travaille(double heures)
		{
			HeuresTravaillees += heures;
			Logger logger = new Logger();
			logger.Log($"Heures travaillées sur '{Nom}'");
		}

		public void CompleteTache()
		{
			EstTerminee = true;

			Logger logger = new Logger();
			logger.Log($"Tâche {Nom} finie");

			Mailer emailer = new Mailer();
			emailer.SendMail(Proprietaire, $"La tâche '{Nom}' est terminée");
		}
	}
}
