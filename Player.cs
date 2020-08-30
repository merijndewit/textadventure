using System;

namespace Zuul
{
	public class Player
	{
		public static float health;
		private static float damage;
		private static float healing;
		private static bool isAlive;
		


		public Player()
		{

			health += 100;
			damage = -10;
			healing = 20;
			isAlive = true;

		}
		public static void giveDamage()
		{
			health += damage;

		}

		public static void heal()
		{
			if (health < 100)
			{
				health += healing;
			}

		}

		public static void alive()
		{
			if (health <= 100)
			{
				isAlive = false;
			}
		
		}
	}
}
