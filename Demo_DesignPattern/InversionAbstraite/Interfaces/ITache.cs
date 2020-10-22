namespace Demo_DesignPattern.InversionAbstraite.Interfaces
{
	public interface ITache
	{
		string Nom { get; set; }
		IPersonne Proprietaire { get; set; }
		double HeuresTravaillees { get; set; }
		bool EstTerminee { get; set; }
		void Travaille(double heures);
		void CompleteTache();
	}
}