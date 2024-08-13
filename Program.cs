
using System.Runtime.CompilerServices;
using System.Xml;
bool runProgram = true;
while (runProgram == true)
{
    string[] studentName = {"Justin Jones","DeAngelo Robinson", "Martina Basquez", "Alain Rene", "David Goodwin", "Joey Molinski", "Wren Grasley", "Brady Hartman", "David Brameijer", "Afseen Salam", "Ethan Thomas"};
    string[] studentHometown = { "Westerville", "Detroit", "Edinburg", "Homestead", "Jersey City", "Toledo", "Richmond", "Saranac", "Grand Rapids", "India", "Bolivar"};
    string[] favoriteFood = {"Baja Blast", "Pizza", "Leftovers", "Chicken Wings", "Sushi", "Dill Pickles", "Pizza", "Chicken Wings", "Tacos", "Shawarma", "Grapes"};

    Console.WriteLine(studentName);


    Console.Write("Please enter a number between 1-11 to learn about a student: ");

    int nameNum = int.Parse(Console.ReadLine());
    
    
        
        if (nameNum < 1 && nameNum > 11)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1-11: ");
            Console.Write("Please enter a number between 1-11 to learn about a student: ");
        }
        else
        {
            nameNum = nameNum - 1;
            Console.WriteLine("Student name " + studentName[nameNum]);
        }
        Console.Write("Would you like to know the student's Hometown or Favorite Food? ");
        string category = Console.ReadLine().ToLower();

        while (category != "hometown" && category != "favorite food")
        {
            Console.WriteLine("That's not a valid category. Please try again");
            Console.Write("Would you like to know the student's Hometown or Favorite Food? ");
            category = Console.ReadLine();
        }
        if (category == "hometown")
        {
            Console.WriteLine($"{studentName[nameNum]}'s Hometown: {studentHometown[nameNum]}");
        }
        else
        {
            Console.WriteLine($"{studentName[nameNum]}'s Favorite Food: {favoriteFood[nameNum]}");

        }
        while (true)
        {
            Console.WriteLine("Would you like to look up another student? y/n");
            string loopChoice = Console.ReadLine();
            if (loopChoice == "y")
            {
                break;

            }
            else if (loopChoice == "n")
            {
                runProgram = false;
                break;
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

    
}

