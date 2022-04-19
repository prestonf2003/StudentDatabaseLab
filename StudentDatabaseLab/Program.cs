public class Program
{

    public static void Main()
    {
        bool runagain = true;
        while (runagain == true)
        {
            string student = GetUserInput("Please Pick A number 1-3 or ask for a list").ToLower();
            string[] studentnames = { "Preston", "Nicholas", "Adam" };
            string[] homeTown = { "Bloomfield", "Rochester", "Alpena" };
            string[] favoriteFood = { "Pasta", "Nachos", "Apple Pie" };
            if (student == "list")
            {
                Console.WriteLine("1 = Preston");
                Console.WriteLine("2 = Nicholas");
                Console.WriteLine("3 = Adam");
                continue;

            }

            else if(student == "1" || student == "2" || student == "3" )
            {
              int num = int.Parse(student);
               int index = num - 1;
                Console.WriteLine(studentnames[index]);
                string SecondPrompt = GetUserInput("Hometown or favorite food?").Trim();
                if (SecondPrompt == "favoritefood")
                {
                    Console.WriteLine(favoriteFood[index]);
                }
                else if(SecondPrompt == "hometown")
                {
                    Console.WriteLine(homeTown[index]);
                }
                runagain = RunAgain();
            }
            else
            {
                Console.WriteLine("I didnt understand that try again");
                continue;
            }
        }
    }
    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        return input;
    }
    public static bool RunAgain()
    {
        string answer = GetUserInput("Would you like to run again? y/n");
        if (answer == "y")
        {
            return true;
        }
        else if (answer == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("I'm sorry I didn't understand that");
            Console.WriteLine("Please input y or n");
            Console.WriteLine("Lets try again");
            return RunAgain();
        }
    } 

}