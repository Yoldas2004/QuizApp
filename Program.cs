namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions[] question = new Questions[]
            {
                new Questions("What Is The Capital Of Turkey?",
                new string [] {"Istanbul","Ankara","Antalya","Izmir"},
                1),
                new Questions("Which Planet Is Known As The Red Planet?",
    new string [] {"Earth","Mars","Jupiter","Venus"},
    1),

    new Questions("Which Language Is Used In Unity Game Engine?",
    new string [] {"Python","C#","Java","C++"},
    1),

    new Questions("Who Developed The Theory Of Relativity?",
    new string [] {"Isaac Newton","Albert Einstein","Nikola Tesla","Galileo Galilei"},
    1),

    new Questions("Which Data Type Is Used For True/False In C#?",
    new string [] {"int","string","bool","float"},
    2),

    new Questions("Which Company Developed The Unity Engine?",
    new string [] {"Epic Games","Unity Technologies","Valve","Microsoft"},
    1)
            };
            Quiz quiz  = new Quiz(question);
            quiz.StartQuiz();
           
            Console.ReadKey();
        }
    }
}
