public class Program
{
    public static List<string> studentnames = new List<string>() { "Preston", "Nicholas", "Adam" };
    public static List<string> homeTown = new List<string>() { "Bloomfield", "Rochester", "Alpena" };
    public static List<string> favoriteFood = new List<string>() { "Pasta", "Nachos", "Apple Pie" };
    public static List<string> favoriteColor = new List<string>() { "Purple", "Green", "Red" };
    public static List<string> AcceptableSecondInputs = new List<string>() { "favoritefood", "food", "ff", "homtown", "home", "town", "color" };
    public static int studentNum;
    public static int index;
    public static int RawIndex;
    public static void Main()
    {
        bool runagain = true;
        while (runagain == true)
        {
            string student = GetUserInput($"Please Pick A number 1-{studentnames.Count} Name a student or list for a list");
            char first = char.ToUpper(student[0]);
            string studentCase = first + student.Substring(1);
            Console.WriteLine(studentCase);

            try
            {
                studentNum = int.Parse(student);
                index = studentNum - 1;

            }
            catch (Exception ex)
            {

            }
            if (student == "list")
            {
                for (int i = 0; i < studentnames.Count; i++)
                {
                    Console.WriteLine(studentnames[i]);
                }

            }

            else if (studentNum >= 1 && studentNum <= studentnames.Count || studentnames.Contains(studentCase))
            {
                int RawIndex = studentnames.IndexOf(studentCase);
                if (RawIndex < 0)
                {
                    {
                        RawIndex = index;
                    }
                    string SecondPrompt = GetUserInput($"would you like to know {studentnames[RawIndex]}'s favorite food, color or where they are from").Trim();
                    while (!AcceptableSecondInputs.Contains(SecondPrompt))
                    {
                        SecondPrompt = GetUserInput($"would you like to know {studentnames[RawIndex]}'s favorite food, color or where they are from").Trim();
                    }
                    if (SecondPrompt == "favoritefood" || SecondPrompt == "food" || SecondPrompt == "ff")
                    {
                        Console.WriteLine($" {studentnames[RawIndex]}'s favorite food is {favoriteFood[RawIndex]}");
                    }
                    else if (SecondPrompt == "hometown" || SecondPrompt == "home" || SecondPrompt == "town")
                    {
                        Console.WriteLine($"{studentnames[RawIndex]}'s hometown is {homeTown[RawIndex]}");
                    }
                    else if (SecondPrompt == "color")
                    {
                        Console.WriteLine($"{studentnames[RawIndex]}'s favorite color is {favoriteColor[RawIndex]}");

                    }
                    else
                    {
                        Console.WriteLine("You Had one job to pic favorite food or hometown");

                    }
                    string addStudent = GetUserInput("would you like to add another students info? y/n");
                    if (addStudent == "y")
                    {


                        string name = GetUserInput("What is their name");
                        while (name == "")
                        {
                            name = GetUserInput("What is their name");
                        }
                        char firstName = char.ToUpper(name[0]);
                        string nameCase = firstName + name.Substring(1);
                        studentnames.Add(nameCase);
                        AddInfo(name);


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
    public static void AddInfo(string name)
    {
        string UnAcceptable = "";

        string Hometown = GetUserInput($"where is {name} from?");
        while (Hometown == UnAcceptable)
        {
            Hometown = GetUserInput($"where is {name} from?");
        }

        string FavColor = GetUserInput($"What is {name}'s favorite color?");
        while (FavColor == UnAcceptable)
        {
            FavColor = GetUserInput($"What is {name}'s favorite color?");
        }
        string FavFood = GetUserInput($"what is {name}'s favorite food?");
        while (FavFood == UnAcceptable)
        {
            FavFood = GetUserInput($"what is {name}'s favorite food?");
        }
        homeTown.Add(Hometown);
        favoriteColor.Add(FavColor);
        favoriteFood.Add(FavFood);
        Console.WriteLine("Here is the info on the new student");
        Console.WriteLine("Their name is: " + studentnames.Last());
        Console.WriteLine("They are from: " + homeTown.Last());
        Console.WriteLine("There favorite color is: " + favoriteColor.Last());
        Console.WriteLine("There favorite food is: " + favoriteFood.Last());
        



    }
}