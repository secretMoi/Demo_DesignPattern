using Demo_DesignPattern.InversionAbstraite.Interfaces;

namespace Demo_DesignPattern.InversionAbstraite
{
	public class Personne : IPersonne
	{
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public string Telephone { get; set; }
		public string Mail { get; set; }
	}
}
