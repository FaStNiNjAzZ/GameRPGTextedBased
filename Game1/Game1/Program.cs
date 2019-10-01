using System;



class MainClass
{
    public static void Main(string[] args)
    {
        //Title
        Console.WriteLine(@" ______     ______   ______     __         __         ______    ");
        Console.WriteLine(@"/\  __ \   /\  == \ /\  __ \   /\ \       /\ \       /\  __ \   ");
        Console.WriteLine(@"\ \  __ \  \ \  _-/ \ \ \/\ \  \ \ \____  \ \ \____  \ \ \/\ \  ");
        Console.WriteLine(@" \ \_\ \_\  \ \_\    \ \_____\  \ \_____\  \ \_____\  \ \_____\  ");
        Console.WriteLine(@"  \/_/\/_/   \/_/     \/_____/   \/_____/   \/_____/   \/_____/ ");
        //Choosing a username
        string username;
        Console.WriteLine("What is your name?");
        username = Console.ReadLine();
        Console.WriteLine("Welcome " + username);

        //First choice/attack
        Console.WriteLine("A thief wants to steal your stuff. Do you run or attack?");
        int knife = 0;
        int gun = 0;
        int xp;
        xp = 0;
        string choice1;
        choice1 = Console.ReadLine();

        //Run
        if (choice1 == "run")
        {
            Console.WriteLine(username + " ran away from the thief..." + "5xp gained.");
            xp = xp + 5;
            Console.WriteLine(@"                _
              _( }
    -=   _  <<  \
        `.\__/`/\\
  -=      '--'\\  `
       -=     //
              \)");
        }

        else
        {
            //Fight
            if (choice1 == "attack")
            {
                int thiefHealth = 10;
                while (thiefHealth > 0)
                {
                    Console.WriteLine(username + " attacks. Do you attack him with gun, knife or fists");
                    string attack;
                    attack = Console.ReadLine();
                    if (attack == "fists")
                    {
                        Random rng = new Random();
                        int rngAttack = rng.Next(1, 4);
                        Console.WriteLine(username + " attacks with fists. " + rngAttack + " Damage!");
                        thiefHealth = thiefHealth - rngAttack;
                    }
                    if (attack == "knife")
                    {
                        Console.WriteLine(username + " has no knife. " + 0 + " Damage!");
                    }
                    if (attack == "gun")
                    {
                        Console.WriteLine(username + " has no gun. " + 0 + " Damage!");
                    }
                }
                Console.WriteLine("Thief has died. 100xp gained.");
                xp = xp + 100;
            }
        }
        //Enter building
        string choice2;
        Console.WriteLine("You come across a old building. Do you enter through door 1 or 2?");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(@"##########
#        #
#        #
#        #
##########
######--*#
##########
##########
##########
");
        }
        choice2 = Console.ReadLine();
        //Door 1
        if (choice2 == "1")
        {
            Console.WriteLine("There are some containers. Open 1 or 2?");
            string choice;
            int i = 0;
            do
            {
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Nothing...");
                }
                if (choice == "2")
                {
                    knife = 1;
                    Console.WriteLine("You found a knife.");
                    i++;
                }
            }
            while (i < 1);
        }
        //Door 2
        else
        {
            Console.WriteLine("You found a gun.");
            gun = 1;
        }

        //Fight 2
        Console.WriteLine("Another armed thief want's to steal your stuff, the only option is to attack him. He is wearing body armor with 50% resistance.");
        int thiefHealth1 = 1000;
        string attack1;
        while (thiefHealth1 > 0)
        {
            Console.WriteLine(username + " attacks. Do you use a gun, knife or fists?");
            attack1 = Console.ReadLine();
            if (attack1 == "fists")
            {
                Random rng = new Random();
                int rngAttack = rng.Next(1, 4);
                Console.WriteLine(username + " attacks with fists. " + rngAttack + " Damage!");
                thiefHealth1 = thiefHealth1 - rngAttack;
            }
            if (attack1 == "knife")
            {
                if (knife == 1)
                {
                    Random rng = new Random();
                    int rngAttack = rng.Next(500, 750);
                    Console.WriteLine(username + " attacks with knife. " + rngAttack + " Damage!");
                    thiefHealth1 = thiefHealth1 - rngAttack;
                }
                if (knife == 0)
                {
                    Console.WriteLine(username + " has no knife" + 0 + " damage");
                }


                if (attack1 == "gun")
                {
                    if (gun == 1)
                    {
                        Random rng = new Random();
                        int rngAttack = rng.Next(750, 1000);
                        Console.WriteLine(username + " attacks with gun. " + rngAttack + " Damage!");
                        thiefHealth1 = thiefHealth1 - rngAttack / 2;
                    }
                    if (gun == 0)
                    {
                        Console.WriteLine(username + " has no gun" + 0 + " damage");
                    }
                }
            }
        }
    }

    
}