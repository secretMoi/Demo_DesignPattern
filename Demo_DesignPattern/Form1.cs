using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Demo_DesignPattern.Singleton;

namespace Demo_DesignPattern
{
	public partial class Form1 : Form
	{
		private readonly IList<SingletonSimple> _singletonsSimples = new List<SingletonSimple>();
		private readonly IList<SingletonLazy> _singletonsLazy = new List<SingletonLazy>();

		public Form1()
		{
			InitializeComponent();
		}

		private void buttonSimple_Click(object sender, System.EventArgs e)
		{
			labelNombre.Text = SingletonSimple.GenereNombreAleatoire().ToString();
			labelNombreSingleton.Text = SingletonSimple.Instance.NombreAleatoire.ToString();

			//var test = new Singleton.Singleton(); // -> OK
			//var test = new SingletonSimple(); // --> erreur, constructeur privé
		}

		private void buttonSingletonSimpleThread_Click(object sender, System.EventArgs e)
		{
			for(int i = 0; i < 100; i++)
				CreerTaskSingletonSimple();

			labelInstancesSimple.Text = _singletonsSimples.Count.ToString();
		}

		private void CreerTaskSingletonSimple() 
		{
			Thread thread = new Thread(CreerSingletonSimple);
			thread.Start();
		}

		private void CreerSingletonSimple()
		{
			var singleton = SingletonSimple.Instance;

			if (!_singletonsSimples.Contains(singleton))
				_singletonsSimples.Add(singleton);
		}

		private void buttonSingletonLazy_Click(object sender, System.EventArgs e)
		{
			labelLazyNombre.Text = SingletonLazy.GenereNombreAleatoire().ToString();
			labelInLazyNombre.Text = SingletonLazy.Instance.NombreAleatoire.ToString();
		}

		private void buttonSingletonLazyThread_Click(object sender, System.EventArgs e)
		{
			for (int i = 0; i < 100; i++)
				CreerTaskSingletonLazy();

			labelInstancesLazy.Text = _singletonsLazy.Count.ToString();
		}

		private void CreerTaskSingletonLazy()
		{
			Thread thread = new Thread(CreerSingletonLazy);
			thread.Start();
		}

		private void CreerSingletonLazy()
		{
			var singleton = SingletonLazy.Instance;

			if (!_singletonsLazy.Contains(singleton))
				_singletonsLazy.Add(singleton);
		}
	}
}
