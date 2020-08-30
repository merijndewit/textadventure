using System;

namespace Zuul
{
	public class Inventory
	{
		public static string[] inventoryItems;
		public static string inv1;
		public static string inv2;
		public static string inv3;
		public static string inv4;
		public static string inv5;


		public Inventory()
		{
			inv1 = null;
			inv2 = null;
			inv3 = null;
			inv4 = null;
			inv5 = null;
			inventoryItems = new string[5] { inv1, inv2, inv3, inv4, inv5 };

		}

		public static void makeInventory()
		{
			inventoryItems = new string[5] {inv1, inv2, inv3, inv4, inv5};

			if (inv1 != null)
			{
				Console.WriteLine("inventory slot 1:" + inventoryItems[0]);
			}
			else if (inv2 != null)
			{
				Console.WriteLine("inventory slot 2:" + inventoryItems[1]);
			}
			else if (inv3 != null)
			{
				Console.WriteLine("inventory slot 3:" + inventoryItems[2]);
			}
			else if (inv4 != null)
			{
				Console.WriteLine("inventory slot 4:" + inventoryItems[3]);
			}
			else if (inv5 != null)
			{
				Console.WriteLine("inventory slot 5:" + inventoryItems[4]);
			}

		}


		public static void printInventory()
		{ 
		
		
		}


		











	}
}