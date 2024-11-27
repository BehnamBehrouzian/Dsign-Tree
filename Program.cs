
class Program
{
    static void Main()
    {
        int scoreE = 0, scoreI = 0, scoreS = 0, scoreN = 0, scoreT = 0, scoreF = 0, scoreJ = 0, scoreP = 0;

        //سوال یک
        Console.WriteLine("Question 1: You prefer to?");
        Console.WriteLine("A) Enjoy being in social gatherings.");
        Console.WriteLine("B) Prefer to spend more time alone.");
        string answer1 = Console.ReadLine();
        if (answer1 == "A") scoreE++;
        if (answer1 == "B") scoreI++;

        //سوال دو
        Console.WriteLine("Question 2: You tend to?");
        Console.WriteLine("A) Pay attention to details.");
        Console.WriteLine("B) Think more about the big picture.");
        string answer2 = Console.ReadLine();
        if (answer2 == "A") scoreS++;
        if (answer2 == "B") scoreN++;

        //سوال سه
        Console.WriteLine("Question 3: When making decisions, you usually?");
        Console.WriteLine("A) Pay attention to logical reasons.");
        Console.WriteLine("B) Your feelings play a more important role.");
        string answer3 = Console.ReadLine();
        if (answer3 == "A") scoreT++;
        if (answer3 == "B") scoreF++;

        //سوال چهار
        Console.WriteLine("Question 4: You prefer to?");
        Console.WriteLine("A) Plan ahead.");
        Console.WriteLine("B) Prefer to be flexible.");
        string answer4 = Console.ReadLine();
        if (answer4 == "A") scoreJ++;
        if (answer4 == "B") scoreP++;

        string personality = "";
        if (scoreE > scoreI) personality += "E";
        else personality += "I";

        if (scoreS > scoreN) personality += "S";
        else personality += "N";

        if (scoreT > scoreF) personality += "T";
        else personality += "F";

        if (scoreJ > scoreP) personality += "J";
        else personality += "P";

        Console.WriteLine("Your personality type: " + personality);
    }
}