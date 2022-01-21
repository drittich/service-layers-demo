namespace service_layers_demo
{
	public class UserColors
	{
		public static string[] colors = new string[] { "red", "blue", "green", "viridian" };

		// Caching variable
		private static Dictionary<int, string> _getFavourite = new Dictionary<int, string>();

		/// <summary>
		/// Evil static method
		/// </summary>
		/// <param name="userID"></param>
		/// <returns></returns>
		public static string GetFavourite(int userID)
		{
			if (!_getFavourite.ContainsKey(userID))
			{
				_getFavourite[userID] = colors[new Random().Next(colors.Length)];
			}

			return _getFavourite[userID];
		}
	}
}
