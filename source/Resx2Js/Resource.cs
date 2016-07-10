
using System.Runtime.CompilerServices;

namespace MyResourceNamespace1
{
	public class Resource
	{
		public static string CurrentLanguageIsoCode { get; set; }

		[Template("typeof global.MyResourceNamespace1.Strings[{isoCode}]!= \"undefined\"")]
		private static bool ExistLanguage(string isoCode)
		{
			return false;
		}

		[Template("global.MyResourceNamespace1.Strings[{isoCode}][{key}]")]
		private static string GetStringInternal(string isoCode, string key)
		{
			return null;
		}

		private static string GetString(string key)
		{
			if (ExistLanguage(CurrentLanguageIsoCode))
			{
				var text = GetStringInternal(CurrentLanguageIsoCode, key);
				if (text != null)
					return text;
			}

			var txt = GetStringInternal("default", key);
			return txt;
		}

		
		public static string April { get { return GetString("april"); } }
		public static string August { get { return GetString("august"); } }
		public static string December { get { return GetString("december"); } }
		public static string Februrary { get { return GetString("februrary"); } }
		public static string January { get { return GetString("january"); } }
		public static string July { get { return GetString("july"); } }
		public static string June { get { return GetString("june"); } }
		public static string March { get { return GetString("march"); } }
		public static string May { get { return GetString("may"); } }
		public static string November { get { return GetString("november"); } }
		public static string October { get { return GetString("october"); } }
		public static string September { get { return GetString("september"); } }

	}
}