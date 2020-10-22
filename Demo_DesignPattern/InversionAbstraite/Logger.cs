using System;
using Demo_DesignPattern.InversionAbstraite.Interfaces;

namespace Demo_DesignPattern.InversionAbstraite
{
	public class Logger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine($@"Ecrit sur console {message}");
		}
	}
}
