using System;

namespace Demo_DesignPattern.Injection
{
	public class Mailer
	{
		public void SendMail(Personne personne, string message)
		{
			Console.WriteLine($@"Ecrit par mail à {personne.Mail} : {message}");
		}
	}
}
