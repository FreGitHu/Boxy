internal class Program
{
    private static void Main(string[] args)
    {
		try
		{
			if (args[1] == "--help")
			{
				Console.WriteLine("The Boxy Programming Language")
			}

		}
		catch (IndexOutOfRangeException)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Not enough arguments specifed");
			Environment.Exit(1);
			throw;
		}
    }
}