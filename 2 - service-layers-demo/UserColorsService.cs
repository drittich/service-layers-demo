using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service_layers_demo
{
	public class UserColorsService : IUserColorsService
	{
		public UserColorsService() { }

		public string GetFavourite(int userID)
		{
			return UserColors.GetFavourite(userID);
		}
	}
}
