using System;
using Demo_DesignPattern.InversionAbstraite.Interfaces;

namespace Demo_DesignPattern.InversionAbstraite
{
	public class Texter : IMessageSender
	{
		public void SendMessage(IPersonne personne, string message)
		{
			Console.WriteLine($@"Envoie d'un message à {personne.Prenom} pour dire {message}");
		}
	}
}
