using System;

namespace AlaskanTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            gameIntro();
            gameScenesStart();

        }
        public static void gameIntro()
        {
            Console.WriteLine("|| Man is not at the top of the food chain in the mountains. ||");
            Console.WriteLine("|||||     To survive, they must do what is necessary.     |||||");
            Console.WriteLine("");
            Console.WriteLine("Press (Enter) to continue");
            Console.ReadLine();
            Console.WriteLine("What do they call you around these parts? Type: (your name) ");
            string name = Console.ReadLine();
            Console.WriteLine($"Choose your path carefully, {name} if you want to survive the unforgiving winter and dangerous predators ");
            Console.WriteLine("of the Great Alaskan Mountain Range. ");
            Console.WriteLine("Press (Enter) to continue");
            Console.ReadLine();

        }
        public static void gameScenesStart()
        {
            string choice;

            Console.WriteLine("Winter has come early this September, leaving you a snowy path ahead. ");
            Console.WriteLine("Unfortunately for you, there is no food at your cabin and you are getting hungry and losing daylight. ");
            Console.WriteLine("What's that? It looks like a fresh set of moose tracks.... ");
            Console.WriteLine("Press (Enter) to continue to your choices ");
            Console.ReadLine();
            Console.WriteLine("Do you take your rifle on foot and follow the moose tracks? Or do you get on your snowmobile to drive ");
            Console.WriteLine("20 miles towards your cabin? ");
            Console.WriteLine("Which path will you choose? Type: (follow the moose) or (get on snowmobile) ");

            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "follow the moose":
                case "follow":
                case "moose":
                case "follow moose":
                    {
                        Console.WriteLine("You continue on foot with your rifle, following the moose tracks. ");
                        Console.WriteLine("I can tell you're hungry. As you are carefully and slowly tracking the moose, you spot a plump "); 
                        Console.WriteLine("looking bird that would make a nice quick meal. ");
                        Console.WriteLine("Press (Enter) to continue to your choices ");
                        Console.ReadLine();
                        scene2a();
                        break;
                    }

                case "get on snowmobile":
                case "get on":
                case "snowmobile":
                    {
                        Console.WriteLine("You're riding on the snowmobile towards the cabin. You approach a frozen stream that you need to "); 
                        Console.WriteLine("cross to continue on your path. ");
                        Console.WriteLine("Press (Enter) to continue to your choices ");
                        Console.ReadLine();
                        scene2b();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command. ");
                        Console.WriteLine("Press (Enter) to try again.");
                        Console.ReadLine();
                        gameScenesStart();
                        break;
                    }
            }
        }
        public static void scene2a()
        {
            string choice;

            Console.WriteLine("Do you try to shoot the bird for a quick snack and make camp? ");
            Console.WriteLine("Or do you continue to track the moose? ");
            Console.WriteLine("Which path will you choose? Type : (shoot the bird) or (track the moose)");

            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "shoot the bird":
                case "shoot":
                case "bird":
                case "shoot bird":
                    {
                        Console.WriteLine("You attempt to shoot the bird, but your aim was off and you missed! ");
                        Console.WriteLine("Daylight is almost gone and you also scared off the moose. ");
                        Console.WriteLine("Press (Enter) to continue to your choices ");
                        Console.ReadLine();
                        scene3a();
                        break;
                    }

                case "track the moose":
                case "track":
                case "moose":
                case "track moose":
                    {
                        Console.WriteLine("Your years of tracking have paid off! You see the moose 50 yards away in the sights of your rifle. ");
                        Console.WriteLine("THE SUSPENSE is building ... Press (Enter) to find out what happens next. ");
                        Console.ReadLine();
                        Console.WriteLine("Bang!! Clean kill. No time for celebration because you hear a pack of wolves howling nearby. ");
                        Console.WriteLine("Press (Enter) to continue to your choices ");
                        Console.ReadLine();
                        scene3b();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command. ");
                        Console.WriteLine("Press (Enter) to try again.");
                        Console.ReadLine();
                        scene2a();
                        break;
                    }
            }
        }

        public static void scene2b()
        {
            string choice;

            Console.WriteLine("Do you risk crossing the frozen stream that could be partially thawed? ");
            Console.WriteLine("Or do you take the long road home down your trap line to potentially find some food? ");
            Console.WriteLine("Which path will you choose? Type : (cross the stream) or (take the long road)");

            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "cross the stream":
                case "cross":
                case "stream":
                case "cross stream":
                    {
                        Console.WriteLine("OH NO! You've somehow made it safely across the frozen stream, but the ");
                        Console.WriteLine("snowmobile sunk into a cracked thin sheet of ice in the stream. ");
                        Console.WriteLine("You will have to make it to the cabin 20 miles on foot. Just then, ");
                        Console.WriteLine("you hear a bear growl and notice some fresh bear scat nearby your trail. ");
                        Console.WriteLine("I guess this bear hasn't gone into hibernation and is still looking for a meal. ");
                        Console.WriteLine("That damn bear...And unfortunatley, all of your gear fell in the stream and was swept ");
                        Console.WriteLine("all of your gear fell in the stream and was swept away under the ice. However, you do notice ");
                        Console.WriteLine("your gun is just lodged in some brush. ");
                        Console.WriteLine("Press (Enter) to continue to your choices ");
                        Console.ReadLine();
                        scene4a();
                        break;
                    }

                case "take the long road":
                case "take road":
                case "road":
                case "long road":
                case "take long road":
                    {
                        Console.WriteLine("You've taken the long road with your snow mobile following your trap line and then you see ");
                        Console.WriteLine("a set of mountain lion tracks... ");
                        Console.WriteLine("Press (Enter) to continue to your choices ");
                        Console.ReadLine();
                        scene4b();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command. ");
                        Console.WriteLine("Press (Enter) to try again.");
                        Console.ReadLine();
                        scene2b();
                        break;
                    }
            }
        }

        public static void scene3a()
        {
            string choice;

            Console.WriteLine("Do you make camp and build a fire to keep warm? ");
            Console.WriteLine("Or do you try to make it back to the snow mobile? ");
            Console.WriteLine("Which path will you choose? Type : (make camp) or (make it back to the snowmobile)");

            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "make camp":
                case "camp":
                case "build fire":
                case "keep warm":
                    {
                        Console.WriteLine("Congratulations! You've survived the Alaskan Winter Night, you have food in your ");
                        Console.WriteLine("belly, and you've managed to stay warm. Well Done! ");
                        Console.WriteLine("Press (Enter) to continue");
                        Console.ReadLine();
                        adventureOver();
                        break;
                    }

                case "make it back to the snowmobile":
                case "back to the snowmobile":
                case "back to the snow mobile":
                case "snowmobile":
                case "snow mobile":
                case "make it back to the snow mobile":
                    {
                        Console.WriteLine("On the way back to the snowmobile, you took a wrong step in a snowy drift and stepped into ");
                        Console.WriteLine("a bear trap. Unable to escape, you died of exposure. I'm real sorry. ");
                        Console.WriteLine("Press (Enter) to continue");
                        Console.ReadLine();
                        adventureOver();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command. ");
                        Console.WriteLine("Press (Enter) to try again.");
                        Console.ReadLine();
                        scene3a();
                        break;
                    }
            }
        }

        public static void scene3b()
        {
            string choice;

            Console.WriteLine("Do you try to clean and pack the moose meat and head back towards the snowmobile? ");
            Console.WriteLine("Or do you make camp and defend what is rightfully yours from the blood thirsty wolves? ");
            Console.WriteLine("Which path will you choose? Type : (clean and pack the moose meat) or (defend camp) ");

            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "clean and pack the moose meat":
                case "clean and pack the meat":
                case "clean and pack the moose":
                case "clean and pack":

                    {
                        Console.WriteLine("You got lucky, the nearby wolves picked up the scent of an injured elk and you ");
                        Console.WriteLine("were able to clean and pack the moose meat to take to the cabin on your snowmobile. ");
                        Console.WriteLine("Congratulations, you are a true mountaineer. ");
                        Console.WriteLine("Press (Enter) to continue");
                        Console.ReadLine();
                        adventureOver();
                        break;
                    }

                case "defend camp":
                case "make camp":
                case "camp":
                case "defend":

                    {
                        Console.WriteLine("A pack of four wolves circle around you and the moose carcass. You are able to ");
                        Console.WriteLine("quickly shoot and kill two of them. But the other two decend on you quickly. With your ");
                        Console.WriteLine("rifle in one hand, and a flaming log in the other, you shoot the third wolf as the fourth ");
                        Console.WriteLine("jumps towards you. The wolf's powerful jaws clamp down on your arm, holding the flaming log, ");
                        Console.WriteLine("and rips your arm off. As you fight for your life, you manage to swing your gun around and ");
                        Console.WriteLine("shoot him right in the heart. You put your belt around your arm as a tourniquet ");
                        Console.WriteLine("just barely surviving throughout the night. Congratulations, you have survived! However, you ");
                        Console.WriteLine("were not able to clean and pack the moose with one arm. Looks like you'll have a ");
                        Console.WriteLine("long and hungry winter ahead. ");
                        Console.WriteLine("Press (Enter) to continue");
                        Console.ReadLine();
                        adventureOver();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I don't understand that command. ");
                        Console.WriteLine("Press (Enter) to try again.");
                        Console.ReadLine();
                        scene3a();
                        break;
                    }
            }
        }

        public static void scene4a()
        {
            string choice;

            Console.WriteLine("Do you rub the bear scat all over your body to mask your scent from the bear? ");
            Console.WriteLine("Or do you get the rifle from the frozen stream? ");
            Console.WriteLine("Which path will you choose ? Type : (rub bear scat all over) or (get rifle) ");

            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "rub bear scat all over":
                case "rub bear scat":
                case "bear scat":
                case "rub scat":
                case "scat":

                    {
                        Console.WriteLine("You hike through the woods right past the bear without him noticing you! It takes ten hours, ");
                        Console.WriteLine("but you finally make it back to your cabin and you draw a warm bath. Congratulations, enjoy. ");
                        Console.WriteLine("Press (Enter) to continue");
                        Console.ReadLine();
                        adventureOver();
                        break;
                    }

                case "get rifle":
                case "rifle":
                case "get gun":
                case "gun":

                    {
                        Console.WriteLine("Yikes! You've fallen in the icy stream! There was a root that tripped you as you. ");
                        Console.WriteLine("reached for the rifle. You're soaked to the bone in icy cold water and you slowly die of ");
                        Console.WriteLine("hypothermia.Sorry, it's just too cold out there. ");
                        Console.WriteLine("Press (Enter) to continue");
                        Console.ReadLine();
                        adventureOver();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I don't understand that command. ");
                        Console.WriteLine("Press (Enter) to try again.");
                        Console.ReadLine();
                        scene4a();
                        break;
                    }
            }
        }

        public static void scene4b()
        {
            string choice;

            Console.WriteLine("Do you follow the mountain lion to see if you could set a trap? This would make a fine pelt to sell or trade. ");
            Console.WriteLine("Or do you continue down your trap line to see if anything is in your traps? ");
            Console.WriteLine("Which path will you choose? Type : (follow the mountain lion) or (continue down trap line) ");

            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "follow the mountain lion":
                case "mountain lion":
                case "follow mountain lion":
                case "follow lion":
                case "lion":

                    {
                        Console.WriteLine("You follow the mountain lion tracks and it leads you to a small cave about fifty feet ");
                        Console.WriteLine("off of your trap line. As you approach the cave, you see the mountain lion peeking out at ");
                        Console.WriteLine("you. As you get closer, he begins to growl. Years of hunting in the Alaskan Wilderness has ");
                        Console.WriteLine("taught you that these big cats are cunning and aggressive. The big cat slowly walks out of ");
                        Console.WriteLine("the cave staring you in the eyes. As the cat stalks toward you, you pull out your rifle, aim ");
                        Console.WriteLine("down the sights, hold your breath, and squeeze the trigger. You're a lucky shot! You make it ");
                        Console.WriteLine("out alive and with a premium fur! Congratulations! ");
                        Console.WriteLine("Press (Enter) to continue");
                        Console.ReadLine();
                        adventureOver();
                        break;
                    }

                case "continue down trap line":
                case "continue down":
                case "trap line":
                case "continue trap line":

                    {
                        Console.WriteLine("You're continuing down your trap line and have picked up quite a few lynx and fox pelts. ");
                        Console.WriteLine("Unknowingly, the mountain lion has been stalking your trap line. The big cat ambushes you ");
                        Console.WriteLine("while you were resetting one of your traps! It jumps on your back, clawing. It bites and ");
                        Console.WriteLine("breaks your neck instantly. I'm sorry, but you are never seen by anyone ever again. ");
                        Console.WriteLine("Press (Enter) to continue");
                        Console.ReadLine();
                        adventureOver();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("I don't understand that command. ");
                        Console.WriteLine("Press (Enter) to try again.");
                        Console.ReadLine();
                        scene4a();
                        break;
                    }
            }
        }
        public static void adventureOver()
        {
            Console.WriteLine("Thank you for going on this adventure! Play through again to choose another path. ");
        }
    }
}

