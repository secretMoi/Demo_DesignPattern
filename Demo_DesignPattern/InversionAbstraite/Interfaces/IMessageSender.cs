namespace Demo_DesignPattern.InversionAbstraite.Interfaces
{
	public interface IMessageSender
	{
		void SendMessage(IPersonne personne, string message);
	}
}