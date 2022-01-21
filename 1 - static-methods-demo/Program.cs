using static_methods_demo;

internal class Program
{
	static void Main(string[] args)
	{
		// most of our code does something like this:
		var currentUserID = 123;
		var favouriteColor = UserColors.GetFavourite(currentUserID);
		Console.WriteLine(favouriteColor);
	}
}
