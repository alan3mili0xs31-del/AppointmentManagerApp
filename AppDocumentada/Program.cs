namespace AppDocumentada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                int number = Utilities.GetIntegerFromConsole("Give a prime number");
                Console.WriteLine($"The number given was: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error from console: {ex.Message}");
            }
            
        }
    }
}
