string[] name = { "Barbara", "Jean", "Bennett", "Noelle", "Amber" };
string[] food = { "Seafood", "Soup", "Fried Egg", "Pancakes", "Steak" };
string[] hometown = { "New York", "London", "Los Angeles", "Grand Rapids", "Toldeo" };
        //Console.WriteLine("Welcome! Which student would you like to learn about? Enter a number 1-5: ");
        bool runAgain = true;
        while (runAgain)
        {
            int input = 0;
            while (true)
            {
                Console.WriteLine("Welcome! Which student would you like to learn about? Enter a number 1-5: ");
                for (int i = 0; i < name.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {name[i]}");
                }
                string student = Console.ReadLine();
                if (name.Contains(name[input]))
                {
                    input = Array.IndexOf(name, student);
                    break;
                }
                input = int.Parse(student) - 1;
                if (input >= 0 && input < name.Length)
                {
                    break;
                }
                //string Name = Console.ReadLine();
                //else if (names.Contains(Name))
                //{
                //    input = Array.IndexOf([names], Name);
                //    break;
                //}
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand.");
                }
            }
            while (true)
            {
                Console.WriteLine($"What would you like to know? Enter 'hometown' or 'favourite food': ");
                string character = Console.ReadLine();
                //if(character,ToLower() == "hometown" && "home")
                //{
                //  Console.WriteLine($"{name[input]}'s hometown is {homwtown[inpuut]}");
                //break;
                //}
                //else if(character,ToLower() == "food" && "favourite food")
                //{
                //  Console.WriteLine($"{name[input]}'s favourite food is {food[inpuut]}");
                //break;
                //}
                if (character.ToLower() == "hometown" || character.ToLower() == "home")
                {
                    Console.WriteLine($"Their hometown is: {hometown[input]}");
                    break;
                }
                else if (character.ToLower() == "favorite food" || character.ToLower() == "food")
                {
                    Console.WriteLine($"Their favourite food is: {food[input]}");
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand");
                }
            }
            while (true)
            {
                Console.WriteLine("Would you like to learn about another student? Enter (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower().Trim() == "y")
                {
                    runAgain = true;
                    break;
                }
                else if (answer.ToLower() == "n")
                {
                    runAgain = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand.");
                }
            }

        }