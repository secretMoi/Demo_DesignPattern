﻿using System;
using System.Collections.Generic;

namespace Demo_DesignPattern.Singleton
{
	/**
	 * Avantages singleton sur static
	 * + héritage
	 * + simple à tester
	 * + Sérialisation
	 * + Permet de cloner l'objet
	 * + Suit les règles de la POO
	 * + possibilité d'implémenter des interfaces
	 * + peut être initialisé en async ou en lazy
	 *
	 * Choisir static seulement si aucun état ne doit être stocké : ex classe Math
	 */
	public class SingletonSimple
	{
		private static SingletonSimple _instance;
		private readonly List<int> _list = new List<int>();

		/**
		 * Lecture Seule
		 * Crée une instance si aucune n'existe
		 * Ne crée donc rien si une existe => Singleton
		 */
		public static SingletonSimple Instance
		{
			get
			{
				if(_instance == null)
					_instance = new SingletonSimple();

				return _instance;
			}
		}

		public int NombreAleatoire { get; }

		/**
		 * Constructeur en privé, empêche toute nouvelle instance accidentelle en dehors de la classe
		 */
		private SingletonSimple()
		{
			NombreAleatoire = GenereNombreAleatoire();
		}

		/**
		 * <summary>Génère un nombre aléatoire à chaque appel</summary>
		 */
		public static int GenereNombreAleatoire()
		{
			Random random = new Random();
			return random.Next(Int32.MinValue, int.MaxValue);
		}

		public void DoSomething()
		{
			for (int i = 0; i < 1000000; i++)
			{
				_list.Add(i);
				_list.Remove(i);
			}
		}
	}
}
