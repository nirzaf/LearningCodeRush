using System.Collections.Generic;

namespace CapsModifier
{
	public partial class ImplicitExplicit
	{
		static Dictionary<int, Customer> dictionary = new Dictionary<int, Customer>();

		private static string FoundRecord(int value)
		{
			return "Found record #" + value + "!";
		}
	}
}
