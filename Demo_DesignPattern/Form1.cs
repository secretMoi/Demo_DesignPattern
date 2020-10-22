using System.Threading;
using System.Windows.Forms;
using Demo_DesignPattern.Singleton;

namespace Demo_DesignPattern
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonSimple_Click(object sender, System.EventArgs e)
		{
			labelNombre.Text = SingletonSimple.GenereNombreAleatoire().ToString();
			labelNombreSingleton.Text = SingletonSimple.Instance.NombreAleatoire.ToString();

			//var test = new SingletonSimple(); // --> erreur, constructeur privé
		}

		private void buttonSingletonSimpleThread_Click(object sender, System.EventArgs e)
		{
			for(int i = 0; i < 100000; i++)
				CreerTaskSingletonSimple();
		}

		private void CreerTaskSingletonSimple() 
		{
			Thread thread = new Thread(CreerSingletonSimple);
			thread.Start();
		}

		private void CreerSingletonSimple()
		{
			SingletonSimple.Instance.DoSomething();
		}
	}
}
