using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SCI_Controllers
{
	public static class Helper
	{
		private static Random random = new Random();

		public static string GerarSenha()
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, 8)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

		public static string GerarNumeroBoleto()
		{
			const string chars = "0123456789";
			return new string(Enumerable.Repeat(chars, 44)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}


		public static string ToMD5(this string text)
		{
			MD5 md5Hash = MD5.Create();
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

			StringBuilder sBuilder = new StringBuilder();

			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			return sBuilder.ToString();
		}
	}
}