namespace QuizzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of the Philippines?", new string[] {"Cebu", "Davao", "Manila", "Dumaguete"}, 2),
                new Question("What is the national fish of the Philippines?", new string[] {"Tilapia", "Sardinas", "Tuna", "Bangus"}, 3),
                new Question("Which continent is the Philippines located?", new string[] {"Asia", "North America", "Antartica", "Africa"}, 0)
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
