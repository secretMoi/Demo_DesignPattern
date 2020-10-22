using System;
using Demo_DesignPattern.InversionAbstraite.Interfaces;

namespace Demo_DesignPattern.InversionAbstraite
{
	public class Emailer : IMessageSender
	{
		public void SendMessage(IPersonne personne, string message)
		{
			Console.WriteLine($@"Ecrit par mail à {personne.Mail} : {message}");
		}
	}
}
