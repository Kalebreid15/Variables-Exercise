namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string myName = "Kaleb";
            int age = 28;
            double avg = 89.5;
            decimal bankAccount = 100000.50m;
            bool isEmployed = true;
            char initial = 'K';

            Console.WriteLine($"Name: {myName}\nAge: {age}\nAverage: {avg}\nMoney: {bankAccount}\nInitial: {initial}\nEmployed: {isEmployed}");
        }
    }
}
