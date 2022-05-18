using System.Collections.Generic;

namespace CapsModifier
{
	public partial class ImplicitExplicit
	{
		//`![](CapsSpace;crcommand:OpenFile:CapsSpace.cs;;0.012,0.012) converts between implicit & explicit declarations.

		// Move to where the arrows (![](ArrowDown;;;0.006,0.006)) point before pressing the shortcut.

		public static void InitializeImplicitly(int? foo)
		{
			//`![](ArrowDown;;;0.008,0.008) Caps+Space to make these variable declarations implicit: 
			byte[] bar1 = dictionary[foo.Value].Id.ToByteArray();

			//`![](ArrowDown;;;0.008,0.008) 
			string bar2 = foo.HasValue ? FoundRecord(foo.Value) : "baz";

			//`![](ArrowDown;;;0.008,0.008) 
			Dictionary<int, Customer>.KeyCollection bar3 = dictionary.Keys;
		}


		//`![](SmartNav;crcommand:OpenFile:SmartNav.cs;;0.012,0.012)  << Learn about SmartNav...

		//++ Pro Tip
		// You can alternate Caps+Space with Caps+Down (SmartNav) to convert 
		// variable declarations even faster. Try it in the code below.


		public static void InitializeExplicitly(int? foo)
		{
			//`![](ArrowDown;;;0.008,0.008) Caps+Space to make explicit (and then Caps+Down to move the caret): 
			var bar1 = dictionary[foo.Value].Id.ToByteArray();


			//`![](ArrowDown;;;0.008,0.008) 
			var bar2 = foo.HasValue ? FoundRecord(foo.Value) : "baz";


			//`![](ArrowDown;;;0.008,0.008) 
			var bar3 = dictionary.Keys;


			//`![](ArrowDown;;;0.008,0.008) 
			var bar4 = new int[foo.Value * foo.Value, 5];
		}
	}

	//`![](BtnMoreLikeThis;crcommand:OpenFile:ExpressionBodies.cs;;0.012,0.012) << Expression Bodies and more...
}



//`![](NextLesson;crcommand:OpenFile:CapsDelete.cs;;0.012,0.012)  << Skip ahead to the next lesson (Caps+Delete)...
