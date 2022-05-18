using System;
using System.Linq;

namespace Navigation
{
	//`+SmartNav

	// Use Caps+Down/Up to navigate among sibling nodes in the code.
	// SmartNav attempts to preserve caret location and selection as you 
	// move from node to node (e.g., member to member).
	
	// Try it on the code here!

	public class MathUtils
	{
		//`![](ArrowSW;;;0.008,0.008) Caps+Down to move down through the methods.
		public static bool IsChecked(string entry)
		{
			if (entry == null)
				return false;
			return entry.ToLower().Trim() == "x";
		}

		// Let's make the rest of these methods public.

		//`![](ArrowSW;;;0.008,0.008) Tip: use Alt+Up/Down to cycle through available member visibilities.
		static int GetInt(string str, int defaultValue = 0)
		{
			if (!string.IsNullOrEmpty(str) && int.TryParse(str, out int result))
				return result;
			return defaultValue;
		}

		//`![](ArrowSW;;;0.008,0.008) Alt+Down to make public, then Caps+Down to move to the next member.
		static double GetDouble(string str, double defaultValue = 0)
		{
			if (!string.IsNullOrEmpty(str) && double.TryParse(str, out double result))
				return result;
			return defaultValue;
		}

		//`![](ArrowSW;;;0.008,0.008) Remember, you can also use Caps+Up to move up through the methods.
		static string BoolToStr(bool value)
		{
			if (value)
				return "x";
			return string.Empty;
		}
	
	}
	//`![](GotIt;vscommand:File.Close;;0.012,0.012)
}
