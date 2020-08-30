using System;

namespace Zuul
{
	public class Game
	{
		private Parser parser;
		public static Room currentRoom;
		public Player Pl;
		public float playerHealth;
		public static string descRoom;

		public Game()
		{
			createRooms();
			
			parser = new Parser();
			

		}

		public void createRooms()
		{
			Room outside, theatre, pub, lab, office, theatreUp, theatreDown, labDown;

			// create the rooms
			outside = new Room("outside the main entrance of the university");
			theatre = new Room("in a lecture theatre");
			pub = new Room("in the campus pub");
			lab = new Room("in a computing lab");
			office = new Room("in the computing admin office");
			labDown = new Room("you're in the basement of the lab");
			theatreUp = new Room("");
			theatreDown = new Room("");

			// initialise room exits
			outside.setExit("east", theatre);
			outside.setExit("south", lab);
			outside.setExit("west", pub);

			theatre.setExit("west", outside);
			theatre.setExit("up", theatreUp);
			theatre.setExit("down", theatreDown);

			pub.setExit("east", outside);

			lab.setExit("north", outside);
			lab.setExit("east", office);
			lab.setExit("down", labDown);

			office.setExit("west", lab);

			theatreDown.setExit("up", theatre);
			theatreUp.setExit("down", theatre);
			labDown.setExit("up", lab);

			currentRoom = outside;  // start game outside
		
		}


		/**
	     *  Main play routine.  Loops until end of play.
	     */
		public void play()
		{
			printWelcome();

			// Enter the main command loop.  Here we repeatedly read commands and
			// execute them until the game is over.
			bool finished = false;
			while (!finished)
			{
				Command command = parser.getCommand();
				finished = processCommand(command);
			}
			Console.WriteLine("Thank you for playing.");
		}

		/**
	     * Print out the opening message for the player.
	     */
		private void printWelcome()
		{
			Console.WriteLine();
			Console.WriteLine("Welcome to Zuul!");
			Console.WriteLine("Zuul is a new, incredibly boring adventure game.");
			Console.WriteLine("Type 'help' if you need help.");
			Console.WriteLine();
			Console.WriteLine(currentRoom.getLongDescription());
		}

		/**
	     * Given a command, process (that is: execute) the command.
	     * If this command ends the game, true is returned, otherwise false is
	     * returned.
	     */
		private bool processCommand(Command command)
		{
			bool wantToQuit = false;

			if (command.isUnknown())
			{
				Console.WriteLine("I don't know what you mean...");
				return false;
			}

			string commandWord = command.getCommandWord();
			switch (commandWord)
			{
				case "help":
					printHelp();
					break;
				case "go":
					goRoom(command);
					break;
				case "quit":
					wantToQuit = true;
					break;
				case "look":
					printLook();
					break;
				case "search":
					printSearch();
					break;
				case "inventory":
					printInventory();
					break;
				case "grab":
					getItem();
					break;
				case "drop":
					drop(command);
					break;
				case "use":
					use(command);
					break;
			
			}

			return wantToQuit;
		}

		// implementations of user commands:

		/**
	     * Print out some help information.
	     * Here we print some stupid, cryptic message and a list of the
	     * command words.
	     */
		private void printHelp()
		{
			Console.WriteLine("You are lost. You are alone.");
			Console.WriteLine("You wander around at the university.");
			Console.WriteLine();
			Console.WriteLine("Your command words are:");
			parser.showCommands();
			
		}
		public void printLook()
		{
			getCurrentRoomDescription();
			Console.WriteLine(currentRoom.getLongDescription());
			Console.WriteLine();
			Console.WriteLine(Player.health);
			
		}

		public void printSearch()
		{
			getCurrentRoomDescription();
			Currentroom.getCurrentRoomItems();
			Currentroom.useItems();
		}
		public void printInventory()
		{
			Inventory.makeInventory();
		}

		/**
	     * Try to go to one direction. If there is an exit, enter the new
	     * room, otherwise print an error message.
	     */
		private void goRoom(Command command)
		{
			if (!command.hasSecondWord())
			{
				// if there is no second word, we don't know where to go...
				Console.WriteLine("Go where?");

				return;
			}

			string direction = command.getSecondWord();
			string levels = command.getThirdWord();

			// Try to leave current room.
			Room nextRoom = currentRoom.getExit(direction);

			if (nextRoom == null)
			{
				Console.WriteLine("There is no door to " + direction + "!");
			}
			else
			{
				currentRoom = nextRoom;
				Console.WriteLine(currentRoom.getLongDescription());
			}
		}
		public static void getCurrentRoomDescription()
		{
			descRoom = currentRoom.getShortDescription();
		}

		public static void getItem()
		{
			

		}

		public static void use(Command command)
		{
			
			string useItem = command.getSecondWord();

			if (useItem == "lantern")
			{
				Items.lantern = true;
			}
		}


		public static void drop(Command command)
		{
			string dropItem = command.getSecondWord();

			if (dropItem == "inv1")
			{
				Inventory.inv1 = null;
			}
			else if(dropItem == "inv2")
			{
				Inventory.inv2 = null;
			}
			else if (dropItem == "inv3")
			{
				Inventory.inv3 = null;
			}
			else if (dropItem == "inv4")
			{
				Inventory.inv4 = null;
			}
			else if (dropItem == "inv5")
			{
				Inventory.inv5 = null;
			}
		}
	}
}
