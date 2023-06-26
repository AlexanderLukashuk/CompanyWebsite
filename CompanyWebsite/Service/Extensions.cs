using System;
namespace CompanyWebsite.Service
{
	public static class Extensions
	{
		public static string CutController(this string str)
		{
			return str.Replace("Controller", "");
		}
	}
}

