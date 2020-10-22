using System;

namespace Demo_DesignPattern.Injection
{
	public class Logger
	{
		public void Log(string message)
		{
			Console.WriteLine($@"Ecrit sur console {message}");
		}
	}
}
