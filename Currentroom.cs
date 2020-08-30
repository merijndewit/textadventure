using System;

namespace Zuul
{
	public class Currentroom
	{
		public static float playerCurrentRoom;
		public static float outside;


		public Currentroom()
		{



		}

		public static void getCurrentRoomItems()
		{

			if (Game.descRoom == "outside the main entrance of the university")
			{

				Items.printOutsideItems();

			}
			else if (Game.descRoom == "in a lecture theatre")
			{

			}
			else if (Game.descRoom == "in the campus pub")
			{

			}
			else if (Game.descRoom == "in a computing lab")
			{
				Items.printLabItems();
			}
			else if (Game.descRoom == "in the computing admin office")
			{

			}


		}

		public static void useItems()
		{
			Game.getCurrentRoomDescription();
			if (Game.descRoom == "you're in the basement of the lab" && Items.lantern == false)
			{


				Console.WriteLine("you've hurt yourself by grabbing a knife from the wrong end...");
				Player.giveDamage();
			}
			else if (Game.descRoom == "you're in the basement of the lab" && Items.lantern == true)
			{

			}
			else if (Game.descRoom == "outside the main entrance of the university")
			{
				Currentroom.getCurrentRoomItems();
				Items.outsideItem = false;

				if (Inventory.inv1 == null)

				{
					Inventory.inv1 = "stick";
				}
				Console.WriteLine(Inventory.inv1);
			}

		}
		public static void grabItem()
		{
			if (Game.descRoom == "outside the main entrance of the university")
			{

				Items.outsideItem = false;

				if (Inventory.inv1 == null)

				{
					Inventory.inv1 = "stick";
				}
				else if (Inventory.inv2 == null)
				{
					Inventory.inv2 = "stick";
				}
			}
		}
	}
}
