using System;

namespace Zuul
{
	public class Items
	{
		public static string stick;
		private static float stickDamage;
		public static bool lantern;
		public static string[] outsideItems;
		public static string[] labItems;
		public static string[] labBasementItems;
		public static bool labItem;
		public static bool outsideItem;



		public Items()
		{
			stickDamage = -5;
			labItem = true;
			outsideItem = true;
			lantern = false;

		}


		public static void printLabItems()
		{
			labItems = new string[1] {"lantern"};
			if (labItem == true)
			{
				Console.WriteLine(labItems[0]);
			}

		}
		public static void printOutsideItems()
		{
			outsideItems = new string[1] { "stick" };
			if (outsideItem == true)
			{
				Console.WriteLine(outsideItems[0]);
			}
			Inventory.inv1 = "stick";
		}

		public static void printBasementLabItems()
		{
			labBasementItems = new string[1] { "stick" };
			Console.WriteLine(labBasementItems[0]);

		}











	}   
}

